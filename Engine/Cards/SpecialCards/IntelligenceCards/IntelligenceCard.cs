﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class IntelligenceCard : Card
  {

    public IntelligenceCard()
    {
      cardName = "Intelligence Card";
    }

    public override Boolean UseCard()
    {
      return true;
    }
  }
}
