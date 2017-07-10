using Engine.Cards.TurnCards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class Player
  {
    public String name = "";
    public Territory Territory;

    public Boolean active = true;

    public PlayerForm playerForm; 

    public int playerId = 0;
    public int mGold = 0;
    
    public List<FortuneCard> mFortuneCards = new List<FortuneCard>();
    public List<IntelligenceCard> mIntelligenceCards = new List<IntelligenceCard>();
    public TurnCard mTurnCard = new TurnCard();

    public Player(World world, int id, int gold, int peasants, FortuneCard fortuneCard, IntelligenceCard intelligenceCard, TurnCard turnCard)
    {
      name = "Hardcoded Name";
      Territory = new Territory(peasants, 5, 5, 5);
      playerId = id;
      mGold = gold;

      mFortuneCards.Add(fortuneCard);
      mIntelligenceCards.Add(intelligenceCard);
      mTurnCard = turnCard;

      playerForm = new PlayerForm(world);

      playerForm.Name = "Player " + id.ToString();
      playerForm.Text = "Player " + id.ToString();
      playerForm.updateUI(this);
    }

    public Boolean ControlsPeasants()
    {
      if (Territory.Town.mPeasants > 0)
        return true;
      return false;
    }

    public Boolean UseCard(Card card)
    {
      return card.UseCard();
    }

    public void updatePlayerUI()
    {
      playerForm.updateUI(this);
    }

    public Boolean RemovePeasants(int numPeasantsRemoved)
    {
      Territory.Town.mPeasants = Territory.Town.mPeasants - numPeasantsRemoved;

      if(!ControlsPeasants())
      {
        return false;
      }

      return true;
    }
  }
}
