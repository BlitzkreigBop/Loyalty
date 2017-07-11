using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class LostShipment : FortuneCard
  {
    
    public LostShipment()
    {
      cardName = "Lost Shipment";
    }

    public override Boolean UseCard()
    {
      return true;
    }
  }
}
