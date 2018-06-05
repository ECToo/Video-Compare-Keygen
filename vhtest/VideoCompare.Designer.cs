namespace vhtest
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tci = new System.Windows.Forms.TextBox();
            this.tSerial = new System.Windows.Forms.TextBox();
            this.rp = new System.Windows.Forms.RadioButton();
            this.re = new System.Windows.Forms.RadioButton();
            this.rh = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.c106 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tci
            // 
            this.tci.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tci.ForeColor = System.Drawing.Color.DarkGreen;
            this.tci.Location = new System.Drawing.Point(103, 13);
            this.tci.Name = "tci";
            this.tci.ReadOnly = true;
            this.tci.Size = new System.Drawing.Size(194, 20);
            this.tci.TabIndex = 1;
            this.tci.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tSerial
            // 
            this.tSerial.BackColor = System.Drawing.SystemColors.Info;
            this.tSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSerial.ForeColor = System.Drawing.Color.DarkRed;
            this.tSerial.Location = new System.Drawing.Point(103, 68);
            this.tSerial.Name = "tSerial";
            this.tSerial.Size = new System.Drawing.Size(194, 20);
            this.tSerial.TabIndex = 4;
            this.tSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rp
            // 
            this.rp.AutoSize = true;
            this.rp.Checked = true;
            this.rp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rp.ForeColor = System.Drawing.Color.Maroon;
            this.rp.Location = new System.Drawing.Point(103, 42);
            this.rp.Name = "rp";
            this.rp.Size = new System.Drawing.Size(44, 17);
            this.rp.TabIndex = 5;
            this.rp.TabStop = true;
            this.rp.Text = "Pro";
            this.rp.UseVisualStyleBackColor = true;
            this.rp.CheckedChanged += new System.EventHandler(this.rh_CheckedChanged);
            // 
            // re
            // 
            this.re.AutoSize = true;
            this.re.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.re.ForeColor = System.Drawing.Color.Maroon;
            this.re.Location = new System.Drawing.Point(172, 42);
            this.re.Name = "re";
            this.re.Size = new System.Drawing.Size(61, 17);
            this.re.TabIndex = 6;
            this.re.Text = "Expert";
            this.re.UseVisualStyleBackColor = true;
            this.re.CheckedChanged += new System.EventHandler(this.rh_CheckedChanged);
            // 
            // rh
            // 
            this.rh.AutoSize = true;
            this.rh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rh.ForeColor = System.Drawing.Color.Maroon;
            this.rh.Location = new System.Drawing.Point(244, 42);
            this.rh.Name = "rh";
            this.rh.Size = new System.Drawing.Size(57, 17);
            this.rh.TabIndex = 7;
            this.rh.Text = "Home";
            this.rh.UseVisualStyleBackColor = true;
            this.rh.CheckedChanged += new System.EventHandler(this.rh_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Computer ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Version :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Serial :";
            // 
            // Generate
            // 
            this.Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.ForeColor = System.Drawing.Color.DarkMagenta;
            this.Generate.Location = new System.Drawing.Point(222, 94);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 11;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.exit.Location = new System.Drawing.Point(9, 94);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 12;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // c106
            // 
            this.c106.AutoSize = true;
            this.c106.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c106.ForeColor = System.Drawing.Color.Indigo;
            this.c106.Location = new System.Drawing.Point(103, 98);
            this.c106.Name = "c106";
            this.c106.Size = new System.Drawing.Size(102, 17);
            this.c106.TabIndex = 13;
            this.c106.Text = "v1.06 > Todo";
            this.c106.UseVisualStyleBackColor = true;
            this.c106.CheckedChanged += new System.EventHandler(this.c106_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 122);
            this.Controls.Add(this.c106);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rh);
            this.Controls.Add(this.re);
            this.Controls.Add(this.rp);
            this.Controls.Add(this.tSerial);
            this.Controls.Add(this.tci);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(325, 161);
            this.MinimumSize = new System.Drawing.Size(325, 161);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "V.Compare Keygen v1.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tci;
        private System.Windows.Forms.TextBox tSerial;
        private System.Windows.Forms.RadioButton rp;
        private System.Windows.Forms.RadioButton re;
        private System.Windows.Forms.RadioButton rh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.CheckBox c106;
    }
}

