using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class SoloWin : FortuneCard
  {
    String cardName = "Solo Win";

    public SoloWin()
    {

    }

    public override Boolean UseCard()
    {
      return true;
    }
  }
}
