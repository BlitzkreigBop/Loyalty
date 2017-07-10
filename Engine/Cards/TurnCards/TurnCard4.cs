using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Cards.TurnCards
{
  public class TurnCard4 : TurnCard
  {
    //Int32 turnCardId = 4;

    public TurnCard4() {
      turnCardId = 4;
    }

    public override Player AddTurnCardBenifitsToPlayer(Player player)
    {
      player.Territory.Town.mPeasants += 2;

      return player;
    }
  }
}
