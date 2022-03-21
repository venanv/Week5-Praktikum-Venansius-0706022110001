namespace WindowsFormsApp1
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
            this.addb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outputlabel = new System.Windows.Forms.Label();
            this.clearbutton = new System.Windows.Forms.Button();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.lbn = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // addb
            // 
            this.addb.Location = new System.Drawing.Point(356, 27);
            this.addb.Name = "addb";
            this.addb.Size = new System.Drawing.Size(96, 40);
            this.addb.TabIndex = 0;
            this.addb.Text = "Add";
            this.addb.UseVisualStyleBackColor = true;
            this.addb.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Koleski :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Setting";
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(409, 83);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(67, 24);
            this.cb1.TabIndex = 4;
            this.cb1.Text = "Aktif";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Output";
            // 
            // outputlabel
            // 
            this.outputlabel.AutoSize = true;
            this.outputlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.outputlabel.Location = new System.Drawing.Point(399, 424);
            this.outputlabel.Name = "outputlabel";
            this.outputlabel.Size = new System.Drawing.Size(161, 58);
            this.outputlabel.TabIndex = 6;
            this.outputlabel.Text = "HALO";
            this.outputlabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(356, 592);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(250, 40);
            this.clearbutton.TabIndex = 7;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(373, 128);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(130, 24);
            this.rb1.TabIndex = 8;
            this.rb1.TabStop = true;
            this.rb1.Text = "Warna Merah";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(373, 158);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(113, 24);
            this.rb2.TabIndex = 9;
            this.rb2.TabStop = true;
            this.rb2.Text = "Warna Biru";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(85, 31);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(243, 26);
            this.tb1.TabIndex = 10;
            this.tb1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbn
            // 
            this.lbn.FormattingEnabled = true;
            this.lbn.ItemHeight = 20;
            this.lbn.Items.AddRange(new object[] {
            "HALO",
            "APA KABAR"});
            this.lbn.Location = new System.Drawing.Point(32, 128);
            this.lbn.Name = "lbn";
            this.lbn.Size = new System.Drawing.Size(296, 504);
            this.lbn.TabIndex = 11;
            this.lbn.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 701);
            this.Controls.Add(this.lbn);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.outputlabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outputlabel;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.ListBox lbn;
    }
}

