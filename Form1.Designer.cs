namespace szegedGUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbmegallok = new System.Windows.Forms.Label();
            this.dgadatok = new System.Windows.Forms.DataGridView();
            this.jaratszam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jarat_leiras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jarat_tipus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txserach = new System.Windows.Forms.TextBox();
            this.rtbjaratok = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.Controls.Add(this.rtbjaratok);
            this.panel1.Controls.Add(this.lbmegallok);
            this.panel1.Location = new System.Drawing.Point(12, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbmegallok
            // 
            this.lbmegallok.AutoSize = true;
            this.lbmegallok.ForeColor = System.Drawing.Color.Yellow;
            this.lbmegallok.Location = new System.Drawing.Point(42, 49);
            this.lbmegallok.Name = "lbmegallok";
            this.lbmegallok.Size = new System.Drawing.Size(105, 13);
            this.lbmegallok.TabIndex = 0;
            this.lbmegallok.Text = "A megálló járatai:";
            // 
            // dgadatok
            // 
            this.dgadatok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgadatok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jaratszam,
            this.nev,
            this.jarat_leiras,
            this.jarat_tipus});
            this.dgadatok.Location = new System.Drawing.Point(12, 59);
            this.dgadatok.Name = "dgadatok";
            this.dgadatok.Size = new System.Drawing.Size(947, 273);
            this.dgadatok.TabIndex = 1;
            this.dgadatok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgadatok_CellClick);
            // 
            // jaratszam
            // 
            this.jaratszam.HeaderText = "Járat";
            this.jaratszam.Name = "jaratszam";
            this.jaratszam.ReadOnly = true;
            // 
            // nev
            // 
            this.nev.HeaderText = "Megálló neve";
            this.nev.Name = "nev";
            this.nev.ReadOnly = true;
            this.nev.Width = 250;
            // 
            // jarat_leiras
            // 
            this.jarat_leiras.HeaderText = "Végállomások";
            this.jarat_leiras.Name = "jarat_leiras";
            this.jarat_leiras.ReadOnly = true;
            this.jarat_leiras.Width = 400;
            // 
            // jarat_tipus
            // 
            this.jarat_tipus.HeaderText = "Járat típusa";
            this.jarat_tipus.Name = "jarat_tipus";
            this.jarat_tipus.ReadOnly = true;
            this.jarat_tipus.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(54, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Keresés:";
            // 
            // txserach
            // 
            this.txserach.Location = new System.Drawing.Point(116, 30);
            this.txserach.Name = "txserach";
            this.txserach.Size = new System.Drawing.Size(640, 20);
            this.txserach.TabIndex = 3;
            this.txserach.TextChanged += new System.EventHandler(this.txserach_TextChanged);
            // 
            // rtbjaratok
            // 
            this.rtbjaratok.BackColor = System.Drawing.Color.MediumOrchid;
            this.rtbjaratok.Location = new System.Drawing.Point(167, 32);
            this.rtbjaratok.Name = "rtbjaratok";
            this.rtbjaratok.Size = new System.Drawing.Size(764, 51);
            this.rtbjaratok.TabIndex = 1;
            this.rtbjaratok.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(1007, 450);
            this.Controls.Add(this.txserach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgadatok);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SzegedGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgadatok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgadatok;
        private System.Windows.Forms.DataGridViewTextBoxColumn jaratszam;
        private System.Windows.Forms.DataGridViewTextBoxColumn nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn jarat_leiras;
        private System.Windows.Forms.DataGridViewTextBoxColumn jarat_tipus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txserach;
        private System.Windows.Forms.Label lbmegallok;
        private System.Windows.Forms.RichTextBox rtbjaratok;
    }
}

