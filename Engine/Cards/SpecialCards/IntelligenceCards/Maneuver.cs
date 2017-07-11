using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class Maneuver : IntelligenceCard
  {

    public Maneuver()
    {
      cardName = "Maneuver";
    }

    public override Boolean UseCard()
    {
      return true;
    }
  }
}
