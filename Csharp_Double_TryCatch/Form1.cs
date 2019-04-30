using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Double_TryCatch_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 10;
            int z = 100;
            try
            {
                //z = y / x;
                try
                {
                    z = y / x;
                }
                catch (Exception)
                {
                    MessageBox.Show("Inner!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Outer!");
            }
        }
    }
}