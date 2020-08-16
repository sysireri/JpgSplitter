using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JpgSplitter
{
    public static class ExceptionUtilities
    {
        public static void DisplayError(System.Exception vEx)
        {
            String strUserRequest = "Voulez-vous copier cette erreur dans le presse papier ?";
            string strErrorMessage = Environment.NewLine + Environment.NewLine + vEx.Message + Environment.NewLine + Environment.NewLine + vEx.StackTrace;

            if (vEx != null)
            {
                if (MessageBox.Show(strUserRequest + strErrorMessage, "An error occurs.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Windows.Forms.Clipboard.Clear();
                    System.Windows.Forms.Clipboard.SetText(strErrorMessage);
                }
            }
        }
    }
}
