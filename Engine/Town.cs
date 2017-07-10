using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class Town : Location
  {
    public int mPeasants;

    public Town(int peasants)
    {
      mPeasants = peasants;
    }
  }
}
