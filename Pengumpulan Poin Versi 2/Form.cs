using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pengumpulan_Poin_Versi_2.Controllers;

namespace Pengumpulan_Poin_Versi_2
{
    public partial class Form 1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeController();
        }

    private void InitializeController()
    {
        Controller1 controller = new Controller1(this);
        controller.Start();
    }

    private void Label1_Click(object sender, EventArgs e)
    {

    }

    private void label6_Click(object;
    }
}
