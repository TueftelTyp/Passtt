using System;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace PassGen
{
    public partial class PassForm : Form
    {
        private Random random = new Random();

        public PassForm()
        {
            InitializeComponent();
            toolTip1.RemoveAll();
            toolTip1.ShowAlways = false;
            this.AcceptButton = btnGenerate;

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lstPasswords.Items.Clear();
            int passwordCount = (int)nudPasswordCount.Value;
            int passwordLength = (int)nudPasswordLength.Value;

            for (int i = 0; i < passwordCount; i++)
            {
                string password = GeneratePassword(passwordLength);
                lstPasswords.Items.Add(password);
            }
        }

        private string GeneratePassword(int length)
        {
            string characterSet = "";
            if (chkUppercase.Checked) characterSet += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (chkLowercase.Checked) characterSet += "abcdefghijklmnopqrstuvwxyz";
            if (chkNumbers.Checked) characterSet += "0123456789";
            if (chkSpecialChars.Checked) characterSet += "!@#$%^&*()_+-=[]{}|/;~:',.<>?";
            if (chkSpaces.Checked) characterSet += " ";

            if (string.IsNullOrEmpty(characterSet))
            {
                return string.Empty;
            }

            StringBuilder password = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(characterSet.Length);
                password.Append(characterSet[index]);
            }

            return password.ToString();
        }

        private void lstPasswords_Click(object sender, EventArgs e)
        {
            if (lstPasswords.SelectedItem != null) {
                string selectedItem = lstPasswords.SelectedItem.ToString();
                Clipboard.SetText(selectedItem);
                ShowCopiedTooltip(selectedItem);
            }
        }

        private void ShowCopiedTooltip(string copiedText)
        {
            Point cursorPosition = this.PointToClient(Cursor.Position);
            int offsetX = 30;
            int offsetY = 30;

            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Copied!";
            toolTip1.Show(copiedText, this, cursorPosition.X + offsetX, cursorPosition.Y + offsetY, 3000);
            lstPasswords.SelectedItem = null;
        }

        private void urlLabel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/TueftelTyp/Passtt");
        }
    }
}
