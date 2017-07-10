using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class Pillage : FortuneCard
  {
    String cardName = "Pillage";

    public Pillage()
    {

    }

    public override Boolean UseCard()
    {
      return true;
    }
  }
}
