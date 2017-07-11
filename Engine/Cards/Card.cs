using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  
  public class Card
  {
    public Player mPlayer;
    public String cardName;

    public Card()
    {

    }

    public static Card getCardType(Player player, string str) {
      switch (str)
      {
        case "Weather":
          return new Weather();
        case "SoloWin":
          return new SoloWin();
        case "Famine":
          return new Famine();
        case "Lost Shipment":
          return new LostShipment();
      }
      return new Card();
    }

    public virtual Boolean UseCard()
    {
      
      return true;
    }
  }
}
