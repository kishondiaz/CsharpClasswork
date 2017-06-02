namespace Exam2Question2SportingEvents
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txBxLastname = new System.Windows.Forms.TextBox();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.radioBtnGirl = new System.Windows.Forms.RadioButton();
            this.radioBtnBoy = new System.Windows.Forms.RadioButton();
            this.grpSports = new System.Windows.Forms.GroupBox();
            this.radioBtnField = new System.Windows.Forms.RadioButton();
            this.radioBtnSoftBall = new System.Windows.Forms.RadioButton();
            this.radioBtnBasketBall = new System.Windows.Forms.RadioButton();
            this.radioBtnFlagBall = new System.Windows.Forms.RadioButton();
            this.radioBtnSoccer = new System.Windows.Forms.RadioButton();
            this.btnRegister = new System.Windows.Forms.Button();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.pxBx10 = new System.Windows.Forms.PictureBox();
            this.pxBx9 = new System.Windows.Forms.PictureBox();
            this.pxBx8 = new System.Windows.Forms.PictureBox();
            this.pxBx7 = new System.Windows.Forms.PictureBox();
            this.pxBx6 = new System.Windows.Forms.PictureBox();
            this.pxBx5 = new System.Windows.Forms.PictureBox();
            this.pxBx4 = new System.Windows.Forms.PictureBox();
            this.pxBx3 = new System.Windows.Forms.PictureBox();
            this.pxBx2 = new System.Windows.Forms.PictureBox();
            this.picBx0 = new System.Windows.Forms.PictureBox();
            this.grpGender.SuspendLayout();
            this.grpSports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx0)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(30, 87);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(57, 13);
            this.lbFirstName.TabIndex = 0;
            this.lbFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(30, 125);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // txBxLastname
            // 
            this.txBxLastname.Location = new System.Drawing.Point(93, 118);
            this.txBxLastname.Name = "txBxLastname";
            this.txBxLastname.Size = new System.Drawing.Size(128, 20);
            this.txBxLastname.TabIndex = 2;
            this.txBxLastname.TextChanged += new System.EventHandler(this.txBxLastname_TextChanged);
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(93, 80);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(128, 20);
            this.txtBxFirstName.TabIndex = 3;
            this.txtBxFirstName.TextChanged += new System.EventHandler(this.txtBxFirstName_TextChanged);
            // 
            // grpGender
            // 
            this.grpGender.Controls.Add(this.radioBtnGirl);
            this.grpGender.Controls.Add(this.radioBtnBoy);
            this.grpGender.Location = new System.Drawing.Point(33, 167);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(200, 100);
            this.grpGender.TabIndex = 4;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "Gender";
            this.grpGender.Enter += new System.EventHandler(this.grpGender_Enter);
            // 
            // radioBtnGirl
            // 
            this.radioBtnGirl.AutoSize = true;
            this.radioBtnGirl.Location = new System.Drawing.Point(83, 53);
            this.radioBtnGirl.Name = "radioBtnGirl";
            this.radioBtnGirl.Size = new System.Drawing.Size(40, 17);
            this.radioBtnGirl.TabIndex = 1;
            this.radioBtnGirl.Text = "Girl";
            this.radioBtnGirl.UseVisualStyleBackColor = true;
            this.radioBtnGirl.CheckedChanged += new System.EventHandler(this.radioBtnGirl_CheckedChanged);
            // 
            // radioBtnBoy
            // 
            this.radioBtnBoy.Checked = true;
            this.radioBtnBoy.Location = new System.Drawing.Point(15, 47);
            this.radioBtnBoy.Name = "radioBtnBoy";
            this.radioBtnBoy.Size = new System.Drawing.Size(61, 24);
            this.radioBtnBoy.TabIndex = 0;
            this.radioBtnBoy.TabStop = true;
            this.radioBtnBoy.Text = "Boy";
            this.radioBtnBoy.UseVisualStyleBackColor = true;
            this.radioBtnBoy.CheckedChanged += new System.EventHandler(this.radioBtnBoy_CheckedChanged);
            // 
            // grpSports
            // 
            this.grpSports.Controls.Add(this.radioBtnField);
            this.grpSports.Controls.Add(this.radioBtnSoftBall);
            this.grpSports.Controls.Add(this.radioBtnBasketBall);
            this.grpSports.Controls.Add(this.radioBtnFlagBall);
            this.grpSports.Controls.Add(this.radioBtnSoccer);
            this.grpSports.Location = new System.Drawing.Point(33, 273);
            this.grpSports.Name = "grpSports";
            this.grpSports.Size = new System.Drawing.Size(200, 141);
            this.grpSports.TabIndex = 5;
            this.grpSports.TabStop = false;
            this.grpSports.Text = "Sports";
            this.grpSports.Enter += new System.EventHandler(this.grpSports_Enter);
            // 
            // radioBtnField
            // 
            this.radioBtnField.AutoSize = true;
            this.radioBtnField.Location = new System.Drawing.Point(15, 114);
            this.radioBtnField.Name = "radioBtnField";
            this.radioBtnField.Size = new System.Drawing.Size(87, 17);
            this.radioBtnField.TabIndex = 5;
            this.radioBtnField.Text = "Field Hockey";
            this.radioBtnField.UseVisualStyleBackColor = true;
            this.radioBtnField.CheckedChanged += new System.EventHandler(this.radioBtnField_CheckedChanged);
            // 
            // radioBtnSoftBall
            // 
            this.radioBtnSoftBall.AutoSize = true;
            this.radioBtnSoftBall.Location = new System.Drawing.Point(15, 91);
            this.radioBtnSoftBall.Name = "radioBtnSoftBall";
            this.radioBtnSoftBall.Size = new System.Drawing.Size(61, 17);
            this.radioBtnSoftBall.TabIndex = 3;
            this.radioBtnSoftBall.Text = "SoftBall";
            this.radioBtnSoftBall.UseVisualStyleBackColor = true;
            this.radioBtnSoftBall.CheckedChanged += new System.EventHandler(this.radioBtnSoftBall_CheckedChanged);
            // 
            // radioBtnBasketBall
            // 
            this.radioBtnBasketBall.AutoSize = true;
            this.radioBtnBasketBall.Location = new System.Drawing.Point(15, 67);
            this.radioBtnBasketBall.Name = "radioBtnBasketBall";
            this.radioBtnBasketBall.Size = new System.Drawing.Size(75, 17);
            this.radioBtnBasketBall.TabIndex = 2;
            this.radioBtnBasketBall.Text = "BasketBall";
            this.radioBtnBasketBall.UseVisualStyleBackColor = true;
            this.radioBtnBasketBall.CheckedChanged += new System.EventHandler(this.radioBtnBasketBall_CheckedChanged);
            // 
            // radioBtnFlagBall
            // 
            this.radioBtnFlagBall.AutoSize = true;
            this.radioBtnFlagBall.Location = new System.Drawing.Point(15, 44);
            this.radioBtnFlagBall.Name = "radioBtnFlagBall";
            this.radioBtnFlagBall.Size = new System.Drawing.Size(86, 17);
            this.radioBtnFlagBall.TabIndex = 1;
            this.radioBtnFlagBall.Text = "Flag FootBall";
            this.radioBtnFlagBall.UseVisualStyleBackColor = true;
            this.radioBtnFlagBall.CheckedChanged += new System.EventHandler(this.radioBtnFlagBall_CheckedChanged);
            // 
            // radioBtnSoccer
            // 
            this.radioBtnSoccer.AutoSize = true;
            this.radioBtnSoccer.Checked = true;
            this.radioBtnSoccer.Location = new System.Drawing.Point(15, 20);
            this.radioBtnSoccer.Name = "radioBtnSoccer";
            this.radioBtnSoccer.Size = new System.Drawing.Size(59, 17);
            this.radioBtnSoccer.TabIndex = 0;
            this.radioBtnSoccer.TabStop = true;
            this.radioBtnSoccer.Text = "Soccer";
            this.radioBtnSoccer.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(33, 449);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(200, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "boy_BasketBall.jpg");
            this.imgList.Images.SetKeyName(1, "boy_Field_Hockey.jpg");
            this.imgList.Images.SetKeyName(2, "boy_Flag_FootBall.jpg");
            this.imgList.Images.SetKeyName(3, "boy_soccer.jpg");
            this.imgList.Images.SetKeyName(4, "boy_SoftBall.jpg");
            this.imgList.Images.SetKeyName(5, "girl_BasketBall.jpg");
            this.imgList.Images.SetKeyName(6, "girl_Field_Hockey.jpg");
            this.imgList.Images.SetKeyName(7, "girl_Flag_FootBall.jpg");
            this.imgList.Images.SetKeyName(8, "girl_soccer.jpg");
            this.imgList.Images.SetKeyName(9, "girl_SoftBall.jpg");
            // 
            // pxBx10
            // 
            this.pxBx10.Location = new System.Drawing.Point(254, 81);
            this.pxBx10.Name = "pxBx10";
            this.pxBx10.Size = new System.Drawing.Size(432, 391);
            this.pxBx10.TabIndex = 37;
            this.pxBx10.TabStop = false;
            this.pxBx10.Visible = false;
            // 
            // pxBx9
            // 
            this.pxBx9.Location = new System.Drawing.Point(254, 80);
            this.pxBx9.Name = "pxBx9";
            this.pxBx9.Size = new System.Drawing.Size(432, 391);
            this.pxBx9.TabIndex = 36;
            this.pxBx9.TabStop = false;
            this.pxBx9.Visible = false;
            // 
            // pxBx8
            // 
            this.pxBx8.Location = new System.Drawing.Point(254, 80);
            this.pxBx8.Name = "pxBx8";
            this.pxBx8.Size = new System.Drawing.Size(432, 391);
            this.pxBx8.TabIndex = 35;
            this.pxBx8.TabStop = false;
            this.pxBx8.Visible = false;
            // 
            // pxBx7
            // 
            this.pxBx7.Location = new System.Drawing.Point(254, 80);
            this.pxBx7.Name = "pxBx7";
            this.pxBx7.Size = new System.Drawing.Size(432, 391);
            this.pxBx7.TabIndex = 34;
            this.pxBx7.TabStop = false;
            this.pxBx7.Visible = false;
            // 
            // pxBx6
            // 
            this.pxBx6.Location = new System.Drawing.Point(254, 80);
            this.pxBx6.Name = "pxBx6";
            this.pxBx6.Size = new System.Drawing.Size(432, 391);
            this.pxBx6.TabIndex = 33;
            this.pxBx6.TabStop = false;
            this.pxBx6.Visible = false;
            // 
            // pxBx5
            // 
            this.pxBx5.Image = global::Exam2Question2SportingEvents.Properties.Resources.boy_Field_Hockey;
            this.pxBx5.Location = new System.Drawing.Point(254, 80);
            this.pxBx5.Name = "pxBx5";
            this.pxBx5.Size = new System.Drawing.Size(432, 391);
            this.pxBx5.TabIndex = 32;
            this.pxBx5.TabStop = false;
            this.pxBx5.Visible = false;
            // 
            // pxBx4
            // 
            this.pxBx4.Image = global::Exam2Question2SportingEvents.Properties.Resources.boy_SoftBall;
            this.pxBx4.Location = new System.Drawing.Point(254, 80);
            this.pxBx4.Name = "pxBx4";
            this.pxBx4.Size = new System.Drawing.Size(432, 391);
            this.pxBx4.TabIndex = 31;
            this.pxBx4.TabStop = false;
            this.pxBx4.Visible = false;
            // 
            // pxBx3
            // 
            this.pxBx3.Image = global::Exam2Question2SportingEvents.Properties.Resources.boy_BasketBall;
            this.pxBx3.Location = new System.Drawing.Point(254, 80);
            this.pxBx3.Name = "pxBx3";
            this.pxBx3.Size = new System.Drawing.Size(432, 391);
            this.pxBx3.TabIndex = 30;
            this.pxBx3.TabStop = false;
            this.pxBx3.Visible = false;
            // 
            // pxBx2
            // 
            this.pxBx2.Image = global::Exam2Question2SportingEvents.Properties.Resources.boy_Flag_FootBall;
            this.pxBx2.Location = new System.Drawing.Point(254, 80);
            this.pxBx2.Name = "pxBx2";
            this.pxBx2.Size = new System.Drawing.Size(432, 391);
            this.pxBx2.TabIndex = 29;
            this.pxBx2.TabStop = false;
            this.pxBx2.Visible = false;
            // 
            // picBx0
            // 
            this.picBx0.Image = global::Exam2Question2SportingEvents.Properties.Resources.boy_soccer;
            this.picBx0.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBx0.InitialImage")));
            this.picBx0.Location = new System.Drawing.Point(254, 80);
            this.picBx0.Name = "picBx0";
            this.picBx0.Size = new System.Drawing.Size(432, 391);
            this.picBx0.TabIndex = 7;
            this.picBx0.TabStop = false;
            this.picBx0.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 539);
            this.Controls.Add(this.pxBx10);
            this.Controls.Add(this.pxBx9);
            this.Controls.Add(this.pxBx8);
            this.Controls.Add(this.pxBx7);
            this.Controls.Add(this.pxBx6);
            this.Controls.Add(this.pxBx5);
            this.Controls.Add(this.pxBx4);
            this.Controls.Add(this.pxBx3);
            this.Controls.Add(this.pxBx2);
            this.Controls.Add(this.picBx0);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.grpSports);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.txBxLastname);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lbFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpGender.ResumeLayout(false);
            this.grpGender.PerformLayout();
            this.grpSports.ResumeLayout(false);
            this.grpSports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxBx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBx0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txBxLastname;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.GroupBox grpSports;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.PictureBox picBx0;
        private System.Windows.Forms.RadioButton radioBtnGirl;
        private System.Windows.Forms.RadioButton radioBtnBoy;
        private System.Windows.Forms.RadioButton radioBtnField;
        private System.Windows.Forms.RadioButton radioBtnSoftBall;
        private System.Windows.Forms.RadioButton radioBtnBasketBall;
        private System.Windows.Forms.RadioButton radioBtnFlagBall;
        private System.Windows.Forms.RadioButton radioBtnSoccer;
        private System.Windows.Forms.PictureBox pxBx2;
        private System.Windows.Forms.PictureBox pxBx3;
        private System.Windows.Forms.PictureBox pxBx4;
        private System.Windows.Forms.PictureBox pxBx5;
        private System.Windows.Forms.PictureBox pxBx6;
        private System.Windows.Forms.PictureBox pxBx7;
        private System.Windows.Forms.PictureBox pxBx8;
        private System.Windows.Forms.PictureBox pxBx9;
        private System.Windows.Forms.PictureBox pxBx10;
    }
}

