using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    /// <summary>
    /// A class include all the useful tool method
    /// </summary>
    class Tools
    {
        /// <summary>
        /// Whether the textbox only key in nbumber
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static Boolean isNumber(KeyPressEventArgs e)
        {
            return e.KeyChar != 8 && !Char.IsDigit(e.KeyChar);
        }

        /// <summary>
        /// Whether the string is email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static Boolean isEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
        }

        /// <summary>
        /// Whether the string is NRIC
        /// </summary>
        /// <param name="NRIC"></param>
        /// <returns></returns>
        public static Boolean isNRIC(string NRIC)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(NRIC, @"^(S\d{7}[a-zA-Z])$");
        }
    }
}
