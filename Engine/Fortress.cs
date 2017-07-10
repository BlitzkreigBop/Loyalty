using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class Fortress : Location
  {
    public int mSoldiers;

    public Fortress(int soldiers)
    {
      mSoldiers = soldiers;
    }
  }
}
