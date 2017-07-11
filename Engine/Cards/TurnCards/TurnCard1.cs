using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Cards.TurnCards
{
  public class TurnCard1 : TurnCard
  {

    public TurnCard1()
    {
      cardName = "Turn Card 1";
      turnCardId = 1;
    }

    public override Player AddTurnCardBenifitsToPlayer(Player player)
    {
      player.Territory.Hinterlands.mSoldiers += 2;

      return player;
    }
  }
}
