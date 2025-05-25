namespace EtabsAPI
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
            this.start = new System.Windows.Forms.Button();
            this.rebarStatBox = new EtabsAPI.UI.CustomTools.CComboBox();
            this.cLabel1 = new EtabsAPI.UI.CustomTools.CLabel();
            this.concreteStatBox = new EtabsAPI.UI.CustomTools.CComboBox();
            this.concreteStat = new EtabsAPI.UI.CustomTools.CLabel();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(1146, 780);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(312, 77);
            this.start.TabIndex = 4;
            this.start.Text = "BAŞLAT";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // rebarStatBox
            // 
            this.rebarStatBox.FormattingEnabled = true;
            this.rebarStatBox.Items.AddRange(new object[] {
            "S420"});
            this.rebarStatBox.Location = new System.Drawing.Point(304, 115);
            this.rebarStatBox.Name = "rebarStatBox";
            this.rebarStatBox.Size = new System.Drawing.Size(121, 33);
            this.rebarStatBox.TabIndex = 3;
            // 
            // cLabel1
            // 
            this.cLabel1.AutoSize = true;
            this.cLabel1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.cLabel1.ForeColor = System.Drawing.Color.DarkBlue;
            this.cLabel1.Location = new System.Drawing.Point(44, 116);
            this.cLabel1.Name = "cLabel1";
            this.cLabel1.Size = new System.Drawing.Size(243, 32);
            this.cLabel1.TabIndex = 2;
            this.cLabel1.Text = "Betonarme Çeliği";
            // 
            // concreteStatBox
            // 
            this.concreteStatBox.FormattingEnabled = true;
            this.concreteStatBox.Items.AddRange(new object[] {
            "C30/37"});
            this.concreteStatBox.Location = new System.Drawing.Point(218, 48);
            this.concreteStatBox.Name = "concreteStatBox";
            this.concreteStatBox.Size = new System.Drawing.Size(121, 33);
            this.concreteStatBox.TabIndex = 1;
            // 
            // concreteStat
            // 
            this.concreteStat.AutoSize = true;
            this.concreteStat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.concreteStat.ForeColor = System.Drawing.Color.DarkBlue;
            this.concreteStat.Location = new System.Drawing.Point(44, 49);
            this.concreteStat.Name = "concreteStat";
            this.concreteStat.Size = new System.Drawing.Size(168, 32);
            this.concreteStat.TabIndex = 0;
            this.concreteStat.Text = "Beton Sınıfı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 929);
            this.Controls.Add(this.start);
            this.Controls.Add(this.rebarStatBox);
            this.Controls.Add(this.cLabel1);
            this.Controls.Add(this.concreteStatBox);
            this.Controls.Add(this.concreteStat);
            this.MinimumSize = new System.Drawing.Size(1600, 1000);
            this.Name = "Form1";
            this.Text = "TS500/TBDY2018";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.CustomTools.CLabel concreteStat;
        private UI.CustomTools.CComboBox concreteStatBox;
        private UI.CustomTools.CComboBox rebarStatBox;
        private UI.CustomTools.CLabel cLabel1;
        private System.Windows.Forms.Button start;
    }
}

