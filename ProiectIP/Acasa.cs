/**************************************************************************
 *                                                                        *
 *  File:        Acasa.cs                                                 *
 *  Copyright:   (c) 2021, Ștefan Alexandra                               *
 *  E-mail:      alexandra.stefan@student.tuiasi.ro                       *
 *  Description: Implements the part of software that is used as the      *
 *               main window of the application.                          *
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Angajat;
namespace ProiectIP
{
    /// <summary>
    /// Clasa care se ocupa de componenta aplicatiei la care au access toti utilizatorii inainte de a se loga
    /// </summary>
    public partial class Acasa : Form
    {
        #region Fields
        private Angajat.AngajatProxy _angajatProxy;
        private static Acasa _instanta;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructorul clasei Acasa
        /// </summary>
        private Acasa()
        {
            this.ControlBox = false;
            InitializeComponent();
            CenterToScreen();
            _angajatProxy = new AngajatProxy();
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Metoda pentru crearea unei singure instante a clasei
        /// </summary>
        /// <returns></returns>
        public static Acasa Instance()
        {
            if (_instanta == null)
                _instanta = new Acasa();
            return _instanta;
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Metoda care permite logarea cu un anumit rol pe aplicatie, prin intermediul unui nume de utilizator si a unei parole
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool confirmare = _angajatProxy.Login(textBoxUtilizator.Text, textBoxParola.Text);
            if (confirmare == true)
            {
                _angajatProxy.PornireInterfata(this);
                textBoxUtilizator.Text = "";
                textBoxParola.Text = "";
            }
            else
            {
                MessageBox.Show("Nu ati introdus un utilizator valid");
            }
        }

        /// <summary>
        /// Metoda pentru inchiderea aplicatiei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        /// <summary>
        /// Metoda pentru vizualizarea unei pagini de ajutor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjutor_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Directory.GetCurrentDirectory()+"\\Proiect IP.chm");
        }

        /// <summary>
        /// Metoda pentru vizualizarea unor informatii pe scurt despre proiect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDespre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proiect pentru gestionarea si administrarea unui hotel.\r\nRealizat de Bizgan Alina, Iftime Adrian-Dumitru, Modiga Camelia si Stefan Alexandra.");
        }

        /// <summary>
        /// Metoda pentru vizualizarea unor date de contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonContact_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pentru mai multe informatii va rugam sa va adresati prin e-mail, la adresa hotelt19@gmail.com.");
        }
        #endregion
    }
}
