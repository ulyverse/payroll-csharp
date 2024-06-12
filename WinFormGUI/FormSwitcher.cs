using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormGUI
{
    public static class FormSwitcher
    {
        public static void ChangeForm(this Form currentForm, Form nextForm)
        {
            var parent = currentForm.MdiParent;
            currentForm.Close();

            nextForm.MdiParent = parent;
            nextForm.Show();
        }
    }
}
