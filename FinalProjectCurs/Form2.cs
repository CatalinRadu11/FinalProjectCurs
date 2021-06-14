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
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime inTime = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime outTime = Convert.ToDateTime(dateTimePicker2.Text);

            if (outTime >= inTime)
            {
                listBoxTrimiteRezervarea.Items.Add(outTime.Subtract(inTime).Days.ToString()); //= outTime.Subtract(inTime).Days.ToString();
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DateTime inTime = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime outTime = Convert.ToDateTime(dateTimePicker2.Text);

            if (outTime >= inTime)
            {
                listBoxTrimiteRezervarea.Items.Add(outTime.Subtract(inTime).Days.ToString()); //= outTime.Subtract(inTime).Days.ToString();
            }
        }

        private void checkBoxPlataCash_CheckedChanged(object sender, EventArgs e)
        {
            listBoxTrimiteRezervarea.Items.Add("Plata Cash");
        }

        private void checkBoxPlataLivrare_CheckedChanged(object sender, EventArgs e)
        {
            listBoxTrimiteRezervarea.Items.Add("Plata Card");
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

            //Form3.dataGridView1.Rows[Form3.dataGridView1.Rows.Count - 1].Cells[0].Value = textBoxNume.Text;
            //Form3.dataGridView1.Rows[Form3.dataGridView1.Rows.Count-1].Cells[1].Value = textBoxNume.Text;
            //Form3.dataGridView1.Rows[Form3.dataGridView1.Rows.Count - 1].Cells[2].Value = dateTimePicker2.Value;
            //Form3.dataGridView1.Rows[Form3.dataGridView1.Rows.Count - 1].Cells[3].Value = dateTimePicker2.Value;
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
    }
}