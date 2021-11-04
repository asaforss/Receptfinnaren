// Åsa Forss  2012-05-18   Receptfinnaren

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UtilityLibrary;



namespace Receptfinnaren
{
    /// <summary>
    /// Klass för GUI Skapa form som tar input och 
    /// anropar matträttsfabriken som skapar maträtt. 
    /// </summary>
    public partial class SkapaForm : Form
    {
        private MaträttsHanterare maträttsHanterare;
        private Imageclass imageclass = new Imageclass();
        private Maträttsfabrik maträttsfabriken= new Maträttsfabrik();
        public event EventHandler RaiseCustomEvent;
        
        
        /// <summary>
        /// Konstruktor med en parameter
        /// </summary>
        /// <param name="maträttsHanterare"></param>
        public SkapaForm(MaträttsHanterare maträttsHanterare)
        {
            
            InitializeComponent();
            Initialisera();
            this.maträttsHanterare = maträttsHanterare;
        }
        /// <summary>
        /// Metod som initialiserar formen
        /// </summary>
        public void Initialisera()
        {
            
            cmbMatTyp.Items.AddRange(Enum.GetNames(typeof(MatTyp)));
            cmbKategori_Sott.Items.AddRange(Enum.GetNames(typeof(Kategori)));
            cmbMatTyp.SelectedIndex = 0;
            cmbKategori_Sott.SelectedIndex = 0;
             
        }


        /// <summary>
        /// Händelse som laddar bild
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLaddaBild_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "*.dat | *.dat";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                try
                {
                    System.Drawing.Image fullsizeImage = maträttsHanterare.LoadImage(filePath);
                    Size size = new Size(226,232);
                    pbMat.Image = imageclass.resizeImage(fullsizeImage, size);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                {

                }
            }
        }
        /// <summary>
        /// Händelse som arrangerar cmbKategori_Sotts värden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMatTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKategori_Sott.Items.Clear();
            cmbKategori_Sott.Visible = true;
            if (cmbMatTyp.SelectedIndex == 2)
            {
                cmbKategori_Sott.Items.Add("Sött");
                cmbKategori_Sott.Items.Add("Ej Sött");
                cmbKategori_Sott.SelectedIndex = 0;
            }
            else
            {
                cmbKategori_Sott.Items.AddRange(Enum.GetNames(typeof(Kategori)));
                cmbKategori_Sott.SelectedIndex = 0;

            }
        }
        /// <summary>
        /// Händelse som skapar en maträtt och lägger in den i listan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLaggIn_Click(object sender, EventArgs e)
        {
            string namn = txtNamn.Text;
            int tid=0;
            Int32.TryParse(txtTid.Text,out tid);
            string ställe=txtStälle.Text;
            System.Drawing.Image bild =pbMat.Image;
           
            MatTyp mattyp = (MatTyp)cmbMatTyp.SelectedIndex;
            bool sött = false;
            Maträtt maträtt;
            if (mattyp == MatTyp.Efterrätt)
            {
                if (cmbKategori_Sott.SelectedIndex==0)
                    sött =true;
                maträtt=maträttsfabriken.createMat(namn, tid, ställe, bild, sött);
            }
            else
            {
                Kategori kategori =(Kategori)cmbKategori_Sott.SelectedIndex;
                maträtt=maträttsfabriken.createMat(namn, tid, ställe,  bild, kategori,mattyp);
            }
            maträttsHanterare.AddMaträtt(maträtt);
            RaiseCustomEvent(this, e); // delegaten
           
        }

      

    }
}
  
