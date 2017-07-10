using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class Farmlands : Location
  {
    public int mSoldiers;

    public Farmlands(int soldiers)
    {
      mSoldiers = soldiers;
    }
  }
}
