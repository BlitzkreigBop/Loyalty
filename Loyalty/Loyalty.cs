using Engine;
using Engine.Cards.TurnCards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loyalty
{
  public partial class Loyalty : Form
  {
    public Loyalty()
    {
      InitializeComponent();

      
       
    }

    private List<TurnCard> assembleTurnCards()
    {
      List<TurnCard> turnCards = new List<TurnCard>()
      {
        new TurnCard1(),
        new TurnCard2(),
        new TurnCard3(),
        new TurnCard4(),
        new TurnCard5(),
        new TurnCard6()
      };

      return turnCards;
    }

    private List<IntelligenceCard> assembleIntelligenceCards()
    {
      List<IntelligenceCard> intelligenceCards = new List<IntelligenceCard>()
      {
        new Maneuver(),
        new ScorchedEarth(),
        new SecretAlliance(),
        new SpiesAndInformers(),
        new SpiesAndInformers(),
        new SupplyLines()
      };

      return intelligenceCards; 
    }

    private List<FortuneCard> assembleFortuneCards()
    {
      List<FortuneCard> fortuneCards = new List<FortuneCard>()
      {
        new Famine(),
        new LostShipment(),
        new Pillage(),
        new PlentifulHarvest(),
        new SoloWin(),
        new Weather()
      };

      return fortuneCards;
    }

   /* private void InitializeUI(World world)
    {
      lblNumOfPeasantsP1.Text = world.players[0].Territory.Town.mPeasants.ToString();
      lblNumOfPeasantsP2.Text = world.players[1].Territory.Town.mPeasants.ToString();
      lblNumOfPeasantsP3.Text = world.players[2].Territory.Town.mPeasants.ToString();
      lblNumOfPeasantsP4.Text = world.players[3].Territory.Town.mPeasants.ToString();
      lblNumOfPeasantsP5.Text = world.players[4].Territory.Town.mPeasants.ToString();
      lblNumOfPeasantsP6.Text = world.players[5].Territory.Town.mPeasants.ToString();

      lblNumGoldP1.Text = world.players[0].mGold.ToString();
      lblNumGoldP2.Text = world.players[1].mGold.ToString();
      lblNumGoldP3.Text = world.players[2].mGold.ToString();
      lblNumGoldP4.Text = world.players[3].mGold.ToString();
      lblNumGoldP5.Text = world.players[4].mGold.ToString();
      lblNumGoldP6.Text = world.players[5].mGold.ToString();

      lblturnCardNum1.Text = world.players[0].mTurnCard.turnCardId.ToString();
      lblturnCardNum2.Text = world.players[1].mTurnCard.turnCardId.ToString();
      lblturnCardNum3.Text = world.players[2].mTurnCard.turnCardId.ToString();
      lblturnCardNum4.Text = world.players[3].mTurnCard.turnCardId.ToString();
      lblturnCardNum5.Text = world.players[4].mTurnCard.turnCardId.ToString();
      lblturnCardNum6.Text = world.players[5].mTurnCard.turnCardId.ToString();

      lblP1Hinterlands.Text = world.players[0].Territory.Hinterlands.mSoldiers.ToString();
      lblP2Hinterlands.Text = world.players[1].Territory.Hinterlands.mSoldiers.ToString();
      lblP3Hinterlands.Text = world.players[2].Territory.Hinterlands.mSoldiers.ToString();
      lblP4Hinterlands.Text = world.players[3].Territory.Hinterlands.mSoldiers.ToString();
      lblP5Hinterlands.Text = world.players[4].Territory.Hinterlands.mSoldiers.ToString();
      lblP6Hinterlands.Text = world.players[5].Territory.Hinterlands.mSoldiers.ToString();

    } */

    private void button1_Click_1(object sender, EventArgs e)
    {
      lblPlayer1Name.Text = Player1ChangeNameBox.Text;
    }

    private void Button2_Click(object sender, EventArgs e)
    {
            lblPlayer2Name.Text = Player2ChangeNameBox.Text;
    }

        private void btnChangePlayer1Name_Click(object sender, EventArgs e)
        {
            lblPlayer1Name.Text = Player1ChangeNameBox.Text;
        }

        private void btnChangePlayer3Name_Click(object sender, EventArgs e)
        {
            lblPlayer3Name.Text = Player3ChangeNameBox.Text;
        }

        private void btnChangePlayer5Name_Click(object sender, EventArgs e)
        {
            lblPlayer5Name.Text = Player5ChangeNameBox.Text;
        }

        private void btnChangePlayer4Name_Click(object sender, EventArgs e)
        {
            lblPlayer4Name.Text = Player4ChangeNameBox.Text;
        }

        private void btnChangePlayer6Name_Click(object sender, EventArgs e)
        {
            lblPlayer6Name.Text = Player6ChangeNameBox.Text;
        }

    private void startGameButton_Click(object sender, EventArgs e)
    {

      List<FortuneCard> fortuneCards = assembleFortuneCards();
      List<IntelligenceCard> intelligenceCards = assembleIntelligenceCards();
      List<TurnCard> turnCards = assembleTurnCards();

      World currentWorld = new World((int)numberPlayers.Value, fortuneCards, intelligenceCards, turnCards);
     // InitializeUI(currentWorld);

    }

    private void numberPlayers_ValueChanged(object sender, EventArgs e)
    {

    }
  }
}
