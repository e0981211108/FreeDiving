using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class myclass : UserControl
    {
        public myclass()
        {
            InitializeComponent();

        }



        private void myclass_Load(object sender, EventArgs e)
        {

        }

        private void btnhealthy_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.taiwan-dive.com/_files/ugd/22a53b_f4c22ac2b903454285314bb545b8e432.pdf",
                UseShellExecute = true
            });
        }

        public void btnclass_Click(object sender, EventArgs e)
        {

        }
    }


}

