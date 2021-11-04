namespace Receptfinnaren
{
    partial class HuvudForm
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
            this.cmbMatTyp = new System.Windows.Forms.ComboBox();
            this.cmbKategori_Sott = new System.Windows.Forms.ComboBox();
            this.lsvMat = new System.Windows.Forms.ListView();
            this.btnNy = new System.Windows.Forms.Button();
            this.btnVisa = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArkivAvsluta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArkivÖppna = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArkivSpara = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArkivSparaSom = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArkivAvslutas = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtTid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbMatTyp
            // 
            this.cmbMatTyp.FormattingEnabled = true;
            this.cmbMatTyp.Location = new System.Drawing.Point(35, 38);
            this.cmbMatTyp.Name = "cmbMatTyp";
            this.cmbMatTyp.Size = new System.Drawing.Size(121, 21);
            this.cmbMatTyp.TabIndex = 0;
            this.cmbMatTyp.SelectedIndexChanged += new System.EventHandler(this.cmbMatTyp_SelectedIndexChanged);
            // 
            // cmbKategori_Sott
            // 
            this.cmbKategori_Sott.FormattingEnabled = true;
            this.cmbKategori_Sott.Location = new System.Drawing.Point(287, 38);
            this.cmbKategori_Sott.Name = "cmbKategori_Sott";
            this.cmbKategori_Sott.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori_Sott.TabIndex = 1;
            this.cmbKategori_Sott.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_Sott_SelectedIndexChanged);
            // 
            // lsvMat
            // 
            this.lsvMat.Location = new System.Drawing.Point(35, 107);
            this.lsvMat.Name = "lsvMat";
            this.lsvMat.Size = new System.Drawing.Size(403, 410);
            this.lsvMat.TabIndex = 2;
            this.lsvMat.UseCompatibleStateImageBehavior = false;
            // 
            // btnNy
            // 
            this.btnNy.Location = new System.Drawing.Point(35, 550);
            this.btnNy.Name = "btnNy";
            this.btnNy.Size = new System.Drawing.Size(75, 23);
            this.btnNy.TabIndex = 5;
            this.btnNy.Text = "Ny";
            this.btnNy.UseVisualStyleBackColor = true;
            this.btnNy.Click += new System.EventHandler(this.btnNy_Click);
            // 
            // btnVisa
            // 
            this.btnVisa.Location = new System.Drawing.Point(333, 550);
            this.btnVisa.Name = "btnVisa";
            this.btnVisa.Size = new System.Drawing.Size(75, 23);
            this.btnVisa.TabIndex = 6;
            this.btnVisa.Text = "Visa";
            this.btnVisa.UseVisualStyleBackColor = true;
            this.btnVisa.Click += new System.EventHandler(this.btnVisa_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArkivAvsluta});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(472, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuArkivAvsluta
            // 
            this.mnuArkivAvsluta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArkivÖppna,
            this.mnuArkivSpara,
            this.mnuArkivSparaSom,
            this.mnuArkivAvslutas});
            this.mnuArkivAvsluta.Name = "mnuArkivAvsluta";
            this.mnuArkivAvsluta.Size = new System.Drawing.Size(46, 20);
            this.mnuArkivAvsluta.Text = "Arkiv";
            // 
            // mnuArkivÖppna
            // 
            this.mnuArkivÖppna.Name = "mnuArkivÖppna";
            this.mnuArkivÖppna.Size = new System.Drawing.Size(152, 22);
            this.mnuArkivÖppna.Text = "Öppna";
            this.mnuArkivÖppna.Click += new System.EventHandler(this.mnuArkivÖppna_Click);
            // 
            // mnuArkivSpara
            // 
            this.mnuArkivSpara.Name = "mnuArkivSpara";
            this.mnuArkivSpara.Size = new System.Drawing.Size(152, 22);
            this.mnuArkivSpara.Text = "Spara";
            this.mnuArkivSpara.Click += new System.EventHandler(this.mnuArkivSpara_Click);
            // 
            // mnuArkivSparaSom
            // 
            this.mnuArkivSparaSom.Name = "mnuArkivSparaSom";
            this.mnuArkivSparaSom.Size = new System.Drawing.Size(152, 22);
            this.mnuArkivSparaSom.Text = "Spara som";
            this.mnuArkivSparaSom.Click += new System.EventHandler(this.mnuArkivSparaSom_Click_1);
            // 
            // mnuArkivAvslutas
            // 
            this.mnuArkivAvslutas.Name = "mnuArkivAvslutas";
            this.mnuArkivAvslutas.Size = new System.Drawing.Size(152, 22);
            this.mnuArkivAvslutas.Text = "Avsluta";
            this.mnuArkivAvslutas.Click += new System.EventHandler(this.mnuArkivAvslutas_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(155, 92);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtTid
            // 
            this.txtTid.Location = new System.Drawing.Point(143, 76);
            this.txtTid.Name = "txtTid";
            this.txtTid.Size = new System.Drawing.Size(73, 20);
            this.txtTid.TabIndex = 9;
            this.txtTid.TextChanged += new System.EventHandler(this.txtTid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Max antal minuter:";
            // 
            // HuvudForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 598);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTid);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnVisa);
            this.Controls.Add(this.btnNy);
            this.Controls.Add(this.lsvMat);
            this.Controls.Add(this.cmbKategori_Sott);
            this.Controls.Add(this.cmbMatTyp);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HuvudForm";
            this.Text = "Receptfinnaren";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMatTyp;
        private System.Windows.Forms.ComboBox cmbKategori_Sott;
        private System.Windows.Forms.ListView lsvMat;
        private System.Windows.Forms.Button btnNy;
        private System.Windows.Forms.Button btnVisa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem mnuArkivAvsluta;
        private System.Windows.Forms.ToolStripMenuItem mnuArkivÖppna;
        private System.Windows.Forms.ToolStripMenuItem mnuArkivSpara;
        private System.Windows.Forms.ToolStripMenuItem mnuArkivSparaSom;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtTid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuArkivAvslutas;
    }
}

