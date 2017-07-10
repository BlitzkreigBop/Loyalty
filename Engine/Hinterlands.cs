using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class Hinterlands : Location
  {
    public int mSoldiers;

    public Hinterlands(int soldiers)
    {
      mSoldiers = soldiers;
    }
  }
}
