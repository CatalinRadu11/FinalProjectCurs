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
        Car Audi = new Car(CarModel.AudiA3, 2017, 60);
        Car BMW = new Car(CarModel.BMWI8, 2015, 90);

        //initializarea formului si adaugarea masinilor (din enum) in combobox
        public Form1()
        {
            InitializeComponent();

            //populate combobox with the items from enum

            CarModel myEnum = CarModel.AudiA3;
            string myDesc = myEnum.Description();

            for (CarModel ce = CarModel.AudiA3; ce <= CarModel.ToyotaAuris; ce++)
            {
                comboBoxCar.Items.Add(ce.Description());
            }

            comboBoxFuel.DataSource = Enum.GetValues(typeof(FuelType)); //populate fuel combobox straight from Enum
        }

        public static Image carImage;

        public static Image carBoxImg
        {
            get { return carImage; }
            set { carImage = value; }
        }


        //---------------------------------------------------------------------------------------------------------------------
        //adaugarea imaginilor in picturebox(s) in functie de selectia facuta de utilizator in combobox
        private void comboBoxCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dir = Path.GetDirectoryName(Application.ExecutablePath).Replace(@"bin\Debug\net5.0-windows", string.Empty);

            listBox1.Items.Clear();

            switch (comboBoxCar.SelectedItem.ToString())
            {
                case "Audi A3":
                    pictureBox_car.Image = Image.FromFile(dir + "images\\3.png");
                    pictureBox_car1.Image = Image.FromFile(dir + "images\\3.png");
                    pictureBox_car2.Image = Image.FromFile(dir + "images\\33.png");
                    pictureBox_car3.Image = Image.FromFile(dir + "images\\333.png");
                    labelPrice.Text = Audi.Price.ToString();
                    listBox1.Items.Add(CarModel.AudiA3);
                    listBox1.Items.Add(Audi.MakeYear);
                    break;
                case "Volkswagen Tiguan":
                    pictureBox_car.Image = Image.FromFile(dir + "images\\4.png");
                    pictureBox_car1.Image = Image.FromFile(dir + "images\\4.png");
                    pictureBox_car2.Image = Image.FromFile(dir + "images\\44.png");
                    pictureBox_car3.Image = Image.FromFile(dir + "images\\444.png");
                    break;
                case "BMW I8":
                    pictureBox_car.Image = Image.FromFile(dir + "images\\2.png");
                    pictureBox_car1.Image = Image.FromFile(dir + "images\\2.png");
                    pictureBox_car2.Image = Image.FromFile(dir + "images\\22.png");
                    pictureBox_car3.Image = Image.FromFile(dir + "images\\222.png");
                    labelPrice.Text = BMW.Price.ToString();
                    listBox1.Items.Add(CarModel.BMWI8);
                    listBox1.Items.Add(BMW.MakeYear);
                    break;
                case "Hyundai Tucson":
                    pictureBox_car.Image = Image.FromFile(dir + "images\\5.png");
                    pictureBox_car1.Image = Image.FromFile(dir + "images\\5.png");
                    pictureBox_car2.Image = Image.FromFile(dir + "images\\55.png");
                    pictureBox_car3.Image = Image.FromFile(dir + "images\\555.png");
                    break;
                case "Lamborghini Aventador":
                    pictureBox_car.Image = Image.FromFile(dir + "images\\1.png");
                    pictureBox_car1.Image = Image.FromFile(dir + "images\\1.png");
                    pictureBox_car2.Image = Image.FromFile(dir + "images\\11.png");
                    pictureBox_car3.Image = Image.FromFile(dir + "images\\111.png");
                    break;
                case "Toyota Auris":
                    pictureBox_car.Image = Image.FromFile(dir + "images\\7.png");
                    pictureBox_car1.Image = Image.FromFile(dir + "images\\7.png");
                    pictureBox_car2.Image = Image.FromFile(dir + "images\\77.png");
                    pictureBox_car3.Image = Image.FromFile(dir + "images\\777.png");
                    break;
                default:
                    MessageBox.Show("Nu ai ales nicio masina!"); //functioneaza
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
            carBoxImg = pictureBox_car1.Image;
            //this.Hide();
            Form2 f2 = new Form2(); //this is the change, code for redirect 
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}

