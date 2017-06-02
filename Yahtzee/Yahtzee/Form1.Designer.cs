namespace Yahtzee
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.picDie2 = new System.Windows.Forms.PictureBox();
            this.picDie3 = new System.Windows.Forms.PictureBox();
            this.picDie4 = new System.Windows.Forms.PictureBox();
            this.picDie5 = new System.Windows.Forms.PictureBox();
            this.picDie1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.lblRoll = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(195, 379);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(328, 71);
            this.btnRoll.TabIndex = 5;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // picDie2
            // 
            this.picDie2.Image = global::Yahtzee.Properties.Resources.Side_Two_Dice;
            this.picDie2.Location = new System.Drawing.Point(167, 95);
            this.picDie2.Name = "picDie2";
            this.picDie2.Size = new System.Drawing.Size(81, 80);
            this.picDie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDie2.TabIndex = 4;
            this.picDie2.TabStop = false;
            // 
            // picDie3
            // 
            this.picDie3.Image = global::Yahtzee.Properties.Resources.Side_Three_Dice;
            this.picDie3.Location = new System.Drawing.Point(280, 95);
            this.picDie3.Name = "picDie3";
            this.picDie3.Size = new System.Drawing.Size(84, 83);
            this.picDie3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDie3.TabIndex = 3;
            this.picDie3.TabStop = false;
            // 
            // picDie4
            // 
            this.picDie4.Image = global::Yahtzee.Properties.Resources.Side_Four_Dice;
            this.picDie4.Location = new System.Drawing.Point(387, 95);
            this.picDie4.Name = "picDie4";
            this.picDie4.Size = new System.Drawing.Size(85, 83);
            this.picDie4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDie4.TabIndex = 2;
            this.picDie4.TabStop = false;
            // 
            // picDie5
            // 
            this.picDie5.Image = global::Yahtzee.Properties.Resources.Side_Five_Dice;
            this.picDie5.Location = new System.Drawing.Point(505, 95);
            this.picDie5.Name = "picDie5";
            this.picDie5.Size = new System.Drawing.Size(85, 83);
            this.picDie5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDie5.TabIndex = 1;
            this.picDie5.TabStop = false;
            // 
            // picDie1
            // 
            this.picDie1.Image = global::Yahtzee.Properties.Resources.SIde_One_Dice;
            this.picDie1.Location = new System.Drawing.Point(55, 95);
            this.picDie1.Name = "picDie1";
            this.picDie1.Size = new System.Drawing.Size(78, 83);
            this.picDie1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDie1.TabIndex = 0;
            this.picDie1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(55, 203);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(51, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Keep";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(167, 203);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(51, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Keep";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(280, 203);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(51, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Keep";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(387, 203);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(51, 17);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Text = "Keep";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(527, 203);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(51, 17);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.Text = "Keep";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll.Location = new System.Drawing.Point(195, 532);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(75, 20);
            this.lblRoll.TabIndex = 11;
            this.lblRoll.Text = "Roll #: 1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(666, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(666, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(666, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(666, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(666, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(666, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(666, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(666, 427);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(666, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "0";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 667);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRoll);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.picDie2);
            this.Controls.Add(this.picDie3);
            this.Controls.Add(this.picDie4);
            this.Controls.Add(this.picDie5);
            this.Controls.Add(this.picDie1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDie1;
        private System.Windows.Forms.PictureBox picDie5;
        private System.Windows.Forms.PictureBox picDie4;
        private System.Windows.Forms.PictureBox picDie3;
        private System.Windows.Forms.PictureBox picDie2;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

