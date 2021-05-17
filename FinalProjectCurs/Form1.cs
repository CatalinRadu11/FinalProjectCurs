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
                    pictureBox_car.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\3.png");
                    pictureBox_car1.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\3.png");
                    pictureBox_car2.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\33.png");
                    pictureBox_car3.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\333.png");
                    break;
                case "VolkswagenTiguan":
                    pictureBox_car.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\4.png");
                    pictureBox_car1.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\4.png");
                    pictureBox_car2.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\44.png");
                    pictureBox_car3.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\444.jpg");
                    break;
                case "BMWI8":
                    pictureBox_car.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\2.png");
                    pictureBox_car1.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\2.png");
                    pictureBox_car2.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\22.jpg");
                    pictureBox_car3.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\222.png");
                    break;
                case "HyundaiTucson":
                    pictureBox_car.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\5.png");
                    pictureBox_car1.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\5.png");
                    pictureBox_car2.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\55.png");
                    pictureBox_car3.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\555.jpg");
                    break;
                case "LamborghiniAventador":
                    pictureBox_car.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\1.png");
                    pictureBox_car1.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\1.png");
                    pictureBox_car2.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\11.png");
                    pictureBox_car3.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\111.png");
                    break;
                case "RenaulClio":
                    pictureBox_car.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\6.jpg");
                    pictureBox_car1.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\6.jpg");
                    pictureBox_car2.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\66.png");
                    pictureBox_car3.Image = Image.FromFile("C:\\Users\\AE\\Desktop\\CatalinRadu11\\FinalProjectCurs\\FinalProjectCurs\\images\\666.jpg");
                    break;
                default:
                    MessageBox.Show("Nu ai ales nicio masina!"); //nu functioneaza inca
                    break;
            }
        }
        private void pictureBox_car1_Click(object sender, EventArgs e)
        {
            pictureBox_car.Image = Image.FromFile(@"C:\Users\AE\Desktop\CatalinRadu11\FinalProjectCurs\FinalProjectCurs\images");
        }

        private void pictureBox_car2_Click(object sender, EventArgs e)
        {
            pictureBox_car.Image = Image.FromFile(@"C:\Users\AE\Desktop\CatalinRadu11\FinalProjectCurs\FinalProjectCurs\images");
        }

        private void pictureBox_car3_Click(object sender, EventArgs e)
        {
            pictureBox_car.Image = Image.FromFile(@"C:\Users\AE\Desktop\CatalinRadu11\FinalProjectCurs\FinalProjectCurs\images");
        }
        private void buttonRezervaAcum_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2 = new Form2(); //this is the change, code for redirect  
            f2.ShowDialog();
        }
    }
}
