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

    public void updateUI(Player player){
      lblPeasantsNum.Text = player.Territory.Town.mPeasants.ToString();
      lblHinterlands.Text = player.Territory.Hinterlands.mSoldiers.ToString();
      lblPlayerNum.Text = player.playerId.ToString();
      lblTurnCardNum.Text = player.mTurnCard.turnCardId.ToString();
      lblNumGold.Text = player.mGold.ToString();
      numRmvPeasant.Minimum = 1;
      numRmvPeasant.Maximum = World.players.Count();
      btnTakeTurn.Enabled = player.currentTurn;
      btnRemovePlayersPeasant.Enabled = player.currentTurn;
      numRmvPeasant.Enabled = player.currentTurn;
    }

    private void btnRemovePlayersPeasant_Click(object sender, EventArgs e)
    {
      mWorld.RemovePlayersPeasant((int)numRmvPeasant.Value);
    }

    private void btnTakeTurn_Click(object sender, EventArgs e)
    {
      mWorld.EndTurn();
    }
  }
}
