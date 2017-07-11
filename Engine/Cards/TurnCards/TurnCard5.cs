using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Cards.TurnCards
{
  public class TurnCard5 : TurnCard
  {

    public TurnCard5() {
      cardName = "Turn Card 5";
      turnCardId = 5;
    }

    public override Player AddTurnCardBenifitsToPlayer(Player player)
    {
      player.mGold += 2;

      return player;
    }
  }
}
