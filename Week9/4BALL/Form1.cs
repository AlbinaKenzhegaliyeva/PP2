using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4BALL
{
	public partial class Form1 : Form
	{
		int a = 100;
		int b = 100;
		int a1 = 250;
		int b1 = 250;
		int r = 30;
		bool IsVisible = true;
		bool again = false;

		SolidBrush brush = new SolidBrush(Color.Green);

		GraphicsPath gp = new GraphicsPath();
		GraphicsPath gp1 = new GraphicsPath();
		bool A = false;

		public Form1()
		{
			InitializeComponent();
			gp.AddEllipse(new Rectangle(a, b, 2 * r, 2 * r));
			gp1.AddEllipse(new Rectangle(a1, b1, 2 * r, 2 * r));

		}
		private void timer1_Tick_1(object sender, EventArgs e)
		{
			if (again == true)
			{
				b = b + 20;
				gp.Reset();
				gp.AddEllipse(new Rectangle(a, b, 2 * r, 2 * r));
				Refresh();
			}
			else if (A == true)
			{
				b1 = b1 + 20;
				gp1.Reset();
				gp1.AddEllipse(new Rectangle(a1, b1, 2 * r, 2 * r));
				Refresh();

			}
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.FillPath(brush, gp);
			e.Graphics.FillPath(brush, gp1);
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{

			if (gp.IsVisible(e.Location))
			{
				IsVisible = true;

				again = true;
				Refresh();
			}
			else if (gp1.IsVisible(e.Location))
			{
				IsVisible = true;

				A = true;
				Refresh();
			}
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			IsVisible = false;
			Refresh();
		}
	}
}