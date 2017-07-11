using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class ScorchedEarth : IntelligenceCard
  {

    public ScorchedEarth()
    {
      cardName = "Scorched Earth";
    }

    public override Boolean UseCard()
    {
      return true;
    }
  }
}
