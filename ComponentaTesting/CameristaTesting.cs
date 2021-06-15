/**************************************************************************
 *                                                                        *
 *  File:        Receptionera.cs                                          *
 *  Copyright:   (c) 2021, Iftime Adrian-Dumitru                          *
 *  Description: Implements the part of software that is used to test the *
 *               main class.                                              *
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
    /// Clasa de test pentru postul de camerista
    /// </summary>
    [TestClass]
    public class CameristaTesting
    {
        /// <summary>
        /// Metoda de test pentru afisarea camerelor ocupate si disponibile
        /// </summary>
        [TestMethod]
        public void Test1NumarCamere()
        {
            CameristaTesting obiect = new CameristaTesting();

            string selectCommand = "SELECT ID_CAMERA FROM CAMERE";
            List<DataRow> listaCamereTotal;
            listaCamereTotal = FunctiiDll.FunctiiDll.selectFromDatabase(new System.Windows.Forms.DataGridView(), selectCommand);

            selectCommand = "SELECT ID_CAMERA FROM CAMERE WHERE OCUPAT='0'";
            List<DataRow> listaCamereLibere;
            listaCamereLibere = FunctiiDll.FunctiiDll.selectFromDatabase(new System.Windows.Forms.DataGridView(), selectCommand);

            selectCommand = "SELECT ID_CAMERA FROM CAMERE WHERE OCUPAT='1'";
            List<DataRow> listaCamereOcupate;
            listaCamereOcupate = FunctiiDll.FunctiiDll.selectFromDatabase(new System.Windows.Forms.DataGridView(), selectCommand);
            Assert.AreEqual(0, listaCamereTotal.Count - listaCamereLibere.Count - listaCamereOcupate.Count, "Test pentru a verifica daca numarul de camere totale+numarul de camere ocupate=numarul de camere totale");
        }
        
        /// <summary>
        /// Metoda de test pentru inserarea unui mini-bar
        /// </summary>
        [TestMethod]
        public void Test2InsertFrigiderValid()
        {
            Camerista obiect = new Camerista();
            obiect.Vin = "5";
            obiect.Bere = "4";
            obiect.BauturiCarbogazoase = "3";
            obiect.ApaPlata = "6";
            Assert.AreEqual(true, obiect.InserareMiniBar(), "Test pentru inserare cu campuri valide");
        }

        /// <summary>
        /// Metoda de test pentru inserarea unui mini-bar invalid
        /// </summary>
        [TestMethod]
        public void Test3InsertFrigiderInvalid1()
        {
            Camerista obiect = new Camerista();
            obiect.Vin = "Ana";
            obiect.Bere = "4";
            obiect.BauturiCarbogazoase = "Prune";
            obiect.ApaPlata = "6";
            Assert.AreEqual(false, obiect.InserareMiniBar(), "Test pentru inserare cu campuri invalide");
        }

        /// <summary>
        /// Metoda de test pentru inserarea unui mini-bar invalid
        /// </summary>
        [TestMethod]
        public void Test4InsertFrigiderInvalid2()
        {
            Camerista obiect = new Camerista();
            obiect.Vin = "";
            obiect.Bere = "";
            obiect.BauturiCarbogazoase = "";
            obiect.ApaPlata = "";
            Assert.AreEqual(false, obiect.InserareMiniBar(), "Test pentru inserare cu campuri goale");
        }
    }
}
