using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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

            //populate combobox with the items from enum

            CarModelEnum myEnum = CarModelEnum.AudiA3;
            string myDesc = myEnum.Description();

            for (CarModelEnum ce = CarModelEnum.AudiA3; ce <= CarModelEnum.RenaultClio; ce++)
            {
                comboBoxCar.Items.Add(ce.Description());
            }
            //comboBoxCar.DataSource = Enum.GetValues(typeof(CarEnum)); - populate combobox straight from Enum
        }

        //---------------------------------------------------------------------------------------------------------------------
        //adaugarea imaginilor in picturebox(s) in functie de selectia facuta de utilizator in combobox
        private void comboBoxCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(Application.ExecutablePath).Replace(@"bin\Debug\net5.0-windows", string.Empty);

            switch (comboBoxCar.SelectedItem.ToString())
            {
                case "Audi A3":
                    pictureBox_car.Image = Image.FromFile(dir + "images\\3.png");
                    pictureBox_car1.Image = Image.FromFile(dir + "images\\3.png");
                    pictureBox_car2.Image = Image.FromFile(dir + "images\\33.png");
                    pictureBox_car3.Image = Image.FromFile(dir + "images\\333.png");
                    break;
                case "Volkswagen Tiguan":
                    pictureBox_car.Image = Image.FromFile(dir + "images\\4.png");
                    pictureBox_car1.Image = Image.FromFile(dir + "images\\4.png");
                    pictureBox_car2.Image = Image.FromFile(dir + "images\\44.png");
                    pictureBox_car3.Image = Image.FromFile(dir + "images\\444.jpg");
                    break;
                case "BMW I8":
                    pictureBox_car.Image = Image.FromFile(dir + "images\\2.png");
                    pictureBox_car1.Image = Image.FromFile(dir + "images\\2.png");
                    pictureBox_car2.Image = Image.FromFile(dir + "images\\22.jpg");
                    pictureBox_car3.Image = Image.FromFile(dir + "images\\222.png");
                    break;
                case "Hyundai Tucson":
                    pictureBox_car.Image = Image.FromFile(dir + "images\\5.png");
                    pictureBox_car1.Image = Image.FromFile(dir + "images\\5.png");
                    pictureBox_car2.Image = Image.FromFile(dir + "images\\55.png");
                    pictureBox_car3.Image = Image.FromFile(dir + "images\\555.jpg");
                    break;
                case "Lamborghini Aventador":
                    pictureBox_car.Image = Image.FromFile(dir + "images\\1.png");
                    pictureBox_car1.Image = Image.FromFile(dir + "images\\1.png");
                    pictureBox_car2.Image = Image.FromFile(dir + "images\\11.png");
                    pictureBox_car3.Image = Image.FromFile(dir + "images\\111.png");
                    break;
                case "Renault Clio":
                    pictureBox_car.Image = Image.FromFile(dir + "images\\7.jpg");
                    pictureBox_car1.Image = Image.FromFile(dir + "images\\7.jpg");
                    pictureBox_car2.Image = Image.FromFile(dir + "images\\77.png");
                    pictureBox_car3.Image = Image.FromFile(dir + "images\\777.jpg");
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

        private void buttonRezervaAcum_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2 = new Form2(); //this is the change, code for redirect  
            f2.ShowDialog();
        }
    }
}
