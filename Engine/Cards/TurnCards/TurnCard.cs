using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Cards.TurnCards
{
  public class TurnCard : Card
  {
    public Int32 turnCardId = 0;

    public TurnCard()
    {
    }

    public override Boolean UseCard()
    {
      return true;
    }

    public virtual Player AddTurnCardBenifitsToPlayer(Player player)
    {
      
      return player;
    }
  }
}
