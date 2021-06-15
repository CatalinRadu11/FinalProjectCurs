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
        public Car SelectedCar;

        public Form2()
        {
            InitializeComponent();
            pictureBoxCarForm2.Image = Form1.carBoxImg;
        }

        public Form2(Car c)
        {
            this.SelectedCar = c;
            InitializeComponent();
            pictureBoxCarForm2.Image = Form1.carBoxImg;
            labelPretMasina.Text = c.Price.ToString();
            labelTotal.Text = labelPretMasina.Text;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime inTime = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime outTime = Convert.ToDateTime(dateTimePicker2.Text);

            if (outTime >= inTime)
            {
                labelZileInchiriere.Text = outTime.Subtract(inTime).Days.ToString();
                var a = Convert.ToInt32(labelZileInchiriere.Text);
                var b = Convert.ToInt32(labelPretMasina.Text);
                labelTotal.Text = (a * b).ToString();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime inTime = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime outTime = Convert.ToDateTime(dateTimePicker2.Text);

            if (outTime >= inTime)
            {
                labelZileInchiriere.Text = outTime.Subtract(inTime).Days.ToString();
                var a = Convert.ToInt32(labelZileInchiriere.Text);
                var b = Convert.ToInt32(labelPretMasina.Text);
                labelTotal.Text = (a * b).ToString();
            }
        }
        private void buttonTrimiteRezervarea_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Client c = new Client();
            c.Nume = textBoxNume.Text;
            c.DataInceput = dateTimePicker1.Value;
            c.DataFinal = dateTimePicker2.Value;
            c.Model = SelectedCar;
            Form3 f3 = new Form3(c); //this is the change, code for redirect

            MessageBox.Show("Comanda dumneavoastra a fost preluata!");
            f3.ShowDialog();
        }

        public static void openit(string x)
        {
            System.Diagnostics.Process.Start("cmd", "/C start" + " " + x);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                openit("http://rentacar-termenisiconditii.simplesite.com/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var x = Convert.ToInt32(labelTotal.Text);

            if (checkBox1.Checked)
            {
                labelTotal.Text = (x + 250).ToString();
                labelGarantie.Text = "0";
            }
            else
            {
                labelTotal.Text = (x - 250).ToString();
                labelGarantie.Text = "1000";
            }
        }
    }
}