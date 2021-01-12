using System.Collections.Generic;
using System.Windows.Forms;

namespace UisApp.Components
{
    internal class UisComponentsContainer : Panel
    {
        /// <summary>
        /// Список представлений
        /// </summary>
        private List<IUisComponent> components;

        /// <summary>
        /// Текущее представление
        /// </summary>
        private IUisComponent currentVisible;

        public UisComponentsContainer()
        {
            this.Parent = Parent;
            components = new List<IUisComponent>();
            currentVisible = null;
        }

        /// <summary>
        /// Добавить представление
        /// </summary>
        /// <param name="component">Представление</param>
        public void AttachView(IUisComponent component)
        {
            component.Parent = this;
            component.Dock = DockStyle.Fill;

            if (component != null)
            {
                component.Hide();
                component.Visible = false;
            }

            components.Add(component);
        }

        /// <summary>
        /// Переключиться на другое представление
        /// </summary>
        /// <param name="component"></param>
        public void SwitchTo(IUisComponent component)
        {
            if (component != currentVisible)
            {
                component.Show();
                component.BringToFront();

                if (currentVisible != null)
                {
                    currentVisible.Hide();
                    currentVisible.Visible = false;
                }
                
                currentVisible = component;
            }
        }

        /// <summary>
        /// Выбрать первый таблет
        /// </summary>
        public void SwitchFirst()
        {
            if (components.Count != 0)
            {
                currentVisible = components[0];

                currentVisible.Show();
                currentVisible.Visible = true;

                currentVisible.BringToFront();
            }
        }
    }
}