using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class SecretAlliance : IntelligenceCard
  {
    String cardName = "Secret Alliance";

    public SecretAlliance()
    {

    }

    public override Boolean UseCard()
    {
      return true;
    }
  }
}
