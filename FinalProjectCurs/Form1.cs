using System;
using System.Collections;
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
        Car Audi = new Car(CarModel.AudiA3, 2017, 50, "Rosu", "Cutie manuala", FuelType.Benzina);
        Car Volkswagen = new Car(CarModel.VolkswagenTiguan, 2017, 80, "Negru", "Cutie Automata", FuelType.Benzina);
        Car BMW = new Car(CarModel.BMWI8, 2019, 100, "Alb", "Cutie Automata", FuelType.Hybrid);
        Car Hyundai = new Car(CarModel.HyundaiTucson, 2018, 90, "Albastru", "Cutie Manuala", FuelType.Electric);
        Car Lamborghini = new Car(CarModel.LamborghiniAventador, 2020, 200, "Rosu", "Cutie Automata", FuelType.Diesel);
        Car Toyota = new Car(CarModel.ToyotaAuris, 2015, 60, "Alb", "Cutie Automata", FuelType.Hybrid);

        //initializarea formului si adaugarea masinilor (din enum) in combobox
        List<Car> carsList;

        //initializarea formului si adaugarea masinilor (din enum) in combobox
        public Form1()
        {
            InitializeComponent();

            carsList = new List<Car>() { Audi, Volkswagen, BMW, Hyundai, Lamborghini, Toyota };


            for (FuelType ce = FuelType.Benzina; ce <= FuelType.Hybrid; ce++)
            {
                comboBoxFuel.Items.Add(ce.Description());
            }

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
                    labelPrice.Text = Audi.Price.ToString() + "lei";
                    listBox1.Items.Add(CarModel.AudiA3);
                    listBox1.Items.Add(Audi.MakeYear);
                    listBox1.Items.Add(Audi.Colour);
                    listBox1.Items.Add(Audi.Transmission);

                    break;
                case "Volkswagen Tiguan":
                    pictureBox_car.Image = Image.FromFile(dir + "images\\4.png");
                    pictureBox_car1.Image = Image.FromFile(dir + "images\\4.png");
                    pictureBox_car2.Image = Image.FromFile(dir + "images\\44.png");
                    pictureBox_car3.Image = Image.FromFile(dir + "images\\444.png");
                    labelPrice.Text = Volkswagen.Price.ToString() + "lei";
                    listBox1.Items.Add(CarModel.VolkswagenTiguan);
                    listBox1.Items.Add(Volkswagen.MakeYear);
                    listBox1.Items.Add(Volkswagen.Colour);
                    listBox1.Items.Add(Volkswagen.Transmission);
                    break;
                case "BMW I8":
                    pictureBox_car.Image = Image.FromFile(dir + "images\\2.png");
                    pictureBox_car1.Image = Image.FromFile(dir + "images\\2.png");
                    pictureBox_car2.Image = Image.FromFile(dir + "images\\22.png");
                    pictureBox_car3.Image = Image.FromFile(dir + "images\\222.png");
                    labelPrice.Text = BMW.Price.ToString() + "lei";
                    listBox1.Items.Add(CarModel.BMWI8);
                    listBox1.Items.Add(BMW.MakeYear);
                    listBox1.Items.Add(BMW.Transmission);
                    break;
                case "Hyundai Tucson":
                    pictureBox_car.Image = Image.FromFile(dir + "images\\5.png");
                    pictureBox_car1.Image = Image.FromFile(dir + "images\\5.png");
                    pictureBox_car2.Image = Image.FromFile(dir + "images\\55.png");
                    pictureBox_car3.Image = Image.FromFile(dir + "images\\555.png");
                    labelPrice.Text = Hyundai.Price.ToString() + "lei";
                    listBox1.Items.Add(CarModel.HyundaiTucson);
                    listBox1.Items.Add(Hyundai.MakeYear);
                    listBox1.Items.Add(Hyundai.Colour);
                    listBox1.Items.Add(Hyundai.Transmission);
                    break;
                case "Lamborghini Aventador":
                    pictureBox_car.Image = Image.FromFile(dir + "images\\1.png");
                    pictureBox_car1.Image = Image.FromFile(dir + "images\\1.png");
                    pictureBox_car2.Image = Image.FromFile(dir + "images\\11.png");
                    pictureBox_car3.Image = Image.FromFile(dir + "images\\111.png");
                    labelPrice.Text = Lamborghini.Price.ToString() + "lei";
                    listBox1.Items.Add(CarModel.LamborghiniAventador);
                    listBox1.Items.Add(Lamborghini.MakeYear);
                    listBox1.Items.Add(Lamborghini.Colour);
                    listBox1.Items.Add(Lamborghini.Transmission);
                    break;
                case "Toyota Auris":
                    pictureBox_car.Image = Image.FromFile(dir + "images\\7.png");
                    pictureBox_car1.Image = Image.FromFile(dir + "images\\7.png");
                    pictureBox_car2.Image = Image.FromFile(dir + "images\\77.png");
                    pictureBox_car3.Image = Image.FromFile(dir + "images\\777.png");
                    labelPrice.Text = Toyota.Price.ToString() + "lei";
                    listBox1.Items.Add(CarModel.ToyotaAuris);
                    listBox1.Items.Add(Toyota.MakeYear);
                    listBox1.Items.Add(Toyota.Colour);
                    listBox1.Items.Add(Toyota.Transmission);
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

        private void comboBoxFuel_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = comboBoxCar.SelectedIndex;

            if (comboBoxFuel.SelectedItem != null)
            {
                comboBoxCar.Items.Clear();
                String fuelType = comboBoxFuel.SelectedItem.ToString();
                List<Car> filteredList = carsList.Where(c => c.Fuel.ToString() == fuelType).ToList();
                for (int i = 0; i < filteredList.Count; i++)
                {
                    Car car = filteredList.ElementAt(i);
                    comboBoxCar.Items.Add(((CarModel)car.Model).Description());
                }
            }


        }
    }
}

