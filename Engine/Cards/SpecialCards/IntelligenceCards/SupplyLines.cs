using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class SupplyLines : IntelligenceCard
  {

    public SupplyLines()
    {
      cardName = "Supply Lines";
    }

    public override Boolean UseCard()
    {
      return true;
    }
  }
}
