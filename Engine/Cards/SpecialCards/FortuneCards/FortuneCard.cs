﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class FortuneCard : Card
  {
    public FortuneCard()
    {
      cardName = " Fortune Card";
    }
    public override Boolean UseCard()
    {
      return true;
    }
  }
}
