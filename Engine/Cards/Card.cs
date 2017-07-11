using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class Card
  {
    public String cardName;

    public Card()
    {

    }

    public virtual Boolean UseCard()
    {
      return true;
    }
  }
}
