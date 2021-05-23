
namespace FinalProjectCurs
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pictureBoxCarForm2 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.labelDataPreluarii = new System.Windows.Forms.Label();
            this.labelDataPredarii = new System.Windows.Forms.Label();
            this.labelAlegeDatele = new System.Windows.Forms.Label();
            this.labelDatePersonale = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.labelInfoTelefon = new System.Windows.Forms.Label();
            this.textBoxMesaj = new System.Windows.Forms.TextBox();
            this.labelMesaj = new System.Windows.Forms.Label();
            this.textBoxSumarRezervare = new System.Windows.Forms.TextBox();
            this.labelSumarRezervare = new System.Windows.Forms.Label();
            this.buttonTrimiteRezervarea = new System.Windows.Forms.Button();
            this.comboBoxPreluare = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutePreluare = new System.Windows.Forms.ComboBox();
            this.labelOraPreluare = new System.Windows.Forms.Label();
            this.labelMinutePreluare = new System.Windows.Forms.Label();
            this.labelOraPredare = new System.Windows.Forms.Label();
            this.labelMinutePredare = new System.Windows.Forms.Label();
            this.comboBoxOraPredare = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutePredare = new System.Windows.Forms.ComboBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.labelPlata = new System.Windows.Forms.Label();
            this.labelPlataCash = new System.Windows.Forms.Label();
            this.checkBoxPlataCash = new System.Windows.Forms.CheckBox();
            this.labelPlataLivrare = new System.Windows.Forms.Label();
            this.checkBoxPlataLivrare = new System.Windows.Forms.CheckBox();
            this.checkBoxTermeniCond = new System.Windows.Forms.CheckBox();
            this.labelTermeniCond = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarForm2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(813, 905);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.White;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(813, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(604, 363);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // pictureBoxCarForm2
            // 
            this.pictureBoxCarForm2.Location = new System.Drawing.Point(77, 60);
            this.pictureBoxCarForm2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxCarForm2.Name = "pictureBoxCarForm2";
            this.pictureBoxCarForm2.Size = new System.Drawing.Size(681, 368);
            this.pictureBoxCarForm2.TabIndex = 2;
            this.pictureBoxCarForm2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(822, 141);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(225, 27);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(822, 268);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(225, 27);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // labelDataPreluarii
            // 
            this.labelDataPreluarii.AutoSize = true;
            this.labelDataPreluarii.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataPreluarii.ForeColor = System.Drawing.Color.Black;
            this.labelDataPreluarii.Location = new System.Drawing.Point(822, 109);
            this.labelDataPreluarii.Name = "labelDataPreluarii";
            this.labelDataPreluarii.Size = new System.Drawing.Size(134, 28);
            this.labelDataPreluarii.TabIndex = 14;
            this.labelDataPreluarii.Text = "Data preluarii:";
            // 
            // labelDataPredarii
            // 
            this.labelDataPredarii.AutoSize = true;
            this.labelDataPredarii.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataPredarii.ForeColor = System.Drawing.Color.Black;
            this.labelDataPredarii.Location = new System.Drawing.Point(822, 236);
            this.labelDataPredarii.Name = "labelDataPredarii";
            this.labelDataPredarii.Size = new System.Drawing.Size(130, 28);
            this.labelDataPredarii.TabIndex = 15;
            this.labelDataPredarii.Text = "Data predarii:";
            // 
            // labelAlegeDatele
            // 
            this.labelAlegeDatele.AutoSize = true;
            this.labelAlegeDatele.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAlegeDatele.ForeColor = System.Drawing.Color.Black;
            this.labelAlegeDatele.Location = new System.Drawing.Point(822, 12);
            this.labelAlegeDatele.Name = "labelAlegeDatele";
            this.labelAlegeDatele.Size = new System.Drawing.Size(185, 32);
            this.labelAlegeDatele.TabIndex = 16;
            this.labelAlegeDatele.Text = "ALEGE DATELE:";
            // 
            // labelDatePersonale
            // 
            this.labelDatePersonale.AutoSize = true;
            this.labelDatePersonale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDatePersonale.ForeColor = System.Drawing.Color.Black;
            this.labelDatePersonale.Location = new System.Drawing.Point(822, 372);
            this.labelDatePersonale.Name = "labelDatePersonale";
            this.labelDatePersonale.Size = new System.Drawing.Size(224, 32);
            this.labelDatePersonale.TabIndex = 17;
            this.labelDatePersonale.Text = "DATE PERSONALE:";
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNume.ForeColor = System.Drawing.Color.Black;
            this.labelNume.Location = new System.Drawing.Point(822, 445);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(69, 28);
            this.labelNume.TabIndex = 18;
            this.labelNume.Text = "Nume:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.ForeColor = System.Drawing.Color.Black;
            this.labelEmail.Location = new System.Drawing.Point(822, 535);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(63, 28);
            this.labelEmail.TabIndex = 19;
            this.labelEmail.Text = "Email:";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTelefon.ForeColor = System.Drawing.Color.Black;
            this.labelTelefon.Location = new System.Drawing.Point(822, 632);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(78, 28);
            this.labelTelefon.TabIndex = 20;
            this.labelTelefon.Text = "Telefon:";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(822, 477);
            this.textBoxNume.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(275, 27);
            this.textBoxNume.TabIndex = 21;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(822, 567);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(275, 27);
            this.textBoxEmail.TabIndex = 22;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(822, 664);
            this.textBoxTelefon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(275, 27);
            this.textBoxTelefon.TabIndex = 23;
            // 
            // labelInfoTelefon
            // 
            this.labelInfoTelefon.AutoSize = true;
            this.labelInfoTelefon.Location = new System.Drawing.Point(822, 704);
            this.labelInfoTelefon.Name = "labelInfoTelefon";
            this.labelInfoTelefon.Size = new System.Drawing.Size(308, 20);
            this.labelInfoTelefon.TabIndex = 24;
            this.labelInfoTelefon.Text = " Introduceti prefixul tarii. Ex: +40 750 000 000";
            // 
            // textBoxMesaj
            // 
            this.textBoxMesaj.Location = new System.Drawing.Point(1134, 477);
            this.textBoxMesaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMesaj.Multiline = true;
            this.textBoxMesaj.Name = "textBoxMesaj";
            this.textBoxMesaj.Size = new System.Drawing.Size(270, 216);
            this.textBoxMesaj.TabIndex = 25;
            // 
            // labelMesaj
            // 
            this.labelMesaj.AutoSize = true;
            this.labelMesaj.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMesaj.ForeColor = System.Drawing.Color.Black;
            this.labelMesaj.Location = new System.Drawing.Point(1134, 445);
            this.labelMesaj.Name = "labelMesaj";
            this.labelMesaj.Size = new System.Drawing.Size(67, 28);
            this.labelMesaj.TabIndex = 26;
            this.labelMesaj.Text = "Mesaj:";
            // 
            // textBoxSumarRezervare
            // 
            this.textBoxSumarRezervare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSumarRezervare.Location = new System.Drawing.Point(138, 691);
            this.textBoxSumarRezervare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSumarRezervare.Multiline = true;
            this.textBoxSumarRezervare.Name = "textBoxSumarRezervare";
            this.textBoxSumarRezervare.Size = new System.Drawing.Size(529, 144);
            this.textBoxSumarRezervare.TabIndex = 27;
            this.textBoxSumarRezervare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSumarRezervare
            // 
            this.labelSumarRezervare.AutoSize = true;
            this.labelSumarRezervare.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSumarRezervare.ForeColor = System.Drawing.Color.Black;
            this.labelSumarRezervare.Location = new System.Drawing.Point(286, 653);
            this.labelSumarRezervare.Name = "labelSumarRezervare";
            this.labelSumarRezervare.Size = new System.Drawing.Size(214, 32);
            this.labelSumarRezervare.TabIndex = 29;
            this.labelSumarRezervare.Text = "Sumar Rezervare:";
            // 
            // buttonTrimiteRezervarea
            // 
            this.buttonTrimiteRezervarea.Location = new System.Drawing.Point(286, 844);
            this.buttonTrimiteRezervarea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTrimiteRezervarea.Name = "buttonTrimiteRezervarea";
            this.buttonTrimiteRezervarea.Size = new System.Drawing.Size(179, 45);
            this.buttonTrimiteRezervarea.TabIndex = 30;
            this.buttonTrimiteRezervarea.Text = "Trimite Rezervarea";
            this.buttonTrimiteRezervarea.UseVisualStyleBackColor = true;
            // 
            // comboBoxPreluare
            // 
            this.comboBoxPreluare.FormattingEnabled = true;
            this.comboBoxPreluare.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBoxPreluare.Location = new System.Drawing.Point(1166, 141);
            this.comboBoxPreluare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxPreluare.Name = "comboBoxPreluare";
            this.comboBoxPreluare.Size = new System.Drawing.Size(62, 28);
            this.comboBoxPreluare.TabIndex = 32;
            // 
            // comboBoxMinutePreluare
            // 
            this.comboBoxMinutePreluare.FormattingEnabled = true;
            this.comboBoxMinutePreluare.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBoxMinutePreluare.Location = new System.Drawing.Point(1318, 141);
            this.comboBoxMinutePreluare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMinutePreluare.Name = "comboBoxMinutePreluare";
            this.comboBoxMinutePreluare.Size = new System.Drawing.Size(62, 28);
            this.comboBoxMinutePreluare.TabIndex = 35;
            // 
            // labelOraPreluare
            // 
            this.labelOraPreluare.AutoSize = true;
            this.labelOraPreluare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOraPreluare.ForeColor = System.Drawing.Color.Black;
            this.labelOraPreluare.Location = new System.Drawing.Point(1165, 109);
            this.labelOraPreluare.Name = "labelOraPreluare";
            this.labelOraPreluare.Size = new System.Drawing.Size(48, 28);
            this.labelOraPreluare.TabIndex = 37;
            this.labelOraPreluare.Text = "Ora:";
            // 
            // labelMinutePreluare
            // 
            this.labelMinutePreluare.AutoSize = true;
            this.labelMinutePreluare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMinutePreluare.ForeColor = System.Drawing.Color.Black;
            this.labelMinutePreluare.Location = new System.Drawing.Point(1317, 109);
            this.labelMinutePreluare.Name = "labelMinutePreluare";
            this.labelMinutePreluare.Size = new System.Drawing.Size(78, 28);
            this.labelMinutePreluare.TabIndex = 38;
            this.labelMinutePreluare.Text = "Minute:";
            // 
            // labelOraPredare
            // 
            this.labelOraPredare.AutoSize = true;
            this.labelOraPredare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelOraPredare.ForeColor = System.Drawing.Color.Black;
            this.labelOraPredare.Location = new System.Drawing.Point(1165, 240);
            this.labelOraPredare.Name = "labelOraPredare";
            this.labelOraPredare.Size = new System.Drawing.Size(48, 28);
            this.labelOraPredare.TabIndex = 39;
            this.labelOraPredare.Text = "Ora:";
            // 
            // labelMinutePredare
            // 
            this.labelMinutePredare.AutoSize = true;
            this.labelMinutePredare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMinutePredare.ForeColor = System.Drawing.Color.Black;
            this.labelMinutePredare.Location = new System.Drawing.Point(1318, 240);
            this.labelMinutePredare.Name = "labelMinutePredare";
            this.labelMinutePredare.Size = new System.Drawing.Size(78, 28);
            this.labelMinutePredare.TabIndex = 40;
            this.labelMinutePredare.Text = "Minute:";
            // 
            // comboBoxOraPredare
            // 
            this.comboBoxOraPredare.FormattingEnabled = true;
            this.comboBoxOraPredare.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBoxOraPredare.Location = new System.Drawing.Point(1166, 268);
            this.comboBoxOraPredare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxOraPredare.Name = "comboBoxOraPredare";
            this.comboBoxOraPredare.Size = new System.Drawing.Size(62, 28);
            this.comboBoxOraPredare.TabIndex = 41;
            // 
            // comboBoxMinutePredare
            // 
            this.comboBoxMinutePredare.FormattingEnabled = true;
            this.comboBoxMinutePredare.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBoxMinutePredare.Location = new System.Drawing.Point(1317, 268);
            this.comboBoxMinutePredare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMinutePredare.Name = "comboBoxMinutePredare";
            this.comboBoxMinutePredare.Size = new System.Drawing.Size(62, 28);
            this.comboBoxMinutePredare.TabIndex = 42;
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Location = new System.Drawing.Point(813, 728);
            this.splitter3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(604, 177);
            this.splitter3.TabIndex = 43;
            this.splitter3.TabStop = false;
            // 
            // labelPlata
            // 
            this.labelPlata.AutoSize = true;
            this.labelPlata.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlata.ForeColor = System.Drawing.Color.Black;
            this.labelPlata.Location = new System.Drawing.Point(833, 744);
            this.labelPlata.Name = "labelPlata";
            this.labelPlata.Size = new System.Drawing.Size(86, 32);
            this.labelPlata.TabIndex = 44;
            this.labelPlata.Text = "PLATA";
            // 
            // labelPlataCash
            // 
            this.labelPlataCash.AutoSize = true;
            this.labelPlataCash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlataCash.ForeColor = System.Drawing.Color.Black;
            this.labelPlataCash.Location = new System.Drawing.Point(862, 775);
            this.labelPlataCash.Name = "labelPlataCash";
            this.labelPlataCash.Size = new System.Drawing.Size(266, 28);
            this.labelPlataCash.TabIndex = 45;
            this.labelPlataCash.Text = "Plata cash la primirea masinii:";
            // 
            // checkBoxPlataCash
            // 
            this.checkBoxPlataCash.AutoSize = true;
            this.checkBoxPlataCash.Location = new System.Drawing.Point(843, 784);
            this.checkBoxPlataCash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxPlataCash.Name = "checkBoxPlataCash";
            this.checkBoxPlataCash.Size = new System.Drawing.Size(18, 17);
            this.checkBoxPlataCash.TabIndex = 49;
            this.checkBoxPlataCash.UseVisualStyleBackColor = true;
            this.checkBoxPlataCash.CheckedChanged += new System.EventHandler(this.checkBoxPlataCash_CheckedChanged);
            // 
            // labelPlataLivrare
            // 
            this.labelPlataLivrare.AutoSize = true;
            this.labelPlataLivrare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlataLivrare.ForeColor = System.Drawing.Color.Black;
            this.labelPlataLivrare.Location = new System.Drawing.Point(862, 808);
            this.labelPlataLivrare.Name = "labelPlataLivrare";
            this.labelPlataLivrare.Size = new System.Drawing.Size(222, 28);
            this.labelPlataLivrare.TabIndex = 50;
            this.labelPlataLivrare.Text = "Plata la livrare cu cardul:";
            // 
            // checkBoxPlataLivrare
            // 
            this.checkBoxPlataLivrare.AutoSize = true;
            this.checkBoxPlataLivrare.Location = new System.Drawing.Point(843, 817);
            this.checkBoxPlataLivrare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxPlataLivrare.Name = "checkBoxPlataLivrare";
            this.checkBoxPlataLivrare.Size = new System.Drawing.Size(18, 17);
            this.checkBoxPlataLivrare.TabIndex = 51;
            this.checkBoxPlataLivrare.UseVisualStyleBackColor = true;
            this.checkBoxPlataLivrare.CheckedChanged += new System.EventHandler(this.checkBoxPlataLivrare_CheckedChanged);
            // 
            // checkBoxTermeniCond
            // 
            this.checkBoxTermeniCond.AutoSize = true;
            this.checkBoxTermeniCond.Location = new System.Drawing.Point(819, 880);
            this.checkBoxTermeniCond.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxTermeniCond.Name = "checkBoxTermeniCond";
            this.checkBoxTermeniCond.Size = new System.Drawing.Size(18, 17);
            this.checkBoxTermeniCond.TabIndex = 52;
            this.checkBoxTermeniCond.UseVisualStyleBackColor = true;
            // 
            // labelTermeniCond
            // 
            this.labelTermeniCond.AutoSize = true;
            this.labelTermeniCond.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTermeniCond.ForeColor = System.Drawing.Color.Black;
            this.labelTermeniCond.Location = new System.Drawing.Point(843, 872);
            this.labelTermeniCond.Name = "labelTermeniCond";
            this.labelTermeniCond.Size = new System.Drawing.Size(353, 28);
            this.labelTermeniCond.TabIndex = 53;
            this.labelTermeniCond.Text = "Sunt de accord cu termenii si conditiile.";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 905);
            this.Controls.Add(this.labelTermeniCond);
            this.Controls.Add(this.checkBoxTermeniCond);
            this.Controls.Add(this.checkBoxPlataLivrare);
            this.Controls.Add(this.labelPlataLivrare);
            this.Controls.Add(this.checkBoxPlataCash);
            this.Controls.Add(this.labelPlataCash);
            this.Controls.Add(this.labelPlata);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.comboBoxMinutePredare);
            this.Controls.Add(this.comboBoxOraPredare);
            this.Controls.Add(this.labelMinutePredare);
            this.Controls.Add(this.labelOraPredare);
            this.Controls.Add(this.labelMinutePreluare);
            this.Controls.Add(this.labelOraPreluare);
            this.Controls.Add(this.comboBoxMinutePreluare);
            this.Controls.Add(this.comboBoxPreluare);
            this.Controls.Add(this.buttonTrimiteRezervarea);
            this.Controls.Add(this.labelSumarRezervare);
            this.Controls.Add(this.textBoxSumarRezervare);
            this.Controls.Add(this.labelMesaj);
            this.Controls.Add(this.textBoxMesaj);
            this.Controls.Add(this.labelInfoTelefon);
            this.Controls.Add(this.textBoxTelefon);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.labelDatePersonale);
            this.Controls.Add(this.labelAlegeDatele);
            this.Controls.Add(this.labelDataPredarii);
            this.Controls.Add(this.labelDataPreluarii);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBoxCarForm2);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarForm2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.PictureBox pictureBoxCarForm2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label labelDataPreluarii;
        private System.Windows.Forms.Label labelDataPredarii;
        private System.Windows.Forms.Label labelAlegeDatele;
        private System.Windows.Forms.Label labelDatePersonale;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Label labelInfoTelefon;
        private System.Windows.Forms.TextBox textBoxMesaj;
        private System.Windows.Forms.Label labelMesaj;
        private System.Windows.Forms.TextBox textBoxSumarRezervare;
        private System.Windows.Forms.Label labelSumarRezervare;
        private System.Windows.Forms.Button buttonTrimiteRezervarea;
        private System.Windows.Forms.ComboBox comboBoxPreluare;
        private System.Windows.Forms.ComboBox comboBoxMinutePreluare;
        private System.Windows.Forms.Label labelOraPreluare;
        private System.Windows.Forms.Label labelMinutePreluare;
        private System.Windows.Forms.Label labelOraPredare;
        private System.Windows.Forms.Label labelMinutePredare;
        private System.Windows.Forms.ComboBox comboBoxOraPredare;
        private System.Windows.Forms.ComboBox comboBoxMinutePredare;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Label labelPlata;
        private System.Windows.Forms.Label labelPlataCash;
        private System.Windows.Forms.CheckBox checkBoxPlataCash;
        private System.Windows.Forms.Label labelPlataLivrare;
        private System.Windows.Forms.CheckBox checkBoxPlataLivrare;
        private System.Windows.Forms.CheckBox checkBoxTermeniCond;
        private System.Windows.Forms.Label labelTermeniCond;
    }
}