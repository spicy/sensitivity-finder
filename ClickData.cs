using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensitivityFinder
{
	/// <summary>
	/// Represents the type of difference
	/// LESS = didnt move mouse far enough,
	/// GREATER = moved mouse too far
	/// </summary>
	public enum MissType
	{
		LESS = 0,
		GREATER,
		HIT,
		NONE
	};

	/// <summary>
	/// Represents the side of the screen the target point is
	/// </summary>
	public enum ScreenSide
	{
		LEFT = 0,
		RIGHT,
		NONE
	};

	public class ClickData
    {
		public Point targetPoint, mousePoint;
		public int xDifferencePx;
		public MissType missType;
		public ScreenSide targetSide;

		public ClickData(Point targetPoint, Point mousePoint)
        {
			this.targetPoint = targetPoint;
			this.mousePoint = mousePoint;

			this.targetSide = GetScreenSide(targetPoint);
			this.missType = GetMissType(targetPoint, mousePoint);

			int missSign = (missType == MissType.LESS) ? -1 : 1;
			xDifferencePx = missSign * Math.Abs(targetPoint.X - mousePoint.X);
        }

		public ScreenSide GetScreenSide(Point targetPoint)
        {
			if (targetPoint.X + Settings.PointWidth / 2 > Screen.PrimaryScreen.Bounds.Width / 2)
			{
				return ScreenSide.RIGHT;
			}
			else if (targetPoint.X + Settings.PointWidth / 2 < Screen.PrimaryScreen.Bounds.Width / 2)
			{
				return ScreenSide.LEFT;
			}
			else
			{
				return ScreenSide.NONE;
			}
        }

		public MissType GetMissType(Point targetPoint, Point mousePoint)
        {
			// Use temp diff instead of field difference
			int diff = targetPoint.X - mousePoint.X + Settings.PointWidth / 2;

			if (Math.Abs(diff) < Settings.PointWidth / 2)
			{
				return MissType.HIT;
			}
			else if (targetSide == ScreenSide.LEFT)
			{
				// Diff negative = mouse is larger, did not move enough
				if (diff < 0)
				{
					return MissType.LESS;
				}
				// Diff positive = target is larger, moved too much
				else if (diff > 0)
				{
					return MissType.GREATER;
				}
			}
			else
			{
				// Diff negative = mouse is larger, moved too much
				if (diff < 0)
				{
					return MissType.GREATER;
				}
				// Diff positive = target is larger, did not move enough
				else if (diff > 0)
				{
					return MissType.LESS;
				}
			}

			return MissType.NONE;
		}

		public double GetDifferenceInAngles()
		{
			// Then do math with difference in pixels
			double anglesPerPixel = Settings.Fov / Screen.PrimaryScreen.Bounds.Width;
			return (xDifferencePx * anglesPerPixel);
		}
	}
}
