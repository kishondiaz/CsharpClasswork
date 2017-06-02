namespace Simple
{
    partial class frmSample
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
            this.btnDispalyFullName = new System.Windows.Forms.Button();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtBoxFullName = new System.Windows.Forms.TextBox();
            this.cmbFavColor = new System.Windows.Forms.ComboBox();
            this.chkDog = new System.Windows.Forms.CheckBox();
            this.chkCat = new System.Windows.Forms.CheckBox();
            this.chkBird = new System.Windows.Forms.CheckBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.grpAnimal = new System.Windows.Forms.GroupBox();
            this.rdoSingle = new System.Windows.Forms.RadioButton();
            this.rdoDivorced = new System.Windows.Forms.RadioButton();
            this.rdoMarried = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAnimalLover = new System.Windows.Forms.CheckBox();
            this.grpAnimal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDispalyFullName
            // 
            this.btnDispalyFullName.Location = new System.Drawing.Point(78, 294);
            this.btnDispalyFullName.Name = "btnDispalyFullName";
            this.btnDispalyFullName.Size = new System.Drawing.Size(240, 37);
            this.btnDispalyFullName.TabIndex = 4;
            this.btnDispalyFullName.Text = "&Display Full Name";
            this.btnDispalyFullName.UseVisualStyleBackColor = true;
            this.btnDispalyFullName.Click += new System.EventHandler(this.btnDispalyFullName_Click);
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(218, 94);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLastName.TabIndex = 3;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(218, 52);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFirstName.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(75, 52);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "&First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(75, 101);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 2;
            this.lastNameLabel.Text = "&Last Name";
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(78, 337);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(240, 37);
            this.btnClearForm.TabIndex = 5;
            this.btnClearForm.Text = "&Clear Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(75, 155);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "&Full Name";
            this.lblFullName.Visible = false;
            // 
            // txtBoxFullName
            // 
            this.txtBoxFullName.Location = new System.Drawing.Point(218, 148);
            this.txtBoxFullName.Name = "txtBoxFullName";
            this.txtBoxFullName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFullName.TabIndex = 7;
            this.txtBoxFullName.Visible = false;
            // 
            // cmbFavColor
            // 
            this.cmbFavColor.FormattingEnabled = true;
            this.cmbFavColor.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Blue",
            "Indigo",
            "Violet"});
            this.cmbFavColor.Location = new System.Drawing.Point(379, 345);
            this.cmbFavColor.Name = "cmbFavColor";
            this.cmbFavColor.Size = new System.Drawing.Size(153, 21);
            this.cmbFavColor.TabIndex = 8;
            this.cmbFavColor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chkDog
            // 
            this.chkDog.AutoSize = true;
            this.chkDog.Location = new System.Drawing.Point(8, 16);
            this.chkDog.Name = "chkDog";
            this.chkDog.Size = new System.Drawing.Size(46, 17);
            this.chkDog.TabIndex = 9;
            this.chkDog.Text = "Dog";
            this.chkDog.UseVisualStyleBackColor = true;
            this.chkDog.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkCat
            // 
            this.chkCat.AutoSize = true;
            this.chkCat.Location = new System.Drawing.Point(8, 39);
            this.chkCat.Name = "chkCat";
            this.chkCat.Size = new System.Drawing.Size(42, 17);
            this.chkCat.TabIndex = 10;
            this.chkCat.Text = "Cat";
            this.chkCat.UseVisualStyleBackColor = true;
            // 
            // chkBird
            // 
            this.chkBird.AutoSize = true;
            this.chkBird.Location = new System.Drawing.Point(6, 65);
            this.chkBird.Name = "chkBird";
            this.chkBird.Size = new System.Drawing.Size(44, 17);
            this.chkBird.TabIndex = 11;
            this.chkBird.Text = "Bird";
            this.chkBird.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(6, 21);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 12;
            this.rdoMale.Text = "&Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Checked = true;
            this.rdoFemale.Location = new System.Drawing.Point(6, 44);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 13;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "F&emale";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.CheckedChanged += new System.EventHandler(this.rdoFemale_CheckedChanged);
            // 
            // grpAnimal
            // 
            this.grpAnimal.Controls.Add(this.chkCat);
            this.grpAnimal.Controls.Add(this.chkDog);
            this.grpAnimal.Controls.Add(this.chkBird);
            this.grpAnimal.Location = new System.Drawing.Point(379, 32);
            this.grpAnimal.Name = "grpAnimal";
            this.grpAnimal.Size = new System.Drawing.Size(153, 100);
            this.grpAnimal.TabIndex = 14;
            this.grpAnimal.TabStop = false;
            this.grpAnimal.Text = "Favorite Animal";
            this.grpAnimal.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdoSingle
            // 
            this.rdoSingle.AutoSize = true;
            this.rdoSingle.Checked = true;
            this.rdoSingle.Location = new System.Drawing.Point(6, 20);
            this.rdoSingle.Name = "rdoSingle";
            this.rdoSingle.Size = new System.Drawing.Size(54, 17);
            this.rdoSingle.TabIndex = 15;
            this.rdoSingle.TabStop = true;
            this.rdoSingle.Text = "Single";
            this.rdoSingle.UseVisualStyleBackColor = true;
            // 
            // rdoDivorced
            // 
            this.rdoDivorced.AutoSize = true;
            this.rdoDivorced.Location = new System.Drawing.Point(6, 66);
            this.rdoDivorced.Name = "rdoDivorced";
            this.rdoDivorced.Size = new System.Drawing.Size(68, 17);
            this.rdoDivorced.TabIndex = 17;
            this.rdoDivorced.Text = "Divorced";
            this.rdoDivorced.UseVisualStyleBackColor = true;
            this.rdoDivorced.CheckedChanged += new System.EventHandler(this.rdoDivorced_CheckedChanged);
            // 
            // rdoMarried
            // 
            this.rdoMarried.AutoSize = true;
            this.rdoMarried.Location = new System.Drawing.Point(6, 43);
            this.rdoMarried.Name = "rdoMarried";
            this.rdoMarried.Size = new System.Drawing.Size(60, 17);
            this.rdoMarried.TabIndex = 18;
            this.rdoMarried.Text = "Married";
            this.rdoMarried.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoFemale);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Location = new System.Drawing.Point(379, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(153, 74);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoMarried);
            this.groupBox2.Controls.Add(this.rdoSingle);
            this.groupBox2.Controls.Add(this.rdoDivorced);
            this.groupBox2.Location = new System.Drawing.Point(379, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 93);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Marital Status";
            // 
            // chkAnimalLover
            // 
            this.chkAnimalLover.AutoSize = true;
            this.chkAnimalLover.Location = new System.Drawing.Point(385, 143);
            this.chkAnimalLover.Name = "chkAnimalLover";
            this.chkAnimalLover.Size = new System.Drawing.Size(87, 17);
            this.chkAnimalLover.TabIndex = 21;
            this.chkAnimalLover.Text = "Animal Lover";
            this.chkAnimalLover.UseVisualStyleBackColor = true;
            this.chkAnimalLover.CheckedChanged += new System.EventHandler(this.chkAnimalLover_CheckedChanged);
            // 
            // frmSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 457);
            this.Controls.Add(this.chkAnimalLover);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAnimal);
            this.Controls.Add(this.cmbFavColor);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.txtBoxFullName);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.btnDispalyFullName);
            this.Name = "frmSample";
            this.Text = "Simple Control Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAnimal.ResumeLayout(false);
            this.grpAnimal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDispalyFullName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtBoxFullName;
        private System.Windows.Forms.ComboBox cmbFavColor;
        private System.Windows.Forms.CheckBox chkDog;
        private System.Windows.Forms.CheckBox chkCat;
        private System.Windows.Forms.CheckBox chkBird;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.GroupBox grpAnimal;
        private System.Windows.Forms.RadioButton rdoSingle;
        private System.Windows.Forms.RadioButton rdoDivorced;
        private System.Windows.Forms.RadioButton rdoMarried;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkAnimalLover;
    }
}

