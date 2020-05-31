using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Loader
{
    public partial class how_to_use : UserControl
    {
        public how_to_use()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.epicgames.com/id/login?redirectUrl=https://www.epicgames.com/id/api/exchange");

        }
    }
}
