/**************************************************************************
 *                                                                        *
 *  File:        AngajatProxy.cs                                          *
 *  Copyright:   (c) 2021, Ștefan Alexandra                               *
 *  Description: Implements the part of software that is used as the      *
 *               protection proxy.                                        *
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
using System.Data.OracleClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cryptography;
using FunctiiDll;

namespace Angajat
{
    /// <summary>
    /// Clasa care se ocupa de componenta de protectie proxy a aplicatiei 
    /// </summary>
    public class AngajatProxy : IAngajat
    {
        #region Fields
       
        private AngajatReal _angajatReal;
        private List<User> _utilizatori;
        private List<string> _niveluri;
        private User _utilizatorCurent;
        #endregion

        #region Structures
        /// <summary>
        /// Structura care defineste un utilizator
        /// </summary>
        public struct User
        {
            public readonly string Nume;
            public readonly string PassHash;
            public readonly int NivelAcces;
            public readonly string Post;

            /// <summary>
            /// Constructor al structurii utilizator
            /// </summary>
            /// <param name="nume"></param>
            /// <param name="passHash"></param>
            /// <param name="nivelAcces"></param>
            /// <param name="post"></param>
            public User(string nume, string passHash, int nivelAcces, string post)
            {
                Nume = nume;
                PassHash = passHash;
                NivelAcces = nivelAcces;
                Post = post;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructorul clasei AngajatProxy
        /// </summary>
        public AngajatProxy()
        {
            _niveluri = new List<string>();
            _utilizatori = new List<User>();
            FunctiiDll.FunctiiDll.oracleConnection.ConnectionString = FunctiiDll.FunctiiDll.c;
            FunctiiDll.FunctiiDll.oracleConnection.Open();
            try
            {
                string selectCommand = "SELECT * FROM ANGAJATI";
                DataTable dataTable = new DataTable();
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(selectCommand, FunctiiDll.FunctiiDll.oracleConnection);
                oracleDataAdapter.Fill(dataTable);
                List<DataRow> list = dataTable.AsEnumerable().ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    User user = new User(list[i]["NUME_ANGAJAT"].ToString(), list[i]["PASSHASH_ANGAJAT"].ToString(), Convert.ToInt32(list[i]["NIVEL_ANGAJAT"].ToString()), list[i]["POST_ANGAJAT"].ToString());
                    _utilizatori.Add(user);
                }

                selectCommand = "SELECT * FROM NIVELURI";
                dataTable = new DataTable();
                oracleDataAdapter = new OracleDataAdapter(selectCommand, FunctiiDll.FunctiiDll.oracleConnection);
                oracleDataAdapter.Fill(dataTable);
                list = dataTable.AsEnumerable().ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    _niveluri.Add(list[i]["NIVEL"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed! The table might not exist! Check again!");
            }
            finally
            {
                FunctiiDll.FunctiiDll.oracleConnection.Close();
            }
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Metoda care permite autentificarea utilizatorului
        /// </summary>
        /// <param name="utilizator"></param>
        /// <param name="parola"></param>
        /// <returns></returns>
        public bool Login(string utilizator, string parola)
        {
            int flag = 0;
            string hash = Cryptography.Cryptography.HashString(parola);
            for (int i = 0; i < _utilizatori.Count; i++)
            {
                if (_utilizatori[i].Nume == utilizator && _utilizatori[i].PassHash == hash)
                {
                    _angajatReal = new AngajatReal(_utilizatori[i].NivelAcces);
                    _utilizatorCurent = new User(_utilizatori[i].Nume, _utilizatori[i].PassHash, _utilizatori[i].NivelAcces, _utilizatori[i].Post);
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Metoda care apeleaza functia corespunzatoare de afisare a interfetei grafice specifice utilizatorului autentificat
        /// </summary>
        /// <param name="form"></param>
        public void PornireInterfata(Form form)
        {
            _angajatReal.PornireInterfata(form);
        }

        /// <summary>
        /// Metoda de adaugare a unui nou utilizator, ce poate fi apelata doar de administrator
        /// </summary>
        /// <param name="utilizator"></param>
        /// <param name="parola"></param>
        /// <param name="post"></param>
        public void AdaugaUtilizator(string utilizator, string parola, string post)
        {
            int nivel = 0;
            if (post == "Administrator")
                nivel = -1;
            else if (post == "Receptionist")
                nivel = 0;
            else if (post == "Camerist")
                nivel = 1;
            User utilizatorNou = new User(utilizator, Cryptography.Cryptography.HashString(parola), nivel, post);
            _utilizatori.Add(utilizatorNou);
            SalveazaUtilizator();
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Metoda de salvare in baza de date a unui utilizator nou introdus
        /// </summary>
        private void SalveazaUtilizator()
        {
            FunctiiDll.FunctiiDll.oracleConnection.ConnectionString = FunctiiDll.FunctiiDll.c;
            FunctiiDll.FunctiiDll.oracleConnection.Open();
            try
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter();
                string insert = "INSERT INTO ANGAJATI(NUME_ANGAJAT,PASSHASH_ANGAJAT,NIVEL_ANGAJAT,POST_ANGAJAT) VALUES('"
                    + _utilizatori[_utilizatori.Count - 1].Nume + "', '"
                    + _utilizatori[_utilizatori.Count - 1].PassHash + "', '"
                    + _utilizatori[_utilizatori.Count - 1].NivelAcces + "', '"
                    + _utilizatori[_utilizatori.Count - 1].Post + "')";
                oracleDataAdapter.InsertCommand = new OracleCommand(insert, FunctiiDll.FunctiiDll.oracleConnection);
                oracleDataAdapter.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FunctiiDll.FunctiiDll.oracleConnection.Close();
            }
        }
        #endregion
    }
}
