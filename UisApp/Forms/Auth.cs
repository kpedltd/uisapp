using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UisApp.API;
using UisApp.API.Interfaces;

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
            ApiProvider apiProvider = ApiProvider.GetInstance("http://localhost:3000");
            IApiResponse response = null;

            try
            {
                Task.Run(() =>
                {
                    response = apiProvider.Connect("aksenova_ksenia", "doigjohjaerohah");
                });
            }
#pragma warning disable CS0168 // Переменная "ex" объявлена, но ни разу не использована.
            catch(Exception ex)
#pragma warning restore CS0168 // Переменная "ex" объявлена, но ни разу не использована.
            {
                MessageBox.Show("Ошибка подключения");
                return;
            }
        }
    }
}
