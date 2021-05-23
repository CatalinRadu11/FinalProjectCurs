
namespace FinalProjectCurs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonRezervaAcum = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.pictureBoxEmail = new System.Windows.Forms.PictureBox();
            this.textBoxCarDescription = new System.Windows.Forms.TextBox();
            this.pictureBox_car1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_car2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_car3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_car = new System.Windows.Forms.PictureBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.buttonRezervaAcum);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker2);
            this.splitContainer1.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxCar);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.labelLocation);
            this.splitContainer1.Panel1.Controls.Add(this.labelCompanyName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.labelEmail);
            this.splitContainer1.Panel2.Controls.Add(this.labelPhone);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxPhone);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBoxEmail);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCarDescription);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox_car1);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox_car2);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox_car3);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox_car);
            this.splitContainer1.Panel2.Controls.Add(this.labelPrice);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.splitContainer1.Size = new System.Drawing.Size(1269, 721);
            this.splitContainer1.SplitterDistance = 423;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonRezervaAcum
            // 
            this.buttonRezervaAcum.Location = new System.Drawing.Point(119, 567);
            this.buttonRezervaAcum.Name = "buttonRezervaAcum";
            this.buttonRezervaAcum.Size = new System.Drawing.Size(157, 34);
            this.buttonRezervaAcum.TabIndex = 19;
            this.buttonRezervaAcum.Text = "Rezerva acum";
            this.buttonRezervaAcum.UseVisualStyleBackColor = true;
            this.buttonRezervaAcum.Click += new System.EventHandler(this.buttonRezervaAcum_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(98, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Selecteaza Masina:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(98, 349);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 281);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // comboBoxCar
            // 
            this.comboBoxCar.FormattingEnabled = true;
            this.comboBoxCar.Location = new System.Drawing.Point(98, 485);
            this.comboBoxCar.Name = "comboBoxCar";
            this.comboBoxCar.Size = new System.Drawing.Size(200, 23);
            this.comboBoxCar.TabIndex = 15;
            this.comboBoxCar.Text = "----------Alegeti o masina----------";
            this.comboBoxCar.SelectedIndexChanged += new System.EventHandler(this.comboBoxCar_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(98, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Pana la data de:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(98, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "De la data de:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLocation.ForeColor = System.Drawing.Color.Black;
            this.labelLocation.Location = new System.Drawing.Point(69, 182);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(283, 25);
            this.labelLocation.TabIndex = 12;
            this.labelLocation.Text = "Locatie: Aeroport Cluj-Napoca";
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCompanyName.ForeColor = System.Drawing.Color.Black;
            this.labelCompanyName.Location = new System.Drawing.Point(69, 134);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(135, 32);
            this.labelCompanyName.TabIndex = 11;
            this.labelCompanyName.Text = "Rent A Car";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(664, 676);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(169, 21);
            this.labelEmail.TabIndex = 21;
            this.labelEmail.Text = "rentacar@gmail.com";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.Location = new System.Drawing.Point(666, 642);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(108, 21);
            this.labelPhone.TabIndex = 20;
            this.labelPhone.Text = "0745 999 999";
            // 
            // pictureBoxPhone
            // 
            this.pictureBoxPhone.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhone.Image")));
            this.pictureBoxPhone.Location = new System.Drawing.Point(628, 639);
            this.pictureBoxPhone.Name = "pictureBoxPhone";
            this.pictureBoxPhone.Size = new System.Drawing.Size(32, 24);
            this.pictureBoxPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhone.TabIndex = 19;
            this.pictureBoxPhone.TabStop = false;
            // 
            // pictureBoxEmail
            // 
            this.pictureBoxEmail.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEmail.Image")));
            this.pictureBoxEmail.Location = new System.Drawing.Point(628, 669);
            this.pictureBoxEmail.Name = "pictureBoxEmail";
            this.pictureBoxEmail.Size = new System.Drawing.Size(32, 28);
            this.pictureBoxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEmail.TabIndex = 18;
            this.pictureBoxEmail.TabStop = false;
            // 
            // textBoxCarDescription
            // 
            this.textBoxCarDescription.Location = new System.Drawing.Point(160, 579);
            this.textBoxCarDescription.Multiline = true;
            this.textBoxCarDescription.Name = "textBoxCarDescription";
            this.textBoxCarDescription.Size = new System.Drawing.Size(383, 118);
            this.textBoxCarDescription.TabIndex = 17;
            // 
            // pictureBox_car1
            // 
            this.pictureBox_car1.Location = new System.Drawing.Point(264, 77);
            this.pictureBox_car1.Name = "pictureBox_car1";
            this.pictureBox_car1.Size = new System.Drawing.Size(78, 44);
            this.pictureBox_car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_car1.TabIndex = 16;
            this.pictureBox_car1.TabStop = false;
            this.pictureBox_car1.Click += new System.EventHandler(this.pictureBox_car1_Click);
            // 
            // pictureBox_car2
            // 
            this.pictureBox_car2.Location = new System.Drawing.Point(348, 77);
            this.pictureBox_car2.Name = "pictureBox_car2";
            this.pictureBox_car2.Size = new System.Drawing.Size(78, 44);
            this.pictureBox_car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_car2.TabIndex = 15;
            this.pictureBox_car2.TabStop = false;
            this.pictureBox_car2.Click += new System.EventHandler(this.pictureBox_car2_Click);
            // 
            // pictureBox_car3
            // 
            this.pictureBox_car3.Location = new System.Drawing.Point(432, 77);
            this.pictureBox_car3.Name = "pictureBox_car3";
            this.pictureBox_car3.Size = new System.Drawing.Size(78, 44);
            this.pictureBox_car3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_car3.TabIndex = 14;
            this.pictureBox_car3.TabStop = false;
            this.pictureBox_car3.Click += new System.EventHandler(this.pictureBox_car3_Click);
            // 
            // pictureBox_car
            // 
            this.pictureBox_car.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_car.Location = new System.Drawing.Point(38, 158);
            this.pictureBox_car.Name = "pictureBox_car";
            this.pictureBox_car.Size = new System.Drawing.Size(764, 404);
            this.pictureBox_car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_car.TabIndex = 13;
            this.pictureBox_car.TabStop = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(38, 611);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(116, 54);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "Price";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1269, 721);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonRezervaAcum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.PictureBox pictureBox_car;
        private System.Windows.Forms.PictureBox pictureBox_car1;
        private System.Windows.Forms.PictureBox pictureBox_car2;
        private System.Windows.Forms.PictureBox pictureBox_car3;
        private System.Windows.Forms.PictureBox pictureBoxPhone;
        private System.Windows.Forms.PictureBox pictureBoxEmail;
        private System.Windows.Forms.TextBox textBoxCarDescription;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

