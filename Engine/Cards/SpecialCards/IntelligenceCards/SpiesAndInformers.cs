using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class SpiesAndInformers : IntelligenceCard
  {
    String cardName = "Spies and Informers";

    public SpiesAndInformers()
    {

    }

    public override Boolean UseCard()
    {
      return true;
    }
  }
}
