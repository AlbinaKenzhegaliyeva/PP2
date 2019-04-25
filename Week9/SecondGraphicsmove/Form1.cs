using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondGraphicsmove
{
	public partial class Form1 : Form
	{
		int x = 100;
		int y = 100;
		int r = 30;
		Bitmap bitmap;
		Graphics g;
		bool mouseClicked = false;
		SolidBrush brush = new SolidBrush(Color.Blue);
		public Form1()
		{
			InitializeComponent();
			bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			g = Graphics.FromImage(bitmap);
			pictureBox1.Image = bitmap;
			g.FillEllipse(brush, x, y, r, r);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (mouseClicked)
			{
				y = y + 15;
				g.FillEllipse(brush, x, y, r, r);
				Refresh();
				g.Clear(Color.White);
			}

		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			g.FillEllipse(brush, x, y, r, r);
		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			mouseClicked = true;
		}

	}
}
