using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckLists
{
    public partial class IsidaMessageWindow : Form
    {
        readonly string constr;
        public IsidaMessageWindow()
        {
            InitializeComponent();

            SelectedDatedtp.Value = DateTime.Now;
            constr = SQL.SQLite.GetSetting("IsidaMessageRecipients");

            if (constr.Length == 0)
            {
                MessageBox.Show("В настройках не указаны получатели.");
            }
        }

        private void Closebut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SendMessagebut_Click(object sender, EventArgs e)
        {
            try
            {
                using (SmtpClient client = new SmtpClient())
                using (MailMessage message = new MailMessage("rsender@mtb.minsk.by", constr))
                {
                    client.Port = 25;
                    client.Host = "ldm01.mtb.minsk.by";
                    client.Timeout = 2000;
                    string text = $"Документы за {SelectedDatedtp.Value.ToString("dd.MM.yyyy")} загружены в ИСИДУ и готовы к сверке";
                    message.Subject = text;
                    message.Body = text;
                    client.Send(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }

            Close();
        }
    }
}
