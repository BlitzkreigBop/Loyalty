﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class PlentifulHarvest : FortuneCard
  {

    public PlentifulHarvest()
    {
      cardName = "Plentiful Harvest";
    }

    public override Boolean UseCard()
    {
      return true;
    }
  }
}
