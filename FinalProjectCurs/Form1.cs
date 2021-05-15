using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectCurs
{
    public partial class Form1 : Form
    {
        //initializarea formului si adaugarea masinilor (din enum) in combobox
        public Form1()
        {
            InitializeComponent();

            //comboBoxMasina.Text = "---Alegeti o masina---";  // add default value for combobox but is not working right now

            //populate combobox with the items from enum
            comboBoxMasina.DataSource = Enum.GetValues(typeof(CarEnum)); 
        }

        //---------------------------------------------------------------------------------------------------------------------
        //adaugarea imaginilor in picturebox(s) in functie de selectia facuta de utilizator in combobox
        private void comboBoxMasina_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMasina.SelectedItem.ToString())
            {
                case "AudiA3":
                    break;
                case "AudiR8":
                    break;
                case "BMWI8":
                    break;
                case "Ferrari488GTB":
                    break;
                case "LamborghiniAventador":
                    pictureBox_car.Load("pictures\\1.png");
                    pictureBox_car1.Load("pictures\\1.png");
                    pictureBox_car2.Load("pictures\\11.png");
                    pictureBox_car3.Load("pictures\\111.png");
                    break;
                case "RenaulClio":
                    break;
                default:
                    MessageBox.Show("Nu ai ales nicio masina!"); //nu functioneaza inca
                    break;
                }
        }
        private void pictureBox_car1_Click(object sender, EventArgs e)
        {
            pictureBox_car.Image = pictureBox_car1.Image;
        }

        private void pictureBox_car2_Click(object sender, EventArgs e)
        {
            pictureBox_car.Image = pictureBox_car2.Image;
        }

        private void pictureBox_car3_Click(object sender, EventArgs e)
        {
            pictureBox_car.Image = pictureBox_car3.Image;
        }
    }
}
