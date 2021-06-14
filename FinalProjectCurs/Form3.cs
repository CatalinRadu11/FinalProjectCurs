using System;
using System.Collections.Generic;
using System.ComponentModel;
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

using System.IO;

namespace FinalProjectCurs
{
    public partial class Form3 : Form
    {
        Client newClient;

        List<Client> IstoriClient = new List<Client>();
        public Form3()
        {
            InitializeComponent();
            try
            {
                IstoriClient = citireIstoricClient();
            }
            catch (FileNotFoundException e)
            {
                System.Windows.Forms.MessageBox.Show("No client history");
            }

            for (int i = 0; i < IstoriClient.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = IstoriClient[i].Nume;
                row.Cells[1].Value = IstoriClient[i].Model.Model.Description();
                row.Cells[2].Value = IstoriClient[i].DataInceput;
                row.Cells[3].Value = IstoriClient[i].DataFinal;
                dataGridView1.Rows.Add(row);
            }

        }

        public Form3(Client c)
        {
            InitializeComponent();
            try
            {
                IstoriClient = citireIstoricClient();
            }
            catch (FileNotFoundException e)
            {
                System.Windows.Forms.MessageBox.Show("No client history");
            }


            newClient = c;
            IstoriClient.Add(newClient);

            for (int i = 0; i < IstoriClient.Count; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = IstoriClient[i].Nume;
                row.Cells[1].Value = IstoriClient[i].Model.Model.Description();
                row.Cells[2].Value = IstoriClient[i].DataInceput;
                row.Cells[3].Value = IstoriClient[i].DataFinal;
                dataGridView1.Rows.Add(row);

            }
            scriereIstoricClient(IstoriClient);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelCustomerHistory_Click(object sender, EventArgs e)
        {

        }

        private List<Client> citireIstoricClient()
        {
            List<Client> ret = new List<Client>();
            string serializationFile = "client.bin";
            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                ret = (List<Client>)bformatter.Deserialize(stream);
            }
            return ret;
        }

        private void scriereIstoricClient(List<Client> IstoriClient)
        {
            string serializationFile = "client.bin";
            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, IstoriClient);
            }

        }
    }
}
