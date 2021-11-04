namespace Receptfinnaren
{
    partial class SkapaForm
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
            this.btnLaddaBild = new System.Windows.Forms.Button();
            this.pbMat = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNamn = new System.Windows.Forms.TextBox();
            this.txtTid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMatTyp = new System.Windows.Forms.ComboBox();
            this.cmbKategori_Sott = new System.Windows.Forms.ComboBox();
            this.btnLaggIn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStälle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLaddaBild
            // 
            this.btnLaddaBild.Location = new System.Drawing.Point(30, 39);
            this.btnLaddaBild.Name = "btnLaddaBild";
            this.btnLaddaBild.Size = new System.Drawing.Size(75, 23);
            this.btnLaddaBild.TabIndex = 0;
            this.btnLaddaBild.Text = "Ladda Bild";
            this.btnLaddaBild.UseVisualStyleBackColor = true;
            this.btnLaddaBild.Click += new System.EventHandler(this.btnLaddaBild_Click);
            // 
            // pbMat
            // 
            this.pbMat.Location = new System.Drawing.Point(387, 39);
            this.pbMat.Name = "pbMat";
            this.pbMat.Size = new System.Drawing.Size(226, 232);
            this.pbMat.TabIndex = 2;
            this.pbMat.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Namn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tidsåtgång:";
            // 
            // txtNamn
            // 
            this.txtNamn.Location = new System.Drawing.Point(108, 89);
            this.txtNamn.Name = "txtNamn";
            this.txtNamn.Size = new System.Drawing.Size(249, 20);
            this.txtNamn.TabIndex = 5;
            // 
            // txtTid
            // 
            this.txtTid.Location = new System.Drawing.Point(108, 138);
            this.txtTid.Name = "txtTid";
            this.txtTid.Size = new System.Drawing.Size(56, 20);
            this.txtTid.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "minuter";
            // 
            // cmbMatTyp
            // 
            this.cmbMatTyp.FormattingEnabled = true;
            this.cmbMatTyp.Location = new System.Drawing.Point(108, 195);
            this.cmbMatTyp.Name = "cmbMatTyp";
            this.cmbMatTyp.Size = new System.Drawing.Size(121, 21);
            this.cmbMatTyp.TabIndex = 8;
            this.cmbMatTyp.SelectedIndexChanged += new System.EventHandler(this.cmbMatTyp_SelectedIndexChanged);
            // 
            // cmbKategori_Sott
            // 
            this.cmbKategori_Sott.FormattingEnabled = true;
            this.cmbKategori_Sott.Location = new System.Drawing.Point(108, 249);
            this.cmbKategori_Sott.Name = "cmbKategori_Sott";
            this.cmbKategori_Sott.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori_Sott.TabIndex = 9;
            // 
            // btnLaggIn
            // 
            this.btnLaggIn.Location = new System.Drawing.Point(30, 353);
            this.btnLaggIn.Name = "btnLaggIn";
            this.btnLaggIn.Size = new System.Drawing.Size(75, 23);
            this.btnLaggIn.TabIndex = 10;
            this.btnLaggIn.Text = "Lägg in";
            this.btnLaggIn.UseVisualStyleBackColor = true;
            this.btnLaggIn.Click += new System.EventHandler(this.btnLaggIn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Var ?";
            // 
            // txtStälle
            // 
            this.txtStälle.Location = new System.Drawing.Point(108, 300);
            this.txtStälle.Name = "txtStälle";
            this.txtStälle.Size = new System.Drawing.Size(505, 20);
            this.txtStälle.TabIndex = 12;
            // 
            // SkapaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 388);
            this.Controls.Add(this.txtStälle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLaggIn);
            this.Controls.Add(this.cmbKategori_Sott);
            this.Controls.Add(this.cmbMatTyp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTid);
            this.Controls.Add(this.txtNamn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbMat);
            this.Controls.Add(this.btnLaddaBild);
            this.Name = "SkapaForm";
            this.Text = "Registrera maträtt";
            ((System.ComponentModel.ISupportInitialize)(this.pbMat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaddaBild;
        private System.Windows.Forms.PictureBox pbMat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNamn;
        private System.Windows.Forms.TextBox txtTid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMatTyp;
        private System.Windows.Forms.ComboBox cmbKategori_Sott;
        private System.Windows.Forms.Button btnLaggIn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStälle;
    }
}