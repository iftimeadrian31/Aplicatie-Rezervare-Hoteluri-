/**************************************************************************
 *                                                                        *
 *  File:        Angajat.cs                                               *
 *  Copyright:   (c) 2021, Ștefan Alexandra                               *
 *  E-mail:      alexandra.stefan@student.tuiasi.ro                       *
 *  Description: Implements the part of software that is used as an       *
 *               interface for the proxy design pattern.                  *
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

namespace Angajat
{
    /// <summary>
    /// Interfata utilizata pentru instantierea unei interfete grafice specifice rolului utilizatorului
    /// </summary>
    public interface IAngajat
    {
        void PornireInterfata(Form form);
    }
}
