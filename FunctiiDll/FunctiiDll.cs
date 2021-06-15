/**************************************************************************
 *                                                                        *
 *  File:        Admin.cs                                                 *
 *  Copyright:   (c) 2021, Camelia Modiga                                 *
 *  E-mail:      camelia-maria.modiga@student.tuiasi.ro                   *
 *  Description: Implements the dynamic link library                      *
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctiiDll
{
    public class FunctiiDll
    {
        #region Fields
        public static string c = "DATA SOURCE = XE;" + "PERSIST SECURITY INFO = True; USER ID = root; password = root; Pooling = False;";
        public static OracleConnection oracleConnection = new OracleConnection();
        #endregion

        #region Public Methods
        /// <summary>
        /// Metoda generica care preia toate datele dintr-o tabla oracle si le pune intr-un dataGridView
        /// </summary>
        /// <param name="view">Componenta de DataGridView in care vor fi incarcate datele</param>
        /// <param name="selectCommand">Querry-ul de tip select</param>
        /// <returns>inregistrarile din tabela</returns>
        public static List<DataRow> selectFromDatabase(DataGridView view, string selectCommand)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            List<DataRow> list;
            try
            {
                OracleDataAdapter oracleDataAdapter = new OracleDataAdapter(selectCommand, oracleConnection);
                DataTable d = new DataTable();
                oracleDataAdapter.Fill(d);
                view.DataSource = d;
                list = d.AsEnumerable().ToList();
                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed! The table might not exist! Check again!");
                return new List<DataRow>();
            }
            finally
            {
                oracleConnection.Close();
            }
        }
        /// <summary>
        /// Metoda generica care reincarca o componenta de tip combo-box cu datele returnate de la baza de date prin intermediul querry-ului de tip select
        /// </summary>
        /// <param name="combo">Componenta de tip Combo-box care va fi reincarcata</param>
        /// <param name="selectCommand">Querry-ul de tip select</param>
        public static void refreshComboBox(ComboBox combo, string selectCommand)
        {
            oracleConnection.ConnectionString = c;
            oracleConnection.Open();
            using (OracleCommand cmd = new OracleCommand(selectCommand, oracleConnection))
            {

                using (OracleDataReader dr = cmd.ExecuteReader())
                {
                    List<String> items = new List<String>();
                    combo.Items.Clear();
                    while (dr.Read())
                    {
                        items.Add(String.Format("{0}", dr.GetValue(0)));
                    }

                    combo.Items.AddRange(items.ToArray());
                }

            }
            oracleConnection.Close();
        }
        #endregion

    }
}
