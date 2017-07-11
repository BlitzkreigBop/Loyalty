using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Cards.TurnCards
{
  public class TurnCard2 : TurnCard
  {

    public TurnCard2() {
      cardName = "Turn Card 2";
      turnCardId = 2;
    }

    public override Player AddTurnCardBenifitsToPlayer(Player player)
    {
      player.Territory.Hinterlands.mSoldiers += 2;

      return player;
    }
  }
}
