using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Cards.TurnCards
{
  public class TurnCard3 : TurnCard
  {
    //public Int32 turnCardId = 3;

    public TurnCard3()
    {
      turnCardId = 3;
    }

    public override Player AddTurnCardBenifitsToPlayer(Player player)
    {
      player.Territory.Town.mPeasants += 2;

      return player;
    }
  }
}
