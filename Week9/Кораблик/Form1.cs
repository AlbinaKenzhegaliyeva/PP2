using System;
using System.Windows.Forms;
using System.Drawing;
namespace Кораблик
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			// Объявляем объект "g" класса Graphics и предоставляем
 // ему возможность рисования на pictureBox1:
  Graphics g = pictureBox1.CreateGraphics();
  g.Clear(Color.Turquoise);
 // Создаем объекты-кисти для закрашивания фигур
  SolidBrush myCorp = new SolidBrush(Color.DarkMagenta);
  SolidBrush myTrum = new SolidBrush(Color.DarkOrchid);
  SolidBrush myTrub = new SolidBrush(Color.DeepPink);
  SolidBrush mySeа = new SolidBrush(Color.Blue);
 //Выбираем перо myPen желтого цвета толщиной в 2 пикселя:
  Pen myWind = new Pen(Color.Yellow, 2);
 // Закрашиваем фигуры
  g.FillRectangle(myTrub,300,125,75,75); // 1 труба (прямоугольник)
  g.FillRectangle(myTrub,480,125,75,75); // 2 труба (прямоугольник)
  g.FillPolygon(myCorp, new Point[]      // корпус (трапеция)
    {
    new Point(100,300),new Point(700,300),
    new Point(700,300),new Point(600,400),
    new Point(600,400),new Point(200,400),
    new Point(200,400),new Point(100,300)
    }
  );
  g.FillRectangle(myTrum, 250, 200, 350, 100); // палуба (прямоугольник)
 // Море - 12 секторов-полуокружностей
  int x = 50;
  int Radius = 50;
  while (x <= pictureBox1.Width - Radius)
  {
     g.FillPie(mySeа, 0 + x, 375, 50, 50, 0, -180); 
     x += 50;
  }
 // Иллюминаторы 
  for (int y = 300; y <= 550; y += 50)
  {
     g.DrawEllipse(myWind, y, 240, 20, 20); // 6 окружностей
  }

		}
	}
}
