using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine
{
  public partial class PlayerForm : Form
  {
    World mWorld; 

    public PlayerForm(World world)
    {
      mWorld = world;
      InitializeComponent();
    }

    public void updateUI(Player player)
    {
      if (player.active)
      {
        lblPeasantsNum.Text = player.Territory.Town.mPeasants.ToString();
        lblHinterlands.Text = player.Territory.Hinterlands.mSoldiers.ToString();
        lblPlayerNum.Text = player.playerId.ToString();
        lblTurnCardNum.Text = player.mTurnCard.turnCardId.ToString();
        lblNumGold.Text = player.mGold.ToString();
        //numRmvPeasant.Minimum = 1;
        //numRmvPeasant.Maximum = mWorld.players.Count();
        tbnEndPeaceTerms.Enabled = player.currentTurn;
        //btnRemovePlayersPeasant.Enabled = player.currentTurn;
        //numRmvPeasant.Enabled = player.currentTurn;
        lblFarmlands.Text = player.Territory.Farmlands.mSoldiers.ToString();
        lblFortress.Text = player.Territory.Fortress.mSoldiers.ToString();
        btnDeclareLoyalty.Enabled = player.currentTurn;

        listCards.Items.Clear();
        foreach (String str in player.mFortuneCards.Select(n => n.cardName))
        {
          listCards.Items.Add(str);
        }
        foreach (String str in player.mIntelligenceCards.Select(n => n.cardName))
        {
          listCards.Items.Add(str);
        }
      }
      else
      {
        this.Opacity = .9;
        lblAlive.Text = "!!!DEAD!!!";
      }
    }

    private void btnTakeTurn_Click(object sender, EventArgs e)
    {
      mWorld.EndTurn();
      btnTakeTurn.Enabled = false;
    }

    private void btnDeclareLoyalty_Click(object sender, EventArgs e)
    {
      mWorld.DeclareLoyalty((int)numDeclareLoyalty.Value, Convert.ToInt32(lblPlayerNum.Text));
    }

    internal void acceptDenyUI()
    {
      btnAcceptLoyalty.Enabled = true;
      btnDenyLoyalty.Enabled = true;
    }

    private void btnAcceptLoyalty_Click(object sender, EventArgs e)
    {
      mWorld.acceptLoyalty(Convert.ToInt32(lblPlayerNum.Text));
    }

    internal void loyalToUI(int loyalToPlayerId)
    {
      lblLoyalTo.Text = loyalToPlayerId.ToString();
    }

    private void btnUseCard_Click(object sender, EventArgs e)
    {
      string usedCardName = listCards.SelectedItem.ToString();
      if(mWorld.playerUsesCard(usedCardName, (int)numUseCardPlayer.Value))
      {
        listCards.Items.Remove(listCards.SelectedItem.ToString());
      }
    }

    private void tbnEndPeaceTerms_Click(object sender, EventArgs e)
    {
      btnEndPoliticalPhase.Enabled = true;
      lblCurrentPhase.Text = "Political Phase";
      tbnEndPeaceTerms.Enabled = false;
    }

    private void btnEndPoliticalPhase_Click(object sender, EventArgs e)
    {
      btnEndEconomicPhase.Enabled = true;
      lblCurrentPhase.Text = "Economic Phase";
      btnEndPoliticalPhase.Enabled = false;
    }

    private void btnEndEconomicPhase_Click(object sender, EventArgs e)
    {
      btnEndMilitaryPhase.Enabled = true;
      lblCurrentPhase.Text = "Military Phase";
      btnEndEconomicPhase.Enabled = false;
    }

    private void btnEndMilitaryPhase_Click(object sender, EventArgs e)
    {
      btnTakeTurn.Enabled = true;
      lblCurrentPhase.Text = "End of Turn";
      btnEndMilitaryPhase.Enabled = false;
    }
  }
}
