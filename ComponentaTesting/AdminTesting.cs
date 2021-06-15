/**************************************************************************
 *                                                                        *
 *  File:        Receptionera.cs                                          *
 *  Copyright:   (c) 2021, Iftime Adrian-Dumitru                          *
 *  Description: Implements the part of software that is used to test the *
 *               Admin class.                                             *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProiectIP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentaTesting
{
    /// <summary>
    /// Clasa de test pentru postul de administrator
    /// </summary>
    [TestClass]
    public class AdminTesting
    {
        string _IdFrigider="";
        string _IdCamera = "";

        /// <summary>
        /// Metoda de test pentru inserarea unei camere
        /// </summary>
        [TestMethod]
        public void Test0InsertCameraValid()
        {
            Admin obiect = new Admin();
            obiect.IdMinibar = "20";
            obiect.tipCamera = "Single";
            obiect.pretCamera = "150";
            Assert.AreEqual(true, obiect.InserareCamere(), "Test pentru inserare cu campuri valide");
        }

        /// <summary>
        /// Metoda de test pentru afisarea unui mini-bar ocupat
        /// </summary>
        [TestMethod]
        public void Test1FrigiderOcupat()
        {
            Admin obiect = new Admin();
            string selectCommand = "SELECT OCUPAT FROM CONTINUT_MINIBAR WHERE ID_MINIBAR=20";
            List<DataRow> lista;
            lista = FunctiiDll.FunctiiDll.selectFromDatabase(new System.Windows.Forms.DataGridView(), selectCommand);
            Assert.AreEqual("1", lista[0].ItemArray[0].ToString(), "Test pentru verificare daca frigiderul e luat");
        }

        /// <summary>
        /// Metoda de test pentru afisarea unei camere
        /// </summary>
        [TestMethod]
        public void Test2AfisareIdCameraValid()
        {
            string selectCommand = "SELECT ID_CAMERA FROM CAMERE WHERE ID_MINIBAR=20";
            List<DataRow> lista;
            Admin obiect = new Admin();
            lista = FunctiiDll.FunctiiDll.selectFromDatabase(new System.Windows.Forms.DataGridView(), selectCommand);
            Assert.AreEqual(1, lista.Count, "Test pentru verificare daca a fost inserat o noua camera");

        }

        /// <summary>
        /// Metoda de test pentru stergerea unei camere
        /// </summary>
        [TestMethod]
        public void Test3DeleteCameraValid()
        {
            Admin obiect = new Admin();
            string selectCommand = "SELECT ID_CAMERA FROM CAMERE WHERE ID_MINIBAR=20";
            List<DataRow> lista;
            lista = FunctiiDll.FunctiiDll.selectFromDatabase(new System.Windows.Forms.DataGridView(), selectCommand);
            _IdCamera = lista[0].ItemArray[0].ToString();
            obiect.IdCamera =_IdCamera;
            Assert.AreEqual(true, obiect.StergeCamere(), "Test pentru stergere camera cu id existent");
        }

        /// <summary>
        /// Metoda de test pentru afisarea unei camere invalide
        /// </summary>
        [TestMethod]
        public void Test4AfisareIdCameraInvalid()
        {
            Admin obiect = new Admin();
            List<DataRow> lista;
            string selectCommand = "SELECT ID_CAMERA FROM CAMERE WHERE ID_MINIBAR=20";
            lista = FunctiiDll.FunctiiDll.selectFromDatabase(new System.Windows.Forms.DataGridView(), selectCommand);
            Assert.AreEqual(0, lista.Count, "Test pentru verificare daca a fost stearsa camera");
        }

        /// <summary>
        /// Metoda de test pentru afisarea unei camere disponibile
        /// </summary>
        [TestMethod]
        public void Test5CameraLibera()
        {
            Receptionera obiect = new Receptionera();
            string selectCommand = "SELECT OCUPAT FROM CONTINUT_MINIBAR WHERE ID_MINIBAR=20";
            List<DataRow> lista;
            lista = FunctiiDll.FunctiiDll.selectFromDatabase(new System.Windows.Forms.DataGridView(), selectCommand);
            Assert.AreEqual("0", lista[0].ItemArray[0].ToString(), "Test pentru verificare daca frigiderul a fost eliberat");
        }

        /// <summary>
        /// Metoda de test pentru inserarea unui mini-bar invalid
        /// </summary>
        [TestMethod]
        public void Test6InsertFrigiderInvalid()
        {
            Admin obiect = new Admin();
            obiect.IdMinibar = "Aurel";
            obiect.tipCamera = "Single";
            obiect.pretCamera = "CatMaiMult";
            Assert.AreEqual(false, obiect.InserareCamere(), "Test pentru inserare cu campuri invalide");
        }

        /// <summary>
        /// Metoda de test pentru stergerea unei camere invalide
        /// </summary>
        [TestMethod]
        public void Test7DeleteCameraInvalid()
        {
            Admin obiect = new Admin();
            obiect.IdCamera = "10000";
            Assert.AreEqual(false, obiect.StergeCamere(), "Test pentru stergere camera cu id inexistent");
        }

    }
}
