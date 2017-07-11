﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Cards.TurnCards
{
  public class TurnCard6 : TurnCard
  {

    public TurnCard6() {
      cardName = "Turn Card 6";
      turnCardId = 6;
    }

    public override Player AddTurnCardBenifitsToPlayer(Player player)
    {
      player.mGold += 2;

      return player;
    }
  }
}
