/**************************************************************************
 *                                                                        *
 *  File:        Receptionera.cs                                          *
 *  Copyright:   (c) 2021, Iftime Adrian-Dumitru                          *
 *  Description: Implements the part of software that is used to test the *
 *               receptionist class.                                      *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using System;
using System.Collections.Generic;
using System.Data;
using FunctiiDll;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProiectIP;

namespace ComponentaTesting
{
    /// <summary>
    /// Clasa de test pentru postul de receptionera
    /// </summary>
    [TestClass]
    public class ReceptioneraTesting
    {
        private string _IdRezervare = "";

        /// <summary>
        /// Metoda de test pentru inserarea unei rezervari
        /// </summary>
        [TestMethod]
        public void Test1InsertRezervareValid()
        {
            Receptionera obiect = new Receptionera();
            obiect.Internet = "1";
            obiect.Parcare = "0";
            obiect.UscatorPar = "1";
            obiect.TelefonFix = "1";
            obiect.IdCamera = "12";
            obiect.Nume = "Grigore";
            obiect.Prenume = "George";
            obiect.Cnp = "1234234123";
            obiect.DataCazare = "01/02/2003";
            obiect.DataDecazare = "03/04/2003";
            Assert.AreEqual(true, obiect.InserareRezervare(), "Test pentru inserare cu campuri valide");
        }

        /// <summary>
        /// Metoda de test pentru vizualizarea unei camere ocupate
        /// </summary>
        [TestMethod]
        public void Test2CameraOcupata()
        {
            Receptionera obiect = new Receptionera();
            string selectCommand = "SELECT OCUPAT FROM CAMERE WHERE ID_CAMERA=12";
            List<DataRow> lista;
            lista = FunctiiDll.FunctiiDll.selectFromDatabase(new System.Windows.Forms.DataGridView(), selectCommand);
            Assert.AreEqual("1", lista[0].ItemArray[0].ToString(), "Test pentru verificare daca camera a ocupata");
        }

        /// <summary>
        /// Metoda de test pentru vizualizarea unui id de rezervare
        /// </summary>
        [TestMethod]
        public void Test3AfisareIdRezervareValid()
        {
            string selectCommand = "SELECT ID_REZERVARE FROM REZERVARE";
            List<DataRow> lista;
            Receptionera obiect = new Receptionera();
            lista = FunctiiDll.FunctiiDll.selectFromDatabase(new System.Windows.Forms.DataGridView(), selectCommand);
            Assert.AreEqual(1, lista.Count, "Test pentru verificare daca a fost inserat o noua rezervare");
            _IdRezervare = lista[0].ItemArray[0].ToString();

        }

        /// <summary>
        /// Metoda de test pentru stergerea unei rezervari
        /// </summary>
        [TestMethod]
        public void Test4DeleteRezervareValid()
        {
            Receptionera obiect = new Receptionera();
            string selectCommand = "SELECT ID_REZERVARE FROM REZERVARE";
            List<DataRow> lista;
            lista = FunctiiDll.FunctiiDll.selectFromDatabase(new System.Windows.Forms.DataGridView(), selectCommand);
            Assert.IsNotNull(lista);
            _IdRezervare = lista[0].ItemArray[0].ToString();
            obiect.IdRezervare = _IdRezervare;
            Assert.AreEqual(true, obiect.StergereRezervare(), "Test pentru stergere rezervare cu id existent");
        }

        /// <summary>
        /// Metoda de test pentru afisarea unui id de rezervare invalid
        /// </summary>
        [TestMethod]
        public void Test5AfisareIdRezervareInvalid()
        {
            Receptionera obiect = new Receptionera();
            List<DataRow> lista;
            string selectCommand = "SELECT ID_REZERVARE FROM REZERVARE";
            lista = FunctiiDll.FunctiiDll.selectFromDatabase(new System.Windows.Forms.DataGridView(), selectCommand);
            Assert.AreEqual(0, lista.Count, "Test pentru verificare daca a fost stearsa rezervarea");
        }

        /// <summary>
        /// Metoda de test pentru afisarea unei camere disponibile
        /// </summary>
        [TestMethod]
        public void Test6CameraLibera()
        {
            Receptionera obiect = new Receptionera();
            string selectCommand = "SELECT OCUPAT FROM CAMERE WHERE ID_CAMERA=12";
            List<DataRow> lista;
            lista = FunctiiDll.FunctiiDll.selectFromDatabase(new System.Windows.Forms.DataGridView(), selectCommand);
            Assert.AreEqual("0", lista[0].ItemArray[0].ToString(), "Test pentru verificare daca camera a fost ocupata");
        }

        /// <summary>
        /// Metoda de test pentru inserarea unei rezervari invalide
        /// </summary>
        [TestMethod]
        public void Test7InsertRezervareInvalid()
        {
            Receptionera obiect = new Receptionera();
            obiect.Internet = "1";
            obiect.Parcare = "0";
            obiect.UscatorPar = "1";
            obiect.TelefonFix = "1";
            obiect.IdCamera = "Exact aia buna";
            obiect.Nume = "Grigore";
            obiect.Prenume = "George";
            obiect.Cnp = "1234234123A";
            obiect.DataCazare = "marti";
            obiect.DataDecazare = "miercuri";
            Assert.AreEqual(false, obiect.InserareRezervare(), "Test pentru inserare cu campuri invalide");
        }
        
        /// <summary>
        /// Metoda de test pentru stergerea unei rezervari invalide
        /// </summary>
        [TestMethod]
        public void Test8DeleteRezervareInvalid()
        {
            Receptionera obiect = new Receptionera();
            obiect.IdRezervare = "10000";
            Assert.AreEqual(false, obiect.StergereRezervare(), "Test pentru stergere rezervare cu id Inexistent");
        }
        
        
    }
}
