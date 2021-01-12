using System;
using System.Windows.Forms;
using UisApp.API;
using UisApp.API.Interfaces;
using UisApp.Helpers;
using UisApp.MVP;

namespace UisApp
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthButtonClick(object sender, EventArgs e)
        {
            IApiProvider apiProvider = FakeApiProvider.MakeInstance("http://localhost:3000");
            IApiResponse<IModel> response = null;

            try
            {
                response = apiProvider.Connect(
                        loginTextBox.Text, passwordTextBox.Text);
            }
#pragma warning disable CS0168
            catch (Exception ex)
#pragma warning restore CS0168
            {
                MessageBox.Show("Ошибка подключения");
                return;
            }

            MainForm main = new MainForm();
            main.Show();

            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpperBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormDragLogic.Move(Handle);
            }
        }
    }
}