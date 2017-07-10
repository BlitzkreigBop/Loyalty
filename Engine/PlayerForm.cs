using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine
{
  public partial class PlayerForm : Form
  {
    World mWorld; 

    public PlayerForm(World world)
    {
      mWorld = world;
      InitializeComponent();
    }

    public void updateUI(Player player){
      lblPeasantsNum.Text = player.Territory.Town.mPeasants.ToString();
    }

    private void btnRemovePlayersPeasant_Click(object sender, EventArgs e)
    {
      mWorld.RemovePlayersPeasant((int)numRmvPeasant.Value);
    }
  }
}
