/**************************************************************************
 *                                                                        *
 *  File:        Cryptography.cs                                          *
 *  Website:     http://www.obviex.com/samples/Encryption.aspx            *
 *               Adaptation and added functionality by Florin Leon        *
 *               http://florinleon.byethost24.com/lab_ip.htm              *
 *  Description: Contains functions for encryption, decryption,           *
 *               and hashing.                                             *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
namespace Cryptography
{
    public class Cryptography
    {
        public static string HashString(string str)
        {
            HashAlgorithm sha = new SHA1CryptoServiceProvider();
            byte[] buf = new byte[str.Length];
            for (int i = 0; i < str.Length; i++)
                buf[i] = (byte)str[i];
            byte[] result = sha.ComputeHash(buf);
            return Convert.ToBase64String(result);
        }
    }
}
