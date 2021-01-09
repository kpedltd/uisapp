using System;
using System.Globalization;
using System.Windows.Forms;
using UisApp.Components.Profile.Interfaces;
using UisApp.Models;

namespace UisApp.Components.Profile
{
    public partial class ProfileView : UserControl, IUisComponent, ILecturerModel, IProfileView
    {
        /// <summary>
        /// Презентер
        /// </summary>
        public IProfilePresenter Presenter
        {
            get;
            set;
        }

        public ProfileView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName
        {
            get
            {
                return GetFirstName();
            }
            set
            {
                SetFirstName(value);
            }
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName
        {
            get
            {
                return GetLastName();
            }
            set
            {
                SetLastName(value);
            }
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Patronymic
        {
            get
            {
                return GetPatronymic();
            }
            set
            {
                SetPatronymic(value);
            }
        }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth
        {
            get
            {
                var result = new DateTime();
                DateTime.TryParseExact(dateValue.Text, "dd.MM.yyyy", null,
                                   DateTimeStyles.None, out result);
                return result;
            }
            set
            {
                dateValue.Text = value.ToString("dd.MM.yyyy");
            }
        }

        /// <summary>
        /// Ссылка на фото
        /// </summary>
        public string Photo
        {
            get;
            set;
        }

        /// <summary>
        /// Биография
        /// </summary>
        public string Biography
        {
            get
            {
                return biographtValue.Text;
            }
            set
            {
                biographtValue.Text = value;
            }
        }

        /// <summary>
        /// Имя кафедры
        /// </summary>
        public string DepartmentName
        {
            get
            {
                return depValue.Text;
            }
            set
            {
                depValue.Text = value;
            }
        }

        /// <summary>
        /// Имя факультета
        /// </summary>
        public string FacultyName
        {
            get
            {
                return facultValue.Text;
            }
            set
            {
                facultValue.Text = value;
            }
        }

        private string GetFirstName()
        {
            return fullnameLabel.Text.Split()[0];
        }

        private string GetLastName()
        {
            return fullnameLabel.Text.Split()[1];
        }

        private string GetPatronymic()
        {
            return fullnameLabel.Text.Split()[2];
        }

        private void SetFirstName(string name)
        {
            var splited = fullnameLabel.Text.Split();
            splited[0] = name;
            fullnameLabel.Text = String.Join(" ", splited);
        }

        private void SetLastName(string name)
        {
            var splited = fullnameLabel.Text.Split();
            splited[1] = name;
            fullnameLabel.Text = String.Join(" ", splited);
        }

        private void SetPatronymic(string patr)
        {
            var splited = fullnameLabel.Text.Split();
            splited[2] = patr;
            fullnameLabel.Text = String.Join(" ", splited);
        }

        private void Photo_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Привязать презентер
        /// </summary>
        /// <param name="presenter"></param>
        /// <param name="requiresInitialState"></param>
        public void AttachToPresenter(IProfilePresenter presenter, bool requiresInitialState)
        {
            if (presenter == null)
            {
                throw new ArgumentNullException(nameof(presenter));
            }

            DetatchFromPresenter();

            Presenter = presenter;
            Presenter.ConnectView(this, requiresInitialState);
        }

        /// <summary>
        /// Отвязать презентер
        /// </summary>
        public void DetatchFromPresenter()
        {
            lock (this)
            {
                if (Presenter != null)
                {
                    Presenter.DisconnectView(this);
                    Presenter = null;
                }
            }
        }

        /// <summary>
        /// Обновить из модели
        /// </summary>
        /// <param name="lecturerModel"></param>
        public void Update(ILecturerModel lecturerModel)
        {
            FirstName = lecturerModel.FirstName;
            LastName = lecturerModel.LastName;
            Patronymic = lecturerModel.Patronymic;
            DateOfBirth = lecturerModel.DateOfBirth;
            Biography = lecturerModel.Biography;
            DepartmentName = lecturerModel.DepartmentName;
            FacultyName = lecturerModel.FacultyName;
        }
    }
}