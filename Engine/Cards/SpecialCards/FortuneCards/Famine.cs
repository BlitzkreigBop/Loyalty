using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class Famine : FortuneCard
  {
    String cardName = "Famine";
    public Famine()
    {
      
    }

    public override Boolean UseCard()
    {
      return true;
    }
  }
}
