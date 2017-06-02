namespace Exam2Question1MessageDisplay
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbQuots = new System.Windows.Forms.ComboBox();
            this.lblQuotes = new System.Windows.Forms.Label();
            this.menOne = new System.Windows.Forms.MenuStrip();
            this.subMenuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.formatSubMenuItemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.formatSubMenuItemColor = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDispayQuotes = new System.Windows.Forms.Label();
            this.btnAddQuote = new System.Windows.Forms.Button();
            this.menOne.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(336, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(183, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "The Favorite Sayings and\\or Quotes ";
            // 
            // cmbQuots
            // 
            this.cmbQuots.FormattingEnabled = true;
            this.cmbQuots.Items.AddRange(new object[] {
            "Let the future tell the truth......",
            "You have to learn the rules...",
            "Some men just....",
            "I am become death..."});
            this.cmbQuots.Location = new System.Drawing.Point(270, 72);
            this.cmbQuots.Name = "cmbQuots";
            this.cmbQuots.Size = new System.Drawing.Size(479, 21);
            this.cmbQuots.TabIndex = 5;
            this.cmbQuots.SelectedIndexChanged += new System.EventHandler(this.cmbQuots_SelectedIndexChanged);
            this.cmbQuots.SelectionChangeCommitted += new System.EventHandler(this.cmbQuots_SelectionChangeCommitted);
            this.cmbQuots.TextUpdate += new System.EventHandler(this.cmbQuots_TextUpdate);
            // 
            // lblQuotes
            // 
            this.lblQuotes.AutoSize = true;
            this.lblQuotes.Location = new System.Drawing.Point(210, 80);
            this.lblQuotes.Name = "lblQuotes";
            this.lblQuotes.Size = new System.Drawing.Size(41, 13);
            this.lblQuotes.TabIndex = 6;
            this.lblQuotes.Text = "Quotes";
            // 
            // menOne
            // 
            this.menOne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenuFormat,
            this.subMenuHelp});
            this.menOne.Location = new System.Drawing.Point(0, 0);
            this.menOne.Name = "menOne";
            this.menOne.Size = new System.Drawing.Size(876, 24);
            this.menOne.TabIndex = 7;
            this.menOne.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // subMenuFormat
            // 
            this.subMenuFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatSubMenuItemFont,
            this.formatSubMenuItemColor});
            this.subMenuFormat.Name = "subMenuFormat";
            this.subMenuFormat.Size = new System.Drawing.Size(57, 20);
            this.subMenuFormat.Text = "&Format";
            // 
            // formatSubMenuItemFont
            // 
            this.formatSubMenuItemFont.Name = "formatSubMenuItemFont";
            this.formatSubMenuItemFont.Size = new System.Drawing.Size(152, 22);
            this.formatSubMenuItemFont.Text = "Font";
            this.formatSubMenuItemFont.Click += new System.EventHandler(this.formatSubMenuItemFont_Click);
            // 
            // formatSubMenuItemColor
            // 
            this.formatSubMenuItemColor.Name = "formatSubMenuItemColor";
            this.formatSubMenuItemColor.Size = new System.Drawing.Size(152, 22);
            this.formatSubMenuItemColor.Text = "Color";
            this.formatSubMenuItemColor.Click += new System.EventHandler(this.formatSubMenuItemColor_Click);
            // 
            // subMenuHelp
            // 
            this.subMenuHelp.Name = "subMenuHelp";
            this.subMenuHelp.Size = new System.Drawing.Size(44, 20);
            this.subMenuHelp.Text = "&Help";
            // 
            // lblDispayQuotes
            // 
            this.lblDispayQuotes.AutoSize = true;
            this.lblDispayQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDispayQuotes.Location = new System.Drawing.Point(178, 348);
            this.lblDispayQuotes.Name = "lblDispayQuotes";
            this.lblDispayQuotes.Size = new System.Drawing.Size(571, 18);
            this.lblDispayQuotes.TabIndex = 8;
            this.lblDispayQuotes.Text = "Please Click on the drop down to see my favortie quotes or you may eneter your ow" +
    "n ";
            this.lblDispayQuotes.TextChanged += new System.EventHandler(this.lblDispayQuotes_TextChanged);
            // 
            // btnAddQuote
            // 
            this.btnAddQuote.Location = new System.Drawing.Point(316, 543);
            this.btnAddQuote.Name = "btnAddQuote";
            this.btnAddQuote.Size = new System.Drawing.Size(237, 23);
            this.btnAddQuote.TabIndex = 9;
            this.btnAddQuote.Text = "Add Quote";
            this.btnAddQuote.UseVisualStyleBackColor = true;
            this.btnAddQuote.Click += new System.EventHandler(this.btnAddQuote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 792);
            this.Controls.Add(this.btnAddQuote);
            this.Controls.Add(this.lblDispayQuotes);
            this.Controls.Add(this.lblQuotes);
            this.Controls.Add(this.cmbQuots);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menOne);
            this.MainMenuStrip = this.menOne;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menOne.ResumeLayout(false);
            this.menOne.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbQuots;
        private System.Windows.Forms.Label lblQuotes;
        private System.Windows.Forms.MenuStrip menOne;
        private System.Windows.Forms.ToolStripMenuItem subMenuFormat;
        private System.Windows.Forms.ToolStripMenuItem subMenuHelp;
        private System.Windows.Forms.ToolStripMenuItem formatSubMenuItemFont;
        private System.Windows.Forms.ToolStripMenuItem formatSubMenuItemColor;
        private System.Windows.Forms.Label lblDispayQuotes;
        private System.Windows.Forms.Button btnAddQuote;
    }
}

