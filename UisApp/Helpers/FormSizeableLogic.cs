using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UisApp.Helpers
{
    static class FormSizeableLogic
    {
        private const int HeaderHeight = 32;
        private const int HeightUpperBorder = 5;
        private const int HeightLowerBorder = 5;
        private const int WidthRightBorder = 5;
        private const int WidthLeftBorder = 5;
        private const int Square = 16;

        /// <summary>
        /// Метод встраиваемый в OnPaint
        /// </summary>
        /// <param name="form"></param>
        /// <param name="e"></param>
        public static void OnPaintLogic(Form form, PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(form.ClientSize.Width - Square,
                                         form.ClientSize.Height - Square,
                                         Square,
                                         Square);
            ControlPaint.DrawSizeGrip(e.Graphics, form.BackColor, rc);
        }

        /// <summary>
        /// Метод встраиваемый в WndProc
        /// </summary>
        /// <param name="form"></param>
        /// <param name="m"></param>
        public static void WndProcLogic(Form form, ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                pos = form.PointToClient(pos);

                if (pos.Y <= HeaderHeight && pos.Y >= HeightUpperBorder)
                {
                    m.Result = (IntPtr)2; 
                    return;
                }
                if (pos.Y <= HeightUpperBorder)
                {
                    m.Result = (IntPtr)12;  
                    return;
                }
                if (pos.Y >= form.ClientSize.Height - HeightLowerBorder &&
                    pos.X < form.ClientSize.Width - Square)
                {
                    m.Result = (IntPtr)15;
                    return;
                }
                if (pos.X >= form.ClientSize.Width - WidthRightBorder &&
                    pos.Y < form.ClientSize.Height - Square)
                {
                    m.Result = (IntPtr)11;  
                    return;
                }
                if (pos.X <= WidthLeftBorder)
                {
                    m.Result = (IntPtr)10;  
                    return;
                }
                if (pos.X >= form.ClientSize.Width - Square &&
                    pos.Y >= form.ClientSize.Height - Square)
                {
                    m.Result = (IntPtr)17; 
                    return;
                }
            }
        }
    }
}
