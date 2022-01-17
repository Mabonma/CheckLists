using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CheckLists
{
    public partial class SettingsWindow : Form
    {
        Dictionary<string, string> settings;
        bool ischange = false;

        public SettingsWindow()
        {
            InitializeComponent();

            settings = SQL.SQLite.GetSettings();

            IsidaMessageRecipients.Text = settings["IsidaMessageRecipients"];
            OsedResponseFolder.Text = settings["OsedResponseFolder"];

            DBPathFolder.Text = File.ReadAllText("path.dat");
        }

        private void OpenOsedResponseFolder_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    OsedResponseFolder.Text = dialog.SelectedPath;
                }
            }
        }

        private void Closebt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Applybt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите применить эти настройки?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            settings["IsidaMessageRecipients"] = IsidaMessageRecipients.Text;
            settings["OsedResponseFolder"] = OsedResponseFolder.Text;

            if (!SQL.SQLite.UpdateSettings(settings))
            {
                MessageBox.Show("При обновлении настроек возникли ошибки");
            }
            if (ischange)
            {
                if (File.Exists(DBPathFolder.Text + "\\orr.db"))
                {
                    if (MessageBox.Show("В данной папке существует файл с данной базой данных. Желаете ли вы перезаписать его?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }

                File.Copy(File.ReadAllText("path.dat") + "\\orr.db", DBPathFolder.Text + "\\orr.db", true);

                File.WriteAllText("path.dat", DBPathFolder.Text);

                SQL.SQLite.LoadPathDB();

                ischange = false;
            }

            //if (MessageBox.Show("Вы желаете выйти из настроек?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            //    return;
            //else
            //    Close();
        }

        private void OpenDBPathFolder_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    DBPathFolder.Text = dialog.SelectedPath;
                    char temp = dialog.SelectedPath[dialog.SelectedPath.Length - 1];
                    if (temp.Equals('\\'))
                    {
                        DBPathFolder.Text = DBPathFolder.Text.Remove(DBPathFolder.Text.Length - 1, 1);
                    }

                    ischange = true;
                }
            }
        }
    }
}
