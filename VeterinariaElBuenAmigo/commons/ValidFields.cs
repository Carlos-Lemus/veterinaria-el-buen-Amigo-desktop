using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaElBuenAmigo.commons
{
    public class ValidFields
    {
        public static bool isValidInput(String txtInput, Label lblMessageError)
        {

            lblMessageError.Visible = false;

            if (String.IsNullOrEmpty(txtInput))
            {
                lblMessageError.Visible = true;

                return false;
            }


            return true;
        }

    }
}
