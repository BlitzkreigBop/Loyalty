using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class Maneuver : IntelligenceCard
  {
    String cardName = "Maneuver";

    public Maneuver()
    {

    }

    public override Boolean UseCard()
    {
      return true;
    }
  }
}
