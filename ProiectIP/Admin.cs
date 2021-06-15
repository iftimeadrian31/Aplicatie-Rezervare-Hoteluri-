/**************************************************************************
 *                                                                        *
 *  File:        Admin.cs                                                 *
 *  Copyright:   (c) 2021, Camelia Modiga                                 *
 *  E-mail:      camelia-maria.modiga@student.tuiasi.ro                   *
 *  Description: Implements the part of software that is used by the      *
 *               administrator.                                           *
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
using Angajat;

namespace ProiectIP
{
    /// <summary>
    /// Clasa care se ocupa de componenta aplicatiei la care au access utilizatorii cu rol de admin
    /// </summary>
    public partial class Admin : Form
    {
        #region Fields
       
        private Acasa _acasa;
        private Angajat.AngajatProxy _angajatProxy;
        private string _idAngajat = "";
        private string _idCamera = "";
        private string _idMinibar = "";
        private string _numeAngajat = "";
        private string _parolaAngajat = "";
        private string _postAngajat = "";
        private string _tipCamera = "";
        private string _pretCamera = "";
        #endregion

        #region Properties
        public string IdAngajat
        {
            get
            {
                return _idAngajat;
            }
            set
            {
                _idAngajat = value;
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

        public string numeAngajat
        {
            get
            {
                return _numeAngajat;
            }
            set
            {
                _numeAngajat = value;
            }
        }

        public string parolaAngajat
        {
            get
            {
                return _parolaAngajat;
            }
            set
            {
                _parolaAngajat = value;
            }
        }

        public string postAngajat
        {
            get
            {
                return _postAngajat;
            }
            set
            {
                _postAngajat = value;
            }
        }

        public string tipCamera
        {
            get
            {
                return _tipCamera;
            }
            set
            {
                _tipCamera = value;
            }
        }

        public string pretCamera
        {
            get
            {
                return _pretCamera;
            }
            set
            {
                _pretCamera = value;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructorul clasei Admin
        /// </summary>
        public Admin()
        {
            this.ControlBox = false;
            InitializeComponent();
            CenterToScreen();
            refreshAllComboBoxes();
            _angajatProxy = new AngajatProxy();
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Metoda care insereaza noi camere in baza de date
        /// </summary>
        public bool InserareCamere()
        {
            FunctiiDll.FunctiiDll.oracleConnection.ConnectionString = FunctiiDll.FunctiiDll.c;
            FunctiiDll.FunctiiDll.oracleConnection.Open();
            try
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                int ocupat = 0;
                string insert = "INSERT INTO CAMERE(TIP_CAMERA,PRET_CAMERA,ID_MINIBAR,OCUPAT) VALUES('"
                    + tipCamera + "', "
                    + pretCamera + ", "
                    + IdMinibar + ", " + ocupat + ")";
                oracleDataAdapter.InsertCommand = new OracleCommand(insert, FunctiiDll.FunctiiDll.oracleConnection);
                oracleDataAdapter.InsertCommand.ExecuteNonQuery();
                string update = "UPDATE CONTINUT_MINIBAR " +
                                "SET OCUPAT=1" +
                                "WHERE ID_MINIBAR=" + IdMinibar;
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
        /// Metoda care sterge angajatii din baza de date 
        /// </summary>
        public bool StergeAngajat()
        {
            FunctiiDll.FunctiiDll.oracleConnection.ConnectionString = FunctiiDll.FunctiiDll.c;
            FunctiiDll.FunctiiDll.oracleConnection.Open();
            try
            {

                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string delete = "DELETE FROM ANGAJATI WHERE ID_ANGAJAT = " + IdAngajat;
                oracleDataAdapter.DeleteCommand = new OracleCommand(delete, FunctiiDll.FunctiiDll.oracleConnection);
                oracleDataAdapter.DeleteCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid id!");
                return false;
            }
            finally
            {
                FunctiiDll.FunctiiDll.oracleConnection.Close();
                refreshAllComboBoxes();
            }

        }
        /// <summary>
        /// Metoda care sterge camere din baza de date 
        /// </summary>
        public bool StergeCamere()
        {
            FunctiiDll.FunctiiDll.oracleConnection.ConnectionString = FunctiiDll.FunctiiDll.c;
            FunctiiDll.FunctiiDll.oracleConnection.Open();
            try
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string select = "SELECT ID_MINIBAR FROM CAMERE WHERE ID_CAMERA=" + IdCamera;
                OracleCommand command = new OracleCommand(select, FunctiiDll.FunctiiDll.oracleConnection);
                string id_minibar = command.ExecuteScalar().ToString();
                string update = "UPDATE CONTINUT_MINIBAR " +
                "SET OCUPAT=0 " +
                "WHERE ID_MINIBAR=" + id_minibar;
                oracleDataAdapter.UpdateCommand = new OracleCommand(update, FunctiiDll.FunctiiDll.oracleConnection);
                oracleDataAdapter.UpdateCommand.ExecuteNonQuery();
                string delete = "DELETE FROM CAMERE WHERE ID_CAMERA=" + IdCamera;
                oracleDataAdapter.DeleteCommand = new OracleCommand(delete, FunctiiDll.FunctiiDll.oracleConnection);
                oracleDataAdapter.DeleteCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid id!");
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
        /// Metoda care reincarca toate componentele de tip combo-box pentru a putea afisa noile date din baza de date
        /// </summary>
        private void refreshAllComboBoxes()
        {
            string selectIdCamera = "SELECT ID_CAMERA FROM CAMERE WHERE OCUPAT=0";
            string selectIdMinibar = "SELECT ID_MINIBAR FROM CONTINUT_MINIBAR WHERE OCUPAT=0";
            string selectIdAngajat = "SELECT ID_ANGAJAT FROM ANGAJATI";
            FunctiiDll.FunctiiDll.refreshComboBox(comboBoxIdStergeCamere, selectIdCamera);
            FunctiiDll.FunctiiDll.refreshComboBox(comboBoxIdMinibar, selectIdMinibar);
            FunctiiDll.FunctiiDll.refreshComboBox(comboBoxIdStergeAngajat, selectIdAngajat);
        }
        /// <summary>
        /// Metoda realizeaza inchiderea panoului curent si intoarcerea la pagina principala 
        /// </summary>
        private void butonInapoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            _acasa = Acasa.Instance();
            _acasa.Show();
            this.Close();
        }
        
        /// <summary>
        /// Metoda afiseaza camerele hotelului din baza de date
        /// </summary>
        private void butonAfisareCamere_Click(object sender, EventArgs e)
        {

            string select = "SELECT  * FROM CAMERE ";
            FunctiiDll.FunctiiDll.selectFromDatabase(dataGridViewCamere, select);

        }

        /// <summary>
        /// Metoda afiseaza informatiile angajatilor hotelului din baza de date
        /// </summary>
        private void butonAfisareAngajati_Click(object sender, EventArgs e)
        {

            string select = "SELECT ID_ANGAJAT,NUME_ANGAJAT,POST_ANGAJAT FROM ANGAJATI ";
            FunctiiDll.FunctiiDll.selectFromDatabase(dataGridViewAngajati, select);

        }

        /// <summary>
        /// Metoda care preia din interfata tipul, pretul camerei si id-ul minibarului si apoi apeleaza functia de inserare
        /// </summary>
        private void butonInserareCamere_Click(object sender, EventArgs e)
        {
            tipCamera = richTextBoxTipCamera.Text.Trim().ToString();
            pretCamera = richTextBoxPretCamera.Text.Trim().ToString();
            IdMinibar = comboBoxIdMinibar.Text.Trim().ToString();
            InserareCamere();
        }

        /// <summary>
        /// Metoda care preia id-ul angajatului din interfata si apoi apeleaza functia de stergere
        /// </summary>
        private void butonStergeAngajat_Click(object sender, EventArgs e)
        {
            IdAngajat = comboBoxIdStergeAngajat.Text.Trim().ToString();
            StergeAngajat();

        }

        /// <summary>
        /// Metoda care preia id-ul camerei din interfata si apoi apeleaza functia de stergere
        /// </summary>
        private void butonStergeCamere_Click(object sender, EventArgs e)
        {
            IdCamera = comboBoxIdStergeCamere.Text;
            StergeCamere();

        }

        /// <summary>
        /// Metoda care prin intermediul sablonului Proxy adauga noi angajati in baza de date 
        /// </summary>
        private void InserareAngajati()
        {
            _angajatProxy.AdaugaUtilizator(numeAngajat, parolaAngajat, postAngajat);
        }

        /// <summary>
        /// Metoda care preia din interfata numele angajatului, parola si postul iar apoi apeleaza functia de inserare
        /// </summary>
        private void butonInserareAngajat_Click(object sender, EventArgs e)
        {
            numeAngajat = textBoxNumeAngajat.Text.Trim().ToString();
            parolaAngajat = textBoxParolaAngajat.Text.Trim().ToString();
            postAngajat = textBoxPostAngajat.Text.Trim().ToString();
            InserareAngajati();
        }

        /// <summary>
        /// Metoda care realizeaza inchiderea aplicatiei la apasarea butonului Exit
        /// </summary>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        #endregion
    }
}
