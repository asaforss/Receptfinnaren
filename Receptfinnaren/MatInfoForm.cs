// Åsa Forss  2012-05-18   Receptfinnaren

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Receptfinnaren
{
    /// <summary>
    /// Klass för GUI MatInfoForm som visar information am en maträtt
    /// </summary>
    public partial class MatInfoForm : Form
    {
        Maträtt maträtt;
        MaträttsHanterare maträttsHanterare;
        /// <summary>
        /// Konstruktorn med två parametrar
        /// </summary>
        /// <param name="maträttsHanterare"></param>
        /// <param name="index"></param>
        public MatInfoForm(MaträttsHanterare maträttsHanterare, int index)
        {
            InitializeComponent();
            this.maträttsHanterare = maträttsHanterare;
            maträtt = maträttsHanterare.getMaträtt(index);
            lblNamn.Text = maträtt.namn;
            if (maträtt is Efterrätt)
            {
                lblKategori_Sott.Text="";
                lblTyp.Text = "Efterrätt";
            }
            else if (maträtt is Huvudrätt)
            {
                lblKategori_Sott.Text = ((Huvudrätt)maträtt).kategori + "";
                lblTyp.Text = "Huvudrätt";
            }
            else
            {
                lblKategori_Sott.Text = ((Förrätt)maträtt).kategori + "";
                lblTyp.Text = "Förrätt";
            }

            lblReceptInfo.Text = maträtt.receptställe;
            
            lblTid.Text = maträtt.tidsåtgång+" minuter";
            pbMat.Image = maträtt.bild;

        }
    }
}
