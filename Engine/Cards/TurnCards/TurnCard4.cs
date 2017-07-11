using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Cards.TurnCards
{
  public class TurnCard4 : TurnCard
  {

    public TurnCard4() {
      cardName = "Turn Card 4";
      turnCardId = 4;
    }

    public override Player AddTurnCardBenifitsToPlayer(Player player)
    {
      player.Territory.Town.mPeasants += 2;

      return player;
    }
  }
}
