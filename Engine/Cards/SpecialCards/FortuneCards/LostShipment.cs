using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class LostShipment : FortuneCard
  {
    String cardName = "Lost Shipment";

    public LostShipment()
    {

    }

    public override Boolean UseCard()
    {
      return true;
    }
  }
}
