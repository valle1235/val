#define My_Debug
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finherrans
{
    public partial class Fint : Form
    {
        int _cursX = 0;
        int _cursY = 0;

        public Fint()
        {
            InitializeComponent();
        }

        private void GameLoop(object sender, EventArgs e)
        {

        }

        private void timerGameLoop_Tick(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;
#if My_Debug

            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis;
            Font _font = new System.Drawing.Font("Stencil", 12, FontStyle.Regular);
            TextRenderer.DrawText(dc, "X=" + _cursX.ToString() + ":" + "Y=" + _cursY.ToString(), _font,
                new Rectangle(0, 0, 120, 20), SystemColors.ControlText, flags);

#endif

            base.OnPaint(e);
        }

        private void Fint_MouseMove(object sender, MouseEventArgs e)
        {
            _cursX = e.X;
            _cursY = e.Y;

            this.Refresh();
        }
    }
}
