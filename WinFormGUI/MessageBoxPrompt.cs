using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormGUI
{
    public class MessageBoxPrompt
    {
        public static DialogResult Delete(string item = "item")
        {
            return MessageBox.Show($"This action cannot be undone. Are you sure you want to delete this {item}?", "Confirmation Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public static DialogResult Exit(string message = "Do you really want to close without saving?")
        {
            return MessageBox.Show(message, "Confirmation Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        public static DialogResult Save(string message = "Do you want to save changes?", string title = "Save Changes")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        public static DialogResult ShowInfo(string message, string title = "")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult YesNoPrompt(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
