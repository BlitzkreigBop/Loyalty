﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class Pillage : FortuneCard
  {

    public Pillage()
    {
      cardName = "Pillage";
    }

    public override Boolean UseCard()
    {
      return true;
    }
  }
}
