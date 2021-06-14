using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_SWA_Assignment2
{
	public class MyRect
	{
		private Rectangle rect;
		private int thick;
		private bool isSolid;

		public MyRect()
		{
			rect = new Rectangle();
			thick = 1;
			isSolid = true;
		}

		public void setRect(Point start, Point end, int thick, bool isSolid)
		{
			rect.X = Math.Min(start.X, end.X);
			rect.Y = Math.Min(start.Y, end.Y);
			rect.Width = Math.Abs(end.X - start.X);
			rect.Height = Math.Abs(end.Y - start.Y);
			this.thick = thick;
			this.isSolid = isSolid;
		}

		public Rectangle getRect()
		{
			return rect;
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
