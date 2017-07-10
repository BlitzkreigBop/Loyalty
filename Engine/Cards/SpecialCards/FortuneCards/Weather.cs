using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class Weather : FortuneCard
  {
    String cardName = "Weather";

    public Weather()
    {

    }

    public override Boolean UseCard()
    {
      return true;
    }
  }
}
