using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_SWA_Assignment2
{
	public class MyCircle
	{
		private Rectangle rectC;
		private int thick;
		private bool isSolid;

		public MyCircle()
		{
			rectC = new Rectangle();
			thick = 1;
			isSolid = true;
		}

		public void setRectC(Point start, Point end, int thick, bool isSolid)
		{
			rectC.X = Math.Min(start.X, end.X);
			rectC.Y = Math.Min(start.Y, end.Y);
			rectC.Width = Math.Abs(start.X - end.X);
			rectC.Height = Math.Abs(start.Y - end.Y);
			this.thick = thick;
			this.isSolid = isSolid;
		}

		public Rectangle GetRectC()
		{
			return rectC;
		}

		public int getThick()
		{
			return thick;
		}

		public bool getSolid()
		{
			return isSolid;
		}
	}
}
