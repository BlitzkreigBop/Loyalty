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

    private void startGameButton_Click(object sender, EventArgs e)
    {

      List<FortuneCard> fortuneCards = assembleFortuneCards();
      List<IntelligenceCard> intelligenceCards = assembleIntelligenceCards();
      List<TurnCard> turnCards = assembleTurnCards();

      World currentWorld = new World((int)numberPlayers.Value, fortuneCards, intelligenceCards, turnCards);
    }

    private void numberPlayers_ValueChanged(object sender, EventArgs e)
    {

    }
  }
}
