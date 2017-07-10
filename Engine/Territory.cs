using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
  public class Territory
  {
    public Hinterlands Hinterlands;
    public Farmlands Farmlands;
    public Fortress Fortress;
    public Town Town;

    public Territory(int peasants, int hSoldiers, int farmSoldiers, int fortSoldiers)
    {
      Town = new Town(peasants);
      Hinterlands = new Hinterlands(hSoldiers);
      Farmlands = new Farmlands(farmSoldiers);
      Fortress = new Fortress(fortSoldiers);
    }


  }
}
