// Åsa Forss  2012-05-18   Receptfinnaren

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data;
using DALLibrary;
using System.IO;

namespace Receptfinnaren
{
    /// <summary>
    /// Klass som hanterar en lista med maträtter mm, BL
    /// </summary>
    public class MaträttsHanterare
    {


        private List<Maträtt> matList = new List<Maträtt>();
        private DataAccess dataAccessSerialisation = new DataAccess();
        private Maträttsfabrik matFabrik = new Maträttsfabrik();

        /// <summary>
        /// Defaultkonstruktorn
        /// </summary>
        public MaträttsHanterare()
        {
        }

        // Metoder

        /// <summary>
        /// Metod som anger antalet maträtter i listan
        /// </summary>
        public int Number
        {
            get { return matList.Count; }
        }

        /// <summary>
        /// Metod som retunerar en maträtt i listan baserat på index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Maträtt getMaträtt(int index)
        {
            return matList[index];
        }

        /// <summary>
        /// Metod som adderar en maträtt till listan
        /// </summary>
        /// <param name="mat"></param>
        public void AddMaträtt(Maträtt mat)
        {
            if (mat != null)
            {
                mat.IDnr = Number;
                matList.Add(mat);
            }
        }

        /// <summary>
        /// Metod som tar bort en maträtt från listan
        /// </summary>
        /// <param name="index"></param>
        public void RemoveMaträtt(int index)
        {
            matList.RemoveAt(index);

        }
        /// <summary>
        /// Metod som tömmer listan
        /// </summary>
        public void ClearList()
        {
            matList.Clear();
        }
        /// <summary>
        /// Metod som laddar en bild
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public Image LoadImage(string filepath)
        {
            try
            {
                Image bild = Image.FromFile(filepath);
                return bild;
            }
            catch
            {
                throw;
            }

        }
        /// <summary>
        /// Metod som kallar på serialisering av matList
        /// </summary>
        /// <param name="filePath"></param>
        public void SerializeList(string filePath)
        {

            dataAccessSerialisation.binaryFileSerialize(matList, filePath);
        }
        /// <summary>
        /// Metód som kallar på deserialiserin av matList
        /// </summary>
        /// <param name="filePath"></param>
        public void DeSerializeList(string filePath)
        {
            matList = dataAccessSerialisation.binaryFileDeSerialize<List<Maträtt>>(filePath);
        }


    }
 }


