using Engine.Cards.TurnCards;
using Engine.Turn;
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
    public Boolean currentTurn = false;

    public World playerWorld;

    public PlayerForm playerForm;

    public Engine.Turn.Turn playersTurn;

    public int playerId = 0;
    public int mGold = 0;
    public int mProposingPlayerId = 0;
    public int loyalToPlayerId = 0;
    
    public List<FortuneCard> mFortuneCards = new List<FortuneCard>();
    public List<IntelligenceCard> mIntelligenceCards = new List<IntelligenceCard>();
    public TurnCard mTurnCard = new TurnCard();

    public Player(World world, int id, int gold, int peasants, FortuneCard fortuneCard, IntelligenceCard intelligenceCard, TurnCard turnCard)
    {
      playerWorld = world;

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

    public Boolean UseCard(String cardName)
    {
      Card card = Card.getCardType(this, cardName);
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

    internal void decideIfLoyal(int proposingPlayerId)
    {
      mProposingPlayerId = proposingPlayerId;
      playerForm.acceptDenyUI();
    }

    internal void acceptLoyalty()
    {
      loyalToPlayerId = mProposingPlayerId;
      foreach (Player player in playerWorld.players.Where(n => n.playerId == mProposingPlayerId))
      {
        player.playerForm.loyalToUI(mProposingPlayerId);
      }
      playerForm.loyalToUI(mProposingPlayerId);
    }

    internal void loyaltyAccepted()
    {
      int newLoyalty = 0;
      foreach (Player player in playerWorld.players)
      {
        if (player.currentTurn)
        {
          loyalToPlayerId = player.playerId;
          playerForm.loyalToUI(loyalToPlayerId);
          player.playerForm.loyalToUI(playerId);
          newLoyalty = player.playerId;
        }
      }

      foreach (Player player in playerWorld.players.Where(n => n.loyalToPlayerId == newLoyalty))
      {
        if (loyalToPlayerId != player.playerId)
        {
          player.loyalToPlayerId = 0;
        }
      }
    }
  }
}
