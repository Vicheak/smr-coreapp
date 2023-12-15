using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementAndReport.Utility
{
    public class Util
    {

        public static bool CheckValidDataTextBox(TextBox textBox, string fieldName)
        {
            if(string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show(
                    $"{fieldName} is required! please complete this field",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                textBox.Focus(); 

                return false; 
            }
            return true; 
        }

    }
}
