using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Cards.TurnCards
{
  public class TurnCard3 : TurnCard
  {

    public TurnCard3()
    {
      cardName = "Turn Card 3";
      turnCardId = 3;
    }

    public override Player AddTurnCardBenifitsToPlayer(Player player)
    {
      player.Territory.Town.mPeasants += 2;

      return player;
    }
  }
}
