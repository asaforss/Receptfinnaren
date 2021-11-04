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
    /// GUI klass till huvudformuläret som innehåller bland annat en ListView med maträtter 
    /// Skickar vidare till de två andra formulären via knappar. 
    /// </summary>
    public partial class HuvudForm : Form
    {
        private MaträttsHanterare maträttsHanterare = new MaträttsHanterare();
        private string filePath = "";
        private int maxAntalMin;
        
        /// <summary>
        /// Konstruktor
        /// </summary>
        public HuvudForm()
        {
            InitializeComponent();
            Initialisera();
        }
        /// <summary>
        /// Initialiserar GUI:t
        /// </summary>
        public void Initialisera()
        {
            txtTid.Text = "10000"; // Högt antal som troligen gör att alla maträtter visas.
            cmbMatTyp.Items.Add("Alla typer av rätter");
            cmbMatTyp.Items.AddRange(Enum.GetNames(typeof(MatTyp)));
            cmbMatTyp.SelectedIndex = 0;
            cmbKategori_Sott.Visible = false;
            //set the listview to view details
            lsvMat.View = View.Details;

            //Select item and subitems when selection is made
            lsvMat.FullRowSelect = true;

            //add columns
            lsvMat.Columns.Add("Id", -2, HorizontalAlignment.Left);
            lsvMat.Columns.Add("Maträtt                                                                         ", -2, HorizontalAlignment.Left);
            lsvMat.Columns.Add("Tidsåtgång", -2, HorizontalAlignment.Left);
            
            UppdateraLista();


        }


        /// <summary>
        /// Subscriber av delegat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HandleUppdateraListaEvent(object sender, EventArgs e)
        {
            UppdateraLista();


        }
        /// <summary>
        /// Metod som uppdaterar listan i ListViewn
        /// </summary>
        private void UppdateraLista()
        {
            lsvMat.Items.Clear();
            Int32.TryParse(txtTid.Text, out maxAntalMin);
            if (cmbMatTyp.SelectedIndex == 0)
                for (int i = 0; i < maträttsHanterare.Number; i++)
                {
                    Maträtt mat = maträttsHanterare.getMaträtt(i);
                    if (mat.tidsåtgång<= maxAntalMin)
                        SkallListas(mat);

                }
            if (cmbMatTyp.SelectedIndex == 1)
                for (int i = 0; i < maträttsHanterare.Number; i++)
                {
                    Maträtt mat = maträttsHanterare.getMaträtt(i);
                    if (mat is Förrätt)
                    {
                        if (cmbKategori_Sott.SelectedIndex == 0)
                        {
                            if (mat.tidsåtgång <= maxAntalMin)
                                SkallListas(mat);
                        }
                        else if (cmbKategori_Sott.SelectedIndex == 1)
                        {
                            if (((Förrätt)mat).kategori + "" == "Kött")
                            {
                                if (mat.tidsåtgång <= maxAntalMin)
                                    SkallListas(mat);
                            }
                        }
                        else if (cmbKategori_Sott.SelectedIndex == 2)
                        {
                            if (((Förrätt)mat).kategori + "" == "Fisk")
                            {
                                if (mat.tidsåtgång <= maxAntalMin)
                                    SkallListas(mat);
                            }
                        }
                        else if (cmbKategori_Sott.SelectedIndex == 3)
                        {
                            if (((Förrätt)mat).kategori + "" == "Fågel")
                            {
                                if (mat.tidsåtgång <= maxAntalMin)
                                    SkallListas(mat);
                            }
                        }
                        else
                        {
                            if (((Förrätt)mat).kategori + "" == "Vegitariskt")
                            {
                                if (mat.tidsåtgång <= maxAntalMin)
                                    SkallListas(mat);
                            }
                        }
                    }
                }
            if (cmbMatTyp.SelectedIndex == 2)
                for (int i = 0; i < maträttsHanterare.Number; i++)
                {
                    Maträtt mat = maträttsHanterare.getMaträtt(i);
                    if (mat is Huvudrätt)
                    {
                        if (cmbKategori_Sott.SelectedIndex == 0)
                        {
                            if (mat.tidsåtgång <= maxAntalMin)
                                SkallListas(mat);
                        }
                        else if (cmbKategori_Sott.SelectedIndex == 1)
                        {
                            if (((Huvudrätt)mat).kategori + "" == "Kött")
                            {
                                if (mat.tidsåtgång <= maxAntalMin)
                                    SkallListas(mat);
                            }
                        }
                        else if (cmbKategori_Sott.SelectedIndex == 2)
                        {
                            if (((Huvudrätt)mat).kategori + "" == "Fisk")
                            {
                                if (mat.tidsåtgång <= maxAntalMin)
                                    SkallListas(mat);
                            }
                        }
                        else if (cmbKategori_Sott.SelectedIndex == 3)
                        {
                            if (((Huvudrätt)mat).kategori + "" == "Fågel")
                            {
                                if (mat.tidsåtgång <= maxAntalMin)
                                    SkallListas(mat);
                            }
                        }
                        else
                        {
                            if (((Huvudrätt)mat).kategori + "" == "Vegitariskt")
                            {
                                if (mat.tidsåtgång <= maxAntalMin)
                                    SkallListas(mat);
                            }
                        }

                    }
                }
            if (cmbMatTyp.SelectedIndex == 3)
                for (int i = 0; i < maträttsHanterare.Number; i++)
                {
                    Maträtt mat = maträttsHanterare.getMaträtt(i);
                    if (mat is Efterrätt)
                    {
                        if (cmbKategori_Sott.SelectedIndex == 0)
                            if (mat.tidsåtgång <= maxAntalMin)
                                SkallListas(mat);
                        else if (cmbKategori_Sott.SelectedIndex == 1)
                            if (((Efterrätt)mat).sött)
                            {
                                if (mat.tidsåtgång <= maxAntalMin)
                                    SkallListas(mat);
                            }

                            else
                                if (!((Efterrätt)mat).sött)
                                {
                                    if (mat.tidsåtgång <= maxAntalMin)
                                        SkallListas(mat);
                                }
                    }

                }
            if (lsvMat.Items.Count > 0)
            {
                lsvMat.Focus();
                lsvMat.Items[0].Selected = true;
            }
            

        }
        /// <summary>
        /// Metod som anropas av uppdatera listan och listar just de maträtter
        /// som skall visas (beroende av inställningar i GUI)
        /// </summary>
        /// <param name="mat"></param>
        private void SkallListas(Maträtt mat)
        {
            ListViewItem item = new ListViewItem(mat.IDnr + "");
            item.SubItems.Add(mat.namn);
            item.SubItems.Add(mat.tidsåtgång + " minuter");
            lsvMat.Items.Add(item);
           
           

        }
        /// <summary>
        /// Händelse som skapar ett skapaForm fönster
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNy_Click(object sender, EventArgs e)
        {
            SkapaForm skapaForm = new SkapaForm(maträttsHanterare);
            skapaForm.Visible = true;
            skapaForm.RaiseCustomEvent += HandleUppdateraListaEvent; //prenumierar på delegaten
        }
        /// <summary>
        /// Händelse när värdet i cmbMat ändras uppdaterar bla listan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbMatTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            UppdateraLista();
            cmbKategori_Sott.Items.Clear();
            cmbKategori_Sott.Items.Add("Alla");
            cmbKategori_Sott.Visible = true;
            if (cmbMatTyp.SelectedIndex == 3)
            {
                cmbKategori_Sott.Items.Add("Sött");
                cmbKategori_Sott.Items.Add("Ej Sött");
                cmbKategori_Sott.SelectedIndex = 0;

            }
            else if (cmbMatTyp.SelectedIndex == 0)
            {
                cmbKategori_Sott.Visible = false;
            }
            else
            {
                cmbKategori_Sott.Items.AddRange(Enum.GetNames(typeof(Kategori)));
                cmbKategori_Sott.SelectedIndex = 0;

            }
        }
        /// <summary>
        /// Händelse som skapar visaformuläret MatInfoForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVisa_Click(object sender, EventArgs e)
        {
            if (lsvMat.Items.Count > 0)
            {
                int riktigaindex;
                int.TryParse(lsvMat.SelectedItems[0].SubItems[0].Text, out riktigaindex);
                MatInfoForm visaForm = new MatInfoForm(maträttsHanterare, riktigaindex);
                visaForm.Visible = true;
            }

        }

        /// <summary>
        /// Händelse som öppnar en fil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuArkivÖppna_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.dat | *.dat";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                try
                {
                    maträttsHanterare.DeSerializeList(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                {
                    
                    UppdateraLista();
                }

            }
        }
        /// <summary>
        /// Händelse som sparar till fil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuArkivSpara_Click(object sender, EventArgs e)
        {
            {
                if (filePath == String.Empty)
                    mnuArkivSparaSom_Click_1(sender, e);
                else
                {
                    try
                    {
                        maträttsHanterare.SerializeList(filePath);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                   
                }
            }

        }

        /// <summary>
        /// Händelse för spara som till fil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuArkivSparaSom_Click_1(object sender, EventArgs e)
        {
            {
                saveFileDialog1.Filter = "*.dat| *.dat";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog1.FileName;
                    try
                    {
                        maträttsHanterare.SerializeList(filePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                  
                }

            }




        }
        /// <summary>
        /// Händelse, När siffran i tid ändras uppdateras listan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTid_TextChanged(object sender, EventArgs e)
        {
            UppdateraLista();
        }
        /// <summary>
        /// Händelse som avslutar programmet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuArkivAvslutas_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Händelse för när cmbKategori_Sott ändras uppdaterar listan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbKategori_Sott_SelectedIndexChanged(object sender, EventArgs e)
        {
            UppdateraLista();
        }
    }
}
