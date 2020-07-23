using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StickyMemo
{
    public partial class StickyMemo : Form
    {
        private int mouseX;
        private int mouseY;
        public StickyMemo()
        {
            InitializeComponent();
        }


        private void InputMemo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void InputMemo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.mouseX = e.X;
                this.mouseY = e.Y;
            }
        }
        private void InputMemo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }

        private void InputMemo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Color.ShowDialog();
            InputMemo.BackColor = Color.Color;
            CloseButton.BackColor = Color.Color;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
