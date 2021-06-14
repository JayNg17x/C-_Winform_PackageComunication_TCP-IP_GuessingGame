using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_SWA_Assignment2
{
	public class MyLines
	{
		private Point[] points = new Point[2];
		private int thick;
		private bool isSolid;

		public MyLines()
		{
			for (int i = 0; i < points.Length; ++i)
			{
				points[i]  = new Point();
			}

			thick = 1;
			isSolid = true;
		}

		public void setPoint(Point start, Point end, int thick, bool isSolid)
		{
			points[0] = start;
			points[1] = end;
			this.thick = thick;
			this.isSolid = isSolid;
		}

		public Point getPoint1()
		{
			return points[0];
		}

		public Point getPoint2()
		{
			return points[1];
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
