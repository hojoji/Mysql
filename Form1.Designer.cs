namespace Mysql
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
            this.ajandekListBox = new System.Windows.Forms.ListBox();
            this.felveszButton = new System.Windows.Forms.Button();
            this.nevTxt = new System.Windows.Forms.TextBox();
            this.boltTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reszletButton = new System.Windows.Forms.Button();
            this.torolButton = new System.Windows.Forms.Button();
            this.reszletekLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.modositBolt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.modositNev = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modositButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.szerkesztButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ajandekListBox
            // 
            this.ajandekListBox.FormattingEnabled = true;
            this.ajandekListBox.Location = new System.Drawing.Point(3, 3);
            this.ajandekListBox.Name = "ajandekListBox";
            this.ajandekListBox.Size = new System.Drawing.Size(193, 225);
            this.ajandekListBox.TabIndex = 0;
            // 
            // felveszButton
            // 
            this.felveszButton.Location = new System.Drawing.Point(48, 122);
            this.felveszButton.Name = "felveszButton";
            this.felveszButton.Size = new System.Drawing.Size(123, 40);
            this.felveszButton.TabIndex = 1;
            this.felveszButton.Text = "felvesz";
            this.felveszButton.UseVisualStyleBackColor = true;
            this.felveszButton.Click += new System.EventHandler(this.FelveszButton_Click);
            // 
            // nevTxt
            // 
            this.nevTxt.Location = new System.Drawing.Point(61, 41);
            this.nevTxt.Name = "nevTxt";
            this.nevTxt.Size = new System.Drawing.Size(110, 20);
            this.nevTxt.TabIndex = 2;
            // 
            // boltTxt
            // 
            this.boltTxt.Location = new System.Drawing.Point(61, 81);
            this.boltTxt.Name = "boltTxt";
            this.boltTxt.Size = new System.Drawing.Size(109, 20);
            this.boltTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Üzlet";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.boltTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nevTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.felveszButton);
            this.panel1.Location = new System.Drawing.Point(228, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 272);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.szerkesztButton);
            this.panel2.Controls.Add(this.torolButton);
            this.panel2.Controls.Add(this.reszletButton);
            this.panel2.Controls.Add(this.ajandekListBox);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 272);
            this.panel2.TabIndex = 7;
            // 
            // reszletButton
            // 
            this.reszletButton.Location = new System.Drawing.Point(55, 237);
            this.reszletButton.Name = "reszletButton";
            this.reszletButton.Size = new System.Drawing.Size(69, 32);
            this.reszletButton.TabIndex = 1;
            this.reszletButton.Text = "Részletek";
            this.reszletButton.UseVisualStyleBackColor = true;
            this.reszletButton.Click += new System.EventHandler(this.ReszletButton_Click);
            // 
            // torolButton
            // 
            this.torolButton.Location = new System.Drawing.Point(3, 237);
            this.torolButton.Name = "torolButton";
            this.torolButton.Size = new System.Drawing.Size(46, 32);
            this.torolButton.TabIndex = 2;
            this.torolButton.Text = "Törlés";
            this.torolButton.UseVisualStyleBackColor = true;
            this.torolButton.Click += new System.EventHandler(this.TorolButton_Click);
            // 
            // reszletekLbl
            // 
            this.reszletekLbl.AutoSize = true;
            this.reszletekLbl.Location = new System.Drawing.Point(17, 303);
            this.reszletekLbl.Name = "reszletekLbl";
            this.reszletekLbl.Size = new System.Drawing.Size(0, 13);
            this.reszletekLbl.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.modositBolt);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.modositNev);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.modositButton);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(477, 17);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(247, 266);
            this.panel3.TabIndex = 9;
            this.panel3.Visible = false;
            // 
            // modositBolt
            // 
            this.modositBolt.Location = new System.Drawing.Point(92, 113);
            this.modositBolt.Name = "modositBolt";
            this.modositBolt.Size = new System.Drawing.Size(109, 20);
            this.modositBolt.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Üzlet";
            // 
            // modositNev
            // 
            this.modositNev.Location = new System.Drawing.Point(92, 73);
            this.modositNev.Name = "modositNev";
            this.modositNev.Size = new System.Drawing.Size(110, 20);
            this.modositNev.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Név";
            // 
            // modositButton
            // 
            this.modositButton.Location = new System.Drawing.Point(79, 154);
            this.modositButton.Name = "modositButton";
            this.modositButton.Size = new System.Drawing.Size(123, 40);
            this.modositButton.TabIndex = 6;
            this.modositButton.Text = "Módosít";
            this.modositButton.UseVisualStyleBackColor = true;
            this.modositButton.Click += new System.EventHandler(this.ModositButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Módosítás";
            // 
            // szerkesztButton
            // 
            this.szerkesztButton.Location = new System.Drawing.Point(130, 237);
            this.szerkesztButton.Name = "szerkesztButton";
            this.szerkesztButton.Size = new System.Drawing.Size(65, 32);
            this.szerkesztButton.TabIndex = 3;
            this.szerkesztButton.Text = "Szerkeszt";
            this.szerkesztButton.UseVisualStyleBackColor = true;
            this.szerkesztButton.Click += new System.EventHandler(this.SzerkesztButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.reszletekLbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ajandekListBox;
        private System.Windows.Forms.Button felveszButton;
        private System.Windows.Forms.TextBox nevTxt;
        private System.Windows.Forms.TextBox boltTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button torolButton;
        private System.Windows.Forms.Button reszletButton;
        private System.Windows.Forms.Label reszletekLbl;
        private System.Windows.Forms.Button szerkesztButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox modositBolt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modositNev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button modositButton;
    }
}

