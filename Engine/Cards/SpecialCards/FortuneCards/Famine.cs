using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class Famine : FortuneCard
  {
    
    public Famine()
    {
      cardName = "Famine";
    }

    public override Boolean UseCard()
    {
      Console.ReadLine();
      return true;
    }
  }
}
