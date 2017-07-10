using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Cards
{
  class SpecialCard : Card
  {
    public SpecialCard(){
      
    }

    public override Boolean UseCard() {
      return true;
    }
  }
}
