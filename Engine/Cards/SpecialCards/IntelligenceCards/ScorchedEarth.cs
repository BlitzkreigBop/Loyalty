using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class ScorchedEarth : IntelligenceCard
  {
    String cardName = "Scorched Earth";

    public ScorchedEarth()
    {

    }

    public override Boolean UseCard()
    {
      return true;
    }
  }
}
