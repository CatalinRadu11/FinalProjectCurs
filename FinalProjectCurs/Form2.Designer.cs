
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
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
            this.labelSumarRezervare = new System.Windows.Forms.Label();
            this.buttonTrimiteRezervarea = new System.Windows.Forms.Button();
            this.comboBoxOraPreluare = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutePreluare = new System.Windows.Forms.ComboBox();
            this.labelOraPreluare = new System.Windows.Forms.Label();
            this.labelMinutePreluare = new System.Windows.Forms.Label();
            this.labelOraPredare = new System.Windows.Forms.Label();
            this.labelMinutePredare = new System.Windows.Forms.Label();
            this.comboBoxOraPredare = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutePredare = new System.Windows.Forms.ComboBox();
            this.labelPlata = new System.Windows.Forms.Label();
            this.labelPlataCash = new System.Windows.Forms.Label();
            this.checkBoxPlataCash = new System.Windows.Forms.CheckBox();
            this.labelPlataLivrare = new System.Windows.Forms.Label();
            this.checkBoxPlataLivrare = new System.Windows.Forms.CheckBox();
            this.checkBoxTermeniCond = new System.Windows.Forms.CheckBox();
            this.listBoxTrimiteRezervarea = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarForm2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCarForm2
            // 
            this.pictureBoxCarForm2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCarForm2.Location = new System.Drawing.Point(64, 79);
            this.pictureBoxCarForm2.Name = "pictureBoxCarForm2";
            this.pictureBoxCarForm2.Size = new System.Drawing.Size(596, 276);
            this.pictureBoxCarForm2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCarForm2.TabIndex = 2;
            this.pictureBoxCarForm2.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(719, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 23);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(719, 201);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(197, 23);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // labelDataPreluarii
            // 
            this.labelDataPreluarii.AutoSize = true;
            this.labelDataPreluarii.BackColor = System.Drawing.Color.Transparent;
            this.labelDataPreluarii.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDataPreluarii.ForeColor = System.Drawing.Color.LightGray;
            this.labelDataPreluarii.Location = new System.Drawing.Point(719, 82);
            this.labelDataPreluarii.Name = "labelDataPreluarii";
            this.labelDataPreluarii.Size = new System.Drawing.Size(111, 21);
            this.labelDataPreluarii.TabIndex = 14;
            this.labelDataPreluarii.Text = "Data preluarii:";
            // 
            // labelDataPredarii
            // 
            this.labelDataPredarii.AutoSize = true;
            this.labelDataPredarii.BackColor = System.Drawing.Color.Transparent;
            this.labelDataPredarii.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDataPredarii.ForeColor = System.Drawing.Color.LightGray;
            this.labelDataPredarii.Location = new System.Drawing.Point(719, 177);
            this.labelDataPredarii.Name = "labelDataPredarii";
            this.labelDataPredarii.Size = new System.Drawing.Size(108, 21);
            this.labelDataPredarii.TabIndex = 15;
            this.labelDataPredarii.Text = "Data predarii:";
            // 
            // labelAlegeDatele
            // 
            this.labelAlegeDatele.AutoSize = true;
            this.labelAlegeDatele.BackColor = System.Drawing.Color.Transparent;
            this.labelAlegeDatele.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAlegeDatele.ForeColor = System.Drawing.Color.Tomato;
            this.labelAlegeDatele.Location = new System.Drawing.Point(717, 23);
            this.labelAlegeDatele.Name = "labelAlegeDatele";
            this.labelAlegeDatele.Size = new System.Drawing.Size(146, 25);
            this.labelAlegeDatele.TabIndex = 16;
            this.labelAlegeDatele.Text = "ALEGE DATELE:";
            // 
            // labelDatePersonale
            // 
            this.labelDatePersonale.AutoSize = true;
            this.labelDatePersonale.BackColor = System.Drawing.Color.Transparent;
            this.labelDatePersonale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDatePersonale.ForeColor = System.Drawing.Color.Tomato;
            this.labelDatePersonale.Location = new System.Drawing.Point(719, 279);
            this.labelDatePersonale.Name = "labelDatePersonale";
            this.labelDatePersonale.Size = new System.Drawing.Size(176, 25);
            this.labelDatePersonale.TabIndex = 17;
            this.labelDatePersonale.Text = "DATE PERSONALE:";
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.BackColor = System.Drawing.Color.Transparent;
            this.labelNume.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNume.ForeColor = System.Drawing.Color.LightGray;
            this.labelNume.Location = new System.Drawing.Point(719, 334);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(58, 21);
            this.labelNume.TabIndex = 18;
            this.labelNume.Text = "Nume:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.ForeColor = System.Drawing.Color.LightGray;
            this.labelEmail.Location = new System.Drawing.Point(719, 401);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 21);
            this.labelEmail.TabIndex = 19;
            this.labelEmail.Text = "Email:";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.BackColor = System.Drawing.Color.Transparent;
            this.labelTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTelefon.ForeColor = System.Drawing.Color.LightGray;
            this.labelTelefon.Location = new System.Drawing.Point(719, 474);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(68, 21);
            this.labelTelefon.TabIndex = 20;
            this.labelTelefon.Text = "Telefon:";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(719, 358);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(241, 23);
            this.textBoxNume.TabIndex = 21;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(719, 425);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(241, 23);
            this.textBoxEmail.TabIndex = 22;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(719, 498);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(241, 23);
            this.textBoxTelefon.TabIndex = 23;
            // 
            // labelInfoTelefon
            // 
            this.labelInfoTelefon.AutoSize = true;
            this.labelInfoTelefon.Location = new System.Drawing.Point(719, 528);
            this.labelInfoTelefon.Name = "labelInfoTelefon";
            this.labelInfoTelefon.Size = new System.Drawing.Size(241, 15);
            this.labelInfoTelefon.TabIndex = 24;
            this.labelInfoTelefon.Text = " Introduceti prefixul tarii. Ex: +40 750 000 000";
            // 
            // textBoxMesaj
            // 
            this.textBoxMesaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxMesaj.Location = new System.Drawing.Point(992, 358);
            this.textBoxMesaj.Multiline = true;
            this.textBoxMesaj.Name = "textBoxMesaj";
            this.textBoxMesaj.Size = new System.Drawing.Size(237, 163);
            this.textBoxMesaj.TabIndex = 25;
            // 
            // labelMesaj
            // 
            this.labelMesaj.AutoSize = true;
            this.labelMesaj.BackColor = System.Drawing.Color.Transparent;
            this.labelMesaj.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMesaj.ForeColor = System.Drawing.Color.LightGray;
            this.labelMesaj.Location = new System.Drawing.Point(992, 334);
            this.labelMesaj.Name = "labelMesaj";
            this.labelMesaj.Size = new System.Drawing.Size(57, 21);
            this.labelMesaj.TabIndex = 26;
            this.labelMesaj.Text = "Mesaj:";
            // 
            // labelSumarRezervare
            // 
            this.labelSumarRezervare.AutoSize = true;
            this.labelSumarRezervare.BackColor = System.Drawing.Color.Transparent;
            this.labelSumarRezervare.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSumarRezervare.ForeColor = System.Drawing.Color.Tomato;
            this.labelSumarRezervare.Location = new System.Drawing.Point(195, 490);
            this.labelSumarRezervare.Name = "labelSumarRezervare";
            this.labelSumarRezervare.Size = new System.Drawing.Size(193, 25);
            this.labelSumarRezervare.TabIndex = 29;
            this.labelSumarRezervare.Text = "SUMAR REZERVARE:";
            // 
            // buttonTrimiteRezervarea
            // 
            this.buttonTrimiteRezervarea.Location = new System.Drawing.Point(250, 633);
            this.buttonTrimiteRezervarea.Name = "buttonTrimiteRezervarea";
            this.buttonTrimiteRezervarea.Size = new System.Drawing.Size(157, 34);
            this.buttonTrimiteRezervarea.TabIndex = 30;
            this.buttonTrimiteRezervarea.Text = "Trimite Rezervarea";
            this.buttonTrimiteRezervarea.UseVisualStyleBackColor = true;
            this.buttonTrimiteRezervarea.Click += new System.EventHandler(this.buttonTrimiteRezervarea_Click);
            // 
            // comboBoxOraPreluare
            // 
            this.comboBoxOraPreluare.FormattingEnabled = true;
            this.comboBoxOraPreluare.Items.AddRange(new object[] {
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
            this.comboBoxOraPreluare.Location = new System.Drawing.Point(1020, 106);
            this.comboBoxOraPreluare.Name = "comboBoxOraPreluare";
            this.comboBoxOraPreluare.Size = new System.Drawing.Size(55, 23);
            this.comboBoxOraPreluare.TabIndex = 32;
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
            this.comboBoxMinutePreluare.Location = new System.Drawing.Point(1153, 106);
            this.comboBoxMinutePreluare.Name = "comboBoxMinutePreluare";
            this.comboBoxMinutePreluare.Size = new System.Drawing.Size(55, 23);
            this.comboBoxMinutePreluare.TabIndex = 35;
            // 
            // labelOraPreluare
            // 
            this.labelOraPreluare.AutoSize = true;
            this.labelOraPreluare.BackColor = System.Drawing.Color.Transparent;
            this.labelOraPreluare.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOraPreluare.ForeColor = System.Drawing.Color.LightGray;
            this.labelOraPreluare.Location = new System.Drawing.Point(1019, 82);
            this.labelOraPreluare.Name = "labelOraPreluare";
            this.labelOraPreluare.Size = new System.Drawing.Size(40, 21);
            this.labelOraPreluare.TabIndex = 37;
            this.labelOraPreluare.Text = "Ora:";
            // 
            // labelMinutePreluare
            // 
            this.labelMinutePreluare.AutoSize = true;
            this.labelMinutePreluare.BackColor = System.Drawing.Color.Transparent;
            this.labelMinutePreluare.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMinutePreluare.ForeColor = System.Drawing.Color.LightGray;
            this.labelMinutePreluare.Location = new System.Drawing.Point(1152, 82);
            this.labelMinutePreluare.Name = "labelMinutePreluare";
            this.labelMinutePreluare.Size = new System.Drawing.Size(66, 21);
            this.labelMinutePreluare.TabIndex = 38;
            this.labelMinutePreluare.Text = "Minute:";
            // 
            // labelOraPredare
            // 
            this.labelOraPredare.AutoSize = true;
            this.labelOraPredare.BackColor = System.Drawing.Color.Transparent;
            this.labelOraPredare.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOraPredare.ForeColor = System.Drawing.Color.LightGray;
            this.labelOraPredare.Location = new System.Drawing.Point(1019, 180);
            this.labelOraPredare.Name = "labelOraPredare";
            this.labelOraPredare.Size = new System.Drawing.Size(40, 21);
            this.labelOraPredare.TabIndex = 39;
            this.labelOraPredare.Text = "Ora:";
            // 
            // labelMinutePredare
            // 
            this.labelMinutePredare.AutoSize = true;
            this.labelMinutePredare.BackColor = System.Drawing.Color.Transparent;
            this.labelMinutePredare.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMinutePredare.ForeColor = System.Drawing.Color.LightGray;
            this.labelMinutePredare.Location = new System.Drawing.Point(1153, 180);
            this.labelMinutePredare.Name = "labelMinutePredare";
            this.labelMinutePredare.Size = new System.Drawing.Size(66, 21);
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
            this.comboBoxOraPredare.Location = new System.Drawing.Point(1020, 201);
            this.comboBoxOraPredare.Name = "comboBoxOraPredare";
            this.comboBoxOraPredare.Size = new System.Drawing.Size(55, 23);
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
            this.comboBoxMinutePredare.Location = new System.Drawing.Point(1152, 201);
            this.comboBoxMinutePredare.Name = "comboBoxMinutePredare";
            this.comboBoxMinutePredare.Size = new System.Drawing.Size(55, 23);
            this.comboBoxMinutePredare.TabIndex = 42;
            // 
            // labelPlata
            // 
            this.labelPlata.AutoSize = true;
            this.labelPlata.BackColor = System.Drawing.Color.Transparent;
            this.labelPlata.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPlata.ForeColor = System.Drawing.Color.Tomato;
            this.labelPlata.Location = new System.Drawing.Point(729, 558);
            this.labelPlata.Name = "labelPlata";
            this.labelPlata.Size = new System.Drawing.Size(69, 25);
            this.labelPlata.TabIndex = 44;
            this.labelPlata.Text = "PLATA";
            // 
            // labelPlataCash
            // 
            this.labelPlataCash.AutoSize = true;
            this.labelPlataCash.BackColor = System.Drawing.Color.Transparent;
            this.labelPlataCash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlataCash.ForeColor = System.Drawing.Color.Silver;
            this.labelPlataCash.Location = new System.Drawing.Point(754, 581);
            this.labelPlataCash.Name = "labelPlataCash";
            this.labelPlataCash.Size = new System.Drawing.Size(215, 21);
            this.labelPlataCash.TabIndex = 45;
            this.labelPlataCash.Text = "Plata cash la primirea masinii:";
            // 
            // checkBoxPlataCash
            // 
            this.checkBoxPlataCash.AutoSize = true;
            this.checkBoxPlataCash.Location = new System.Drawing.Point(738, 588);
            this.checkBoxPlataCash.Name = "checkBoxPlataCash";
            this.checkBoxPlataCash.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPlataCash.TabIndex = 49;
            this.checkBoxPlataCash.UseVisualStyleBackColor = true;
            this.checkBoxPlataCash.CheckedChanged += new System.EventHandler(this.checkBoxPlataCash_CheckedChanged);
            // 
            // labelPlataLivrare
            // 
            this.labelPlataLivrare.AutoSize = true;
            this.labelPlataLivrare.BackColor = System.Drawing.Color.Transparent;
            this.labelPlataLivrare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlataLivrare.ForeColor = System.Drawing.Color.Silver;
            this.labelPlataLivrare.Location = new System.Drawing.Point(754, 606);
            this.labelPlataLivrare.Name = "labelPlataLivrare";
            this.labelPlataLivrare.Size = new System.Drawing.Size(178, 21);
            this.labelPlataLivrare.TabIndex = 50;
            this.labelPlataLivrare.Text = "Plata la livrare cu cardul:";
            // 
            // checkBoxPlataLivrare
            // 
            this.checkBoxPlataLivrare.AutoSize = true;
            this.checkBoxPlataLivrare.Location = new System.Drawing.Point(738, 613);
            this.checkBoxPlataLivrare.Name = "checkBoxPlataLivrare";
            this.checkBoxPlataLivrare.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPlataLivrare.TabIndex = 51;
            this.checkBoxPlataLivrare.UseVisualStyleBackColor = true;
            this.checkBoxPlataLivrare.CheckedChanged += new System.EventHandler(this.checkBoxPlataLivrare_CheckedChanged);
            // 
            // checkBoxTermeniCond
            // 
            this.checkBoxTermeniCond.AutoSize = true;
            this.checkBoxTermeniCond.Location = new System.Drawing.Point(717, 660);
            this.checkBoxTermeniCond.Name = "checkBoxTermeniCond";
            this.checkBoxTermeniCond.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTermeniCond.TabIndex = 52;
            this.checkBoxTermeniCond.UseVisualStyleBackColor = true;
            // 
            // listBoxTrimiteRezervarea
            // 
            this.listBoxTrimiteRezervarea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxTrimiteRezervarea.FormattingEnabled = true;
            this.listBoxTrimiteRezervarea.HorizontalScrollbar = true;
            this.listBoxTrimiteRezervarea.ItemHeight = 15;
            this.listBoxTrimiteRezervarea.Location = new System.Drawing.Point(195, 518);
            this.listBoxTrimiteRezervarea.Name = "listBoxTrimiteRezervarea";
            this.listBoxTrimiteRezervarea.Size = new System.Drawing.Size(260, 109);
            this.listBoxTrimiteRezervarea.TabIndex = 54;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(738, 660);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(206, 15);
            this.linkLabel1.TabIndex = 56;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Sunt de acord cu termenii si conditiile";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 679);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxTrimiteRezervarea);
            this.Controls.Add(this.checkBoxTermeniCond);
            this.Controls.Add(this.checkBoxPlataLivrare);
            this.Controls.Add(this.labelPlataLivrare);
            this.Controls.Add(this.checkBoxPlataCash);
            this.Controls.Add(this.labelPlataCash);
            this.Controls.Add(this.labelPlata);
            this.Controls.Add(this.comboBoxMinutePredare);
            this.Controls.Add(this.comboBoxOraPredare);
            this.Controls.Add(this.labelMinutePredare);
            this.Controls.Add(this.labelOraPredare);
            this.Controls.Add(this.labelMinutePreluare);
            this.Controls.Add(this.labelOraPreluare);
            this.Controls.Add(this.comboBoxMinutePreluare);
            this.Controls.Add(this.comboBoxOraPreluare);
            this.Controls.Add(this.buttonTrimiteRezervarea);
            this.Controls.Add(this.labelSumarRezervare);
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
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarForm2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label labelSumarRezervare;
        private System.Windows.Forms.Button buttonTrimiteRezervarea;
        private System.Windows.Forms.ComboBox comboBoxOraPreluare;
        private System.Windows.Forms.ComboBox comboBoxMinutePreluare;
        private System.Windows.Forms.Label labelOraPreluare;
        private System.Windows.Forms.Label labelMinutePreluare;
        private System.Windows.Forms.Label labelOraPredare;
        private System.Windows.Forms.Label labelMinutePredare;
        private System.Windows.Forms.ComboBox comboBoxOraPredare;
        private System.Windows.Forms.ComboBox comboBoxMinutePredare;
        private System.Windows.Forms.Label labelPlata;
        private System.Windows.Forms.Label labelPlataCash;
        private System.Windows.Forms.CheckBox checkBoxPlataCash;
        private System.Windows.Forms.Label labelPlataLivrare;
        private System.Windows.Forms.CheckBox checkBoxPlataLivrare;
        private System.Windows.Forms.CheckBox checkBoxTermeniCond;
        private System.Windows.Forms.ListBox listBoxTrimiteRezervarea;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}