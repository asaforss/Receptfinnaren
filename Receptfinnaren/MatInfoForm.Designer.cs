namespace Receptfinnaren
{
    partial class MatInfoForm
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
            this.pbMat = new System.Windows.Forms.PictureBox();
            this.lblNamn = new System.Windows.Forms.Label();
            this.lblTid = new System.Windows.Forms.Label();
            this.lblReceptInfo = new System.Windows.Forms.Label();
            this.lblTyp = new System.Windows.Forms.Label();
            this.lblKategori_Sott = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMat)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMat
            // 
            this.pbMat.Location = new System.Drawing.Point(36, 40);
            this.pbMat.Name = "pbMat";
            this.pbMat.Size = new System.Drawing.Size(226, 232);
            this.pbMat.TabIndex = 0;
            this.pbMat.TabStop = false;
            // 
            // lblNamn
            // 
            this.lblNamn.AutoSize = true;
            this.lblNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamn.Location = new System.Drawing.Point(329, 40);
            this.lblNamn.Name = "lblNamn";
            this.lblNamn.Size = new System.Drawing.Size(90, 25);
            this.lblNamn.TabIndex = 1;
            this.lblNamn.Text = "lblNamn";
            // 
            // lblTid
            // 
            this.lblTid.AutoSize = true;
            this.lblTid.Location = new System.Drawing.Point(334, 91);
            this.lblTid.Name = "lblTid";
            this.lblTid.Size = new System.Drawing.Size(32, 13);
            this.lblTid.TabIndex = 2;
            this.lblTid.Text = "lblTid";
            // 
            // lblReceptInfo
            // 
            this.lblReceptInfo.AutoSize = true;
            this.lblReceptInfo.Location = new System.Drawing.Point(334, 126);
            this.lblReceptInfo.Name = "lblReceptInfo";
            this.lblReceptInfo.Size = new System.Drawing.Size(69, 13);
            this.lblReceptInfo.TabIndex = 3;
            this.lblReceptInfo.Text = "lblReceptinfo";
            // 
            // lblTyp
            // 
            this.lblTyp.AutoSize = true;
            this.lblTyp.Location = new System.Drawing.Point(337, 166);
            this.lblTyp.Name = "lblTyp";
            this.lblTyp.Size = new System.Drawing.Size(35, 13);
            this.lblTyp.TabIndex = 4;
            this.lblTyp.Text = "lblTyp";
            // 
            // lblKategori_Sott
            // 
            this.lblKategori_Sott.AutoSize = true;
            this.lblKategori_Sott.Location = new System.Drawing.Point(337, 208);
            this.lblKategori_Sott.Name = "lblKategori_Sott";
            this.lblKategori_Sott.Size = new System.Drawing.Size(81, 13);
            this.lblKategori_Sott.TabIndex = 5;
            this.lblKategori_Sott.Text = "lblKategori_Sott";
            // 
            // MatInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 307);
            this.Controls.Add(this.lblKategori_Sott);
            this.Controls.Add(this.lblTyp);
            this.Controls.Add(this.lblReceptInfo);
            this.Controls.Add(this.lblTid);
            this.Controls.Add(this.lblNamn);
            this.Controls.Add(this.pbMat);
            this.Name = "MatInfoForm";
            this.Text = "Maträtts Information";
            ((System.ComponentModel.ISupportInitialize)(this.pbMat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMat;
        private System.Windows.Forms.Label lblNamn;
        private System.Windows.Forms.Label lblTid;
        private System.Windows.Forms.Label lblReceptInfo;
        private System.Windows.Forms.Label lblTyp;
        private System.Windows.Forms.Label lblKategori_Sott;
    }
}