using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using System.Runtime.InteropServices;

namespace CheckLists
{
    /// <summary>
    /// Форма для аутентификации
    /// </summary>
    public partial class Authentific : Form
    {
        /// <summary>
        /// Таймер для обновления текущего языка
        /// </summary>
        Timer timer1;
        public Authentific()
        {
            InitializeComponent();
            label1.Left = (this.Width - label1.Width) / 2;
            UsName.Left = (this.Width - UsName.Width) / 2;
            IfWin.Left = (this.Width - IfWin.Width) / 2;
            label2.Left = (this.Width - label2.Width) / 2;
            UsPass.Left = (this.Width - UsPass.Width) / 2;

            timer1 = new Timer();
            this.timer1.Enabled = true;
            this.timer1.Interval = 777;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
        }

        private void IfWin_CheckedChanged(object sender, EventArgs e)
        {
            if (IfWin.Checked)
            {
                UsName.Text = Environment.UserName;
                UsName.ReadOnly = true;
            }
            else
            {
                UsName.ReadOnly = false;
            }
        }

        private void EnterPass_Click(object sender, EventArgs e)
        {
            try
            {
                if ((new PrincipalContext(ContextType.Domain)).ValidateCredentials(UsName.Text, UsPass.Text))
                {
                    Program.usname = UsName.Text;
                    Program.local = false;
                    this.DialogResult = DialogResult.Yes;
                }
                else
                    MessageBox.Show("Вы что-то не так ввели. Попробуйте снова", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.DirectoryServices.AccountManagement.PrincipalServerDownException)
            {
                if (MessageBox.Show("Невозможно подключится к серверу!!!\n\nВы хотите зайти под своей учётной записью?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Cursor = Cursors.WaitCursor;
                    if ((new PrincipalContext(ContextType.Machine)).ValidateCredentials(UsName.Text, UsPass.Text))
                    {
                        Cursor = Cursors.Default;
                        Program.local = true;
                        Program.usname = UsName.Text;
                        this.DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show("Вы что-то не так ввели. Попробуйте снова", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                    this.DialogResult = DialogResult.No;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка!!!\nПодробности:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UsPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EnterPass_Click(sender, e);
            }
        }

        private void Authentific_Shown(object sender, EventArgs e)
        {
            IfWin.Checked = true;
            UsPass.Focus();
        }

        #region Раскладка клавы

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetKeyboardLayout(int WindowsThreadProcessID);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int GetWindowThreadProcessId(IntPtr handleWindow, out int lpdwProcessID);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr GetForegroundWindow();

        private static InputLanguageCollection _InstalledInputLanguages;
        // Идентификатор активного потока
        private static int _ProcessId;
        // Текущий язык ввода
        private static string _CurrentInputLanguage;

        private static string GetKeyboardLayoutId()
        {

            _InstalledInputLanguages = InputLanguage.InstalledInputLanguages;

            // Получаем хендл активного окна
            IntPtr hWnd = GetForegroundWindow();
            // Получаем номер потока активного окна
            int WinThreadProcId = GetWindowThreadProcessId(hWnd, out _ProcessId);

            // Получаем раскладку
            IntPtr KeybLayout = GetKeyboardLayout(WinThreadProcId);
            // Циклом перебираем все установленные языки для проверки идентификатора
            for (int i = 0; i < _InstalledInputLanguages.Count; i++)
            {
                if (KeybLayout == _InstalledInputLanguages[i].Handle)
                {
                    _CurrentInputLanguage = _InstalledInputLanguages[i].Culture.TwoLetterISOLanguageName;//.ThreeLetterWindowsLanguageName.ToString();
                }
            }
            return _CurrentInputLanguage;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = GetKeyboardLayoutId();
        }
        #endregion
    }
}
