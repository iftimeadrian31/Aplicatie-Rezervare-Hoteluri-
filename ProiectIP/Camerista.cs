/**************************************************************************
 *                                                                        *
 *  File:        Camerista.cs                                             *
 *  Copyright:   (c) 2021, Bizgan Alina                                   *
 *  Description: Implements the part of software that is used by the      *
 *               maid.                                                    *
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
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunctiiDll;

namespace ProiectIP
{
    /// <summary>
    /// Clasa care se ocupa de componenta aplicatiei la care au access utilizatorii cu rol de camerista
    /// </summary>
    public partial class Camerista : Form
    {
        #region Fields
        private Acasa _acasa;
        private string _idMinibar = "";
        private string _bauturiCarbogazoase = "";
        private string _apaPlata = "";
        private string _bere = "";
        private string _vin = "";
        #endregion

        #region Properties
        public string IdMinibar
        {
            get
            {
                return _idMinibar;
            }
            set
            {
                _idMinibar = value;
            }
        }
        public string BauturiCarbogazoase
        {
            get
            {
                return _bauturiCarbogazoase;
            }
            set
            {
                _bauturiCarbogazoase = value;
            }
        }

        public string ApaPlata
        {
            get
            {
                return _apaPlata;
            }
            set
            {
                _apaPlata = value;
            }
        }

        public string Bere
        {
            get
            {
                return _bere;
            }
            set
            {
                _bere = value;
            }
        }


        public string Vin
        {
            get
            {
                return _vin;
            }
            set
            {
                _vin = value;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructorul clasei Camerista
        /// </summary>
        public Camerista()
        {
            this.ControlBox = false;
            InitializeComponent();
            CenterToScreen();

        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Metoda care insereaza informatiile despre minibar in tabela continut_minibar 
        /// </summary>
        /// <returns>True daca inserarea a fost facuta cu success sau false daca a aparut o problema</returns>
        public bool InserareMiniBar()
        {
            FunctiiDll.FunctiiDll.oracleConnection.ConnectionString = FunctiiDll.FunctiiDll.c;
            FunctiiDll.FunctiiDll.oracleConnection.Open();
            try
            {
                string Ocupat = "0";
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string insert = "INSERT INTO CONTINUT_MINIBAR(BAUTURI_CARBOGAZOASE,APA_PLATA,BERE,VIN,OCUPAT)" +
                    "VALUES('"
                    + BauturiCarbogazoase.Trim().ToString() + "', '"
                    + ApaPlata.Trim().ToString() + "', '"
                    + Bere.Trim().ToString() + "', '"
                    + Vin.Trim().ToString() + "', '"
                    + Ocupat + "')"; ;
                oracleDataAdapter.InsertCommand = new OracleCommand(insert, FunctiiDll.FunctiiDll.oracleConnection);
                oracleDataAdapter.InsertCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid data!");
                return false;
            }
            finally
            {

                FunctiiDll.FunctiiDll.oracleConnection.Close();
            }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Metoda de tip callback care inchide form-ul curent si afiseaza pagina de LogIn
        /// </summary>
        private void butonInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            _acasa = Acasa.Instance();
            _acasa.Show();
            this.Close();
        }

        /// <summary>
        /// Metoda de tip callback care incarca datele camerelor ocupate in gridview-ul specific
        /// </summary>
        private void butonAfisareC_Click(object sender, EventArgs e)
        {
            string select = "SELECT ID_CAMERA,TIP_CAMERA,PRET_CAMERA,ID_MINIBAR FROM CAMERE WHERE OCUPAT='1'";
            FunctiiDll.FunctiiDll.selectFromDatabase(dataGridViewCamereO, select);
        }
        /// <summary>
        /// Metoda de tip callback care incarca datele camerelor disponibile in gridview-ul specific
        /// </summary>
        private void butonAfisareD_Click(object sender, EventArgs e)
        {
            string select = "SELECT ID_CAMERA,TIP_CAMERA,PRET_CAMERA,ID_MINIBAR FROM CAMERE WHERE OCUPAT='0'";
            FunctiiDll.FunctiiDll.selectFromDatabase(dataGridViewCamereD, select);
        }
        
        /// <summary>
        /// Metoda de tip callback care preia datele noului continut al minibarului din interfata si apeleaza functia care insereaza informatiile in baza de date
        /// </summary>
        private void butonInserare_Click(object sender, EventArgs e)
        {
            Vin = textBoxVin.Text;
            Bere = textBoxBere.Text;
            BauturiCarbogazoase = textBoxSuc.Text;
            ApaPlata = textBoxApa.Text;
            InserareMiniBar();
        }

        /// <summary>
        /// Metoda de tip callback care preia continut_minibar din baza de date Oracle si le afiseaza in DataGridView-ul specific
        /// </summary>
        private void butonAfisareM_Click(object sender, EventArgs e)
        {
            string select = "SELECT ID_MINIBAR,BAUTURI_CARBOGAZOASE,APA_PLATA,BERE,VIN FROM CONTINUT_MINIBAR";
            FunctiiDll.FunctiiDll.selectFromDatabase(dataGridViewMinibar, select);
        }
        /// <summary>
        /// Metoda de tip care inchide aplicatia
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        #endregion
    }
}
