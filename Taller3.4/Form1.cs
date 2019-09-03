using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            double not1, not2, not3, not4, not5, total;
            not1 = double.Parse(txtnot1.Text);
            not2 = double.Parse(txtnot2.Text);
            not3 = double.Parse(txtnot3.Text);
            not4 = double.Parse(txtnot4.Text);
            not5 = double.Parse(txtnot5.Text);
            total = ((not1 + not2 + not3 + not4 + not5) / 5);
            lblprom.Text = total.ToString();
            if (total >= 3.5)
            {

                MessageBox.Show("Has Superado la Materia");  
            }
            else
            {
                MessageBox.Show("No Has Superado la Materia");

            }
        }
    }
}
