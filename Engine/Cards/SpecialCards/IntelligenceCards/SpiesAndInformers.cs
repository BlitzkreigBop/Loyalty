using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class SpiesAndInformers : IntelligenceCard
  {

    public SpiesAndInformers()
    {
      cardName = "Spies and Informers";
    }

    public override Boolean UseCard()
    {
      return true;
    }
  }
}
