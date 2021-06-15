/**************************************************************************
 *                                                                        *
 *  File:        Receptionera.cs                                          *
 *  Copyright:   (c) 2021, Iftime Adrian-Dumitru                          *
 *  Description: Implements the part of software that is used by the      *
 *               receptionist.                                            *
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
    /// Clasa care se ocupa de componenta aplicatiei la care au access utilizatorii cu rol de receptioner
    /// </summary>
    public partial class Receptionera : Form
    {
        #region Fields
        private Acasa _acasa;
        private string _telefonFix = "0";
        private string _parcare = "0";
        private string _uscatorPar = "0";
        private string _internet = "0";
        private string _idRezervare = "";
        private string _idCamera = "";
        private string _nume = "";
        private string _prenume = "";
        private string _cnp = "";
        private string _dataCazare = "";
        private string _dataDecazare = "";
        #endregion

        #region Properties
        public string TelefonFix
        {
            get
            {
                return _telefonFix;
            }
            set
            {
                _telefonFix = value;
            }
        }

        
        public string Parcare
        {
            get
            {
                return _parcare;
            }
            set
            {
                _parcare = value;
            }
        }
        
        public string UscatorPar
        {
            get
            {
                return _uscatorPar;
            }
            set
            {
                _uscatorPar = value;
            }
        }
        
        public string Internet
        {
            get
            {
                return _internet;
            }
            set
            {
                _internet = value;
            }
        }
        
        public string IdRezervare
        {
            get
            {
                return _idRezervare;
            }
            set
            {
                _idRezervare = value;
            }
        }
        
        public string IdCamera
        {
            get
            {
                return _idCamera;
            }
            set
            {
                _idCamera = value;
            }
        }
        
        public string Nume
        {
            get
            {
                return _nume;
            }
            set
            {
                _nume = value;
            }
        }
        
        public string Prenume
        {
            get
            {
                return _prenume;
            }
            set
            {
                _prenume = value;
            }
        }
        
        public string Cnp
        {
            get
            {
                return _cnp;
            }
            set
            {
                _cnp = value;
            }
        }
        
        public string DataCazare
        {
            get
            {
                return _dataCazare;
            }
            set
            {
                _dataCazare = value;
            }
        }
        
        public string DataDecazare
        {
            get
            {
                return _dataDecazare;
            }
            set
            {
                _dataDecazare = value;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructorul clasei Receptionera
        /// </summary>
        public Receptionera()
        {
            this.ControlBox = false;
            InitializeComponent();
            CenterToScreen();
            refreshAllComboBoxes();
        }
        #endregion

        #region Public Methods

        /// <summary>
        /// Metoda care insereaza informatiile despre rezervare in tabela rezervari si apoi modifica starea camerei in ocupat
        /// </summary>
        /// <returns>True daca inserarea a fost facuta cu success sau false daca a aparut o problema</returns>
        public bool InserareRezervare()
        {
            FunctiiDll.FunctiiDll.oracleConnection.ConnectionString = FunctiiDll.FunctiiDll.c;
            FunctiiDll.FunctiiDll.oracleConnection.Open();
            try
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string insert = "INSERT INTO REZERVARE(ID_CAMERA, NUME_CLIENT, PRENUME_CLIENT, CNP_CLIENT, DATA_CAZARE, DATA_DECAZARE, INTERNET,PARCARE," +
                    "TELEFON_FIX,USCATOR_PAR) " +
                    "VALUES('" + IdCamera.Trim().ToString() + "', '"
                    + Nume.Trim().ToString() + "', '"
                    + Prenume.Trim().ToString() + "', '"
                    + Cnp.Trim().ToString() + "', '"
                    + DataCazare.Trim().ToString() + "', '"
                    + DataDecazare.Trim().ToString() + "', '"
                    + Internet + "', '"
                    + Parcare + "', '"
                    + TelefonFix + "', '"
                    + UscatorPar + "')";
                oracleDataAdapter.InsertCommand = new OracleCommand(insert, FunctiiDll.FunctiiDll.oracleConnection);
                oracleDataAdapter.InsertCommand.ExecuteNonQuery();
                string update = "UPDATE CAMERE " +
                                "SET OCUPAT=1" +
                                "WHERE ID_CAMERA=" + IdCamera;
                oracleDataAdapter.UpdateCommand = new OracleCommand(update, FunctiiDll.FunctiiDll.oracleConnection);
                oracleDataAdapter.UpdateCommand.ExecuteNonQuery();
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
                refreshAllComboBoxes();
            }
        }
        /// <summary>
        /// Metoda care sterge gaseste  camera pe care a fost facuta rezervarea , modifica starea ei in libera si apoi sterge rezervarea care are id-ul ales
        /// </summary>
        /// <returns>True daca stergerea a fost facuta cu success sau false daca a aparut o problema</returns>
        public bool StergereRezervare()
        {
            FunctiiDll.FunctiiDll.oracleConnection.ConnectionString = FunctiiDll.FunctiiDll.c;
            FunctiiDll.FunctiiDll.oracleConnection.Open();
            try
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string select = "SELECT ID_CAMERA FROM REZERVARE WHERE ID_REZERVARE=" + IdRezervare;
                OracleCommand command = new OracleCommand(select, FunctiiDll.FunctiiDll.oracleConnection);
                IdCamera = command.ExecuteScalar().ToString();
                string update = "UPDATE CAMERE " +
                "SET OCUPAT=0 " +
                "WHERE ID_CAMERA=" + IdCamera;
                oracleDataAdapter.UpdateCommand = new OracleCommand(update, FunctiiDll.FunctiiDll.oracleConnection);
                oracleDataAdapter.UpdateCommand.ExecuteNonQuery();

                string delete = "DELETE FROM REZERVARE WHERE ID_REZERVARE=" + IdRezervare;
                oracleDataAdapter.DeleteCommand = new OracleCommand(delete, FunctiiDll.FunctiiDll.oracleConnection);
                oracleDataAdapter.DeleteCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("The booking id is not valid!");
                return false;
            }
            finally
            {
                FunctiiDll.FunctiiDll.oracleConnection.Close();
                refreshAllComboBoxes();
            }
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Metoda care reincarca toate componentele de tip combo-box pentru a putea afisa noile date din database
        /// </summary>
        private void refreshAllComboBoxes()
        {
            string selectIdCamera = "SELECT ID_CAMERA FROM CAMERE WHERE OCUPAT=0";
            string selectIdRezervare = "SELECT ID_REZERVARE FROM REZERVARE";
            FunctiiDll.FunctiiDll.refreshComboBox(comboBoxIDCamera, selectIdCamera);
            FunctiiDll.FunctiiDll.refreshComboBox(comboBoxStergereIdRezervare, selectIdRezervare);
        }

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
        private void butonAfisareOcupate_Click(object sender, EventArgs e)
        {
            string select = "SELECT ID_CAMERA,TIP_CAMERA,PRET_CAMERA,ID_MINIBAR FROM CAMERE WHERE OCUPAT='1'";
            FunctiiDll.FunctiiDll.selectFromDatabase(dataGridViewCamereOcupate,select);
        }

        /// <summary>
        /// Metoda de tip callback care incarca datele camerelor disponibile in gridview-ul specific
        /// </summary>
        private void butonAfisareDisponibile_Click(object sender, EventArgs e)
        {

            string select = "SELECT ID_CAMERA,TIP_CAMERA,PRET_CAMERA,ID_MINIBAR FROM CAMERE WHERE OCUPAT='0'";
            FunctiiDll.FunctiiDll.selectFromDatabase(dataGridViewCamereDisponibile,select);
        }

        /// <summary>
        /// Metoda de tip callback care preia datele noii rezervari din interfata si apeleaza functia care insereaza o rezervare in baza de date
        /// </summary>
        private void butonInserareRezervare_Click(object sender, EventArgs e)
        {
            if (checkBoxInternet.Checked)
            {
                Internet = "1";
            }
            if (checkBoxParcare.Checked)
            {
                Parcare = "1";
            }
            if (checkBoxUscatorPar.Checked)
            {
                UscatorPar = "1";
            }
            if (checkBoxTelefonFix.Checked)
            {
                TelefonFix = "1";
            }
            IdCamera = comboBoxIDCamera.Text;
            Nume = textBoxNume.Text;
            Prenume = textBoxPrenume.Text;
            Cnp = textBoxCNP.Text;
            DataCazare = richTextDataCazare.Text;
            DataDecazare = richTextDataDecazare.Text;
            InserareRezervare();
        }

        

        /// <summary>
        /// Metoda de tip callback care preia datele rezervarilor din baza de date Oracle si le afiseaza in DataGridView-ul specific
        /// </summary>
        private void butonAfisare_Click(object sender, EventArgs e)
        {
            string select = "SELECT ID_REZERVARE,NUME_CLIENT,PRENUME_CLIENT,CNP_CLIENT,INTERNET,PARCARE,TELEFON_FIX,USCATOR_PAR," +
                "ID_CAMERA \"CAMERA\",DATA_CAZARE,DATA_DECAZARE FROM REZERVARE";
            FunctiiDll.FunctiiDll.selectFromDatabase(dataGridViewRezervari, select);
        }

        /// <summary>
        /// Metoda de tip callback care preia id-ul rezervarii din interfata si apoi apeleaza functia de stergere rezervare
        /// </summary>
        private void butonStergereRezervare_Click(object sender, EventArgs e)
        {
            IdRezervare = comboBoxStergereIdRezervare.Text;
            StergereRezervare();
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
