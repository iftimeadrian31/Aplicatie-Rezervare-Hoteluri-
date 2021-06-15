/**************************************************************************
 *                                                                        *
 *  File:        AngajatReal.cs                                           *
 *  Copyright:   (c) 2021, Ștefan Alexandra                               *
 *  Description: Implements the part of software that is used as the      *
 *               real GUI instance.                                       *
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProiectIP;

namespace Angajat
{
    /// <summary>
    /// Clasa care se ocupa de componenta interfetei grafice corespunzatoare utilizatorului autentificat a aplicatiei
    /// </summary>
    class AngajatReal : IAngajat
    {
        #region Fields
        private int _nivelAcces;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructorul static al clasei AngajatReal
        /// </summary>
        static AngajatReal()
        {
        }

        /// <summary>
        /// Constructorul clasei AngajatReal
        /// </summary>
        /// <param name="nivelAcces"></param>
        public AngajatReal(int nivelAcces)
        {
            _nivelAcces = nivelAcces;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Metoda care instantiaza interfata grafica corespunzatoare utilizatorului autentificat
        /// </summary>
        /// <param name="form"></param>
        public void PornireInterfata(Form form)
        {
            if (_nivelAcces == -1)
            {
                form.Hide();
                Admin go = new Admin();
                go.ShowDialog();
            }
            else if (_nivelAcces == 0)
            {
                form.Hide();
                Receptionera go = new Receptionera();
                go.ShowDialog();
            }
            else if (_nivelAcces == 1)
            {
                form.Hide();
                Camerista go = new Camerista();
                go.ShowDialog();
            }
        }
        #endregion
    }
}
