using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectCurs
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime inTime = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime outTime = Convert.ToDateTime(dateTimePicker2.Text);

            if (outTime >=inTime)
            {
                textBoxSumarRezervare.Text = outTime.Subtract(inTime).Days.ToString();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime inTime = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime outTime = Convert.ToDateTime(dateTimePicker2.Text);

            if (outTime >= inTime)
            {
                textBoxSumarRezervare.Text = outTime.Subtract(inTime).Days.ToString();
            }
        }

        private void checkBoxPlataCash_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSumarRezervare.Text = "Plata Cash";
        }

        private void checkBoxPlataLivrare_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSumarRezervare.Text = "Plata Card";
        }
    }
}
