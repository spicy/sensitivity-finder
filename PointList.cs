using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SensitivityFinder
{
    public static class ExtensionMethods
    {
        public static void Swap<T>(this IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }
        public static void Shuffle<T>(this IList<T> list, Random rnd)
        {
            for (var i = list.Count; i > 0; i--)
            {
                list.Swap(i - 1, rnd.Next(0, i));
            }
        }
    }

    class PointList
    {
        private int screenWidth, screenHeight, index;
        private List<Point> points = new List<Point>();

        public PointList(int screenWidth, int screenHeight, int numPoints)
        {
            this.screenWidth = screenWidth;
            this.screenHeight = screenHeight;
            this.index = 0;

            FillListUniform(numPoints, 400);

            // Twice for extra randomness, technically unnecessary, potentially remove
            RandomizeListPositions();
            RandomizeListPositions();
        }

        /// <summary>
        /// Gets the point at the current index
        /// </summary>
        /// <returns>Point</returns>
        public Point GetCurrentPoint()
        {
            if (points.Count > 0)
            {
                return points.ElementAt(index);
            }
            else return new Point(-1, -1);
        }

        /// <summary>
        /// Gets the point at the specified index
        /// </summary>
        /// <param name="idx">index</param>
        /// <returns>Point</returns>
        public Point GetPoint(int idx)
        {
            if (points.Count > 0)
            {
                if (IsIndexValid(idx))
                {
                    return points.ElementAt(idx);
                }
            }

            return new Point(0, 0);
        }

        /// <summary>
        /// (Used for an endless cycle of the pointlist)
        /// Increments the member variable index if it will be a valid size
        /// If not, it randomizes the list and resets index to 0
        /// </summary>
        public void NextOrRandomizeList()
        {
            if (!Next())
            {
                // If we reached the end of the list, then reset index and randomize the list
                if (index + 1 > points.Count - 1)
                {
                    index = 0;
                    RandomizeListPositions();
                }
            }
        }

        /// <summary>
        /// Increments the member variable index if possible
        /// </summary>
        /// <returns>T/F if the next vector position is valid</returns>
        public bool Next()
        {
            if (IsIndexValid(index + 1))
            {
                index++;
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Decrements the member variable index if possible
        /// </summary>
        /// <returns>T/F if the prev vector position is valid</returns>
        public bool Previous()
        {
            if (IsIndexValid(index - 1))
            {
                index--;
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Fills the list with all necessary target positions, uniformly across the screen
        /// </summary>
        public void FillListUniform(int numPoints, int padding)
        {
            // Force numPoints to be even.
            if (numPoints % 2 != 0) numPoints--;

            int x = padding;

            for (int i = 0; i < numPoints; i++)
            {
                x += (this.screenWidth - (padding * 2)) / numPoints;

                Point newPoint = new Point(x, (this.screenHeight / 2) - 20);
                points.Add(newPoint);
            }
        }

        /// <summary>
        /// Clears the list vector
        /// </summary>
        public void ClearList()
        {
            points.Clear();
        }

        /// <summary>
        /// Randomizes the positions inside the list
        /// </summary>
        public void RandomizeListPositions()
        {
            Random rand = new Random();
            points.Shuffle(rand);
        }


        /// <summary>
        /// Checks if the provided index is valid
        /// </summary>
        private bool IsIndexValid(int idx)
        {
            return (idx >= 0 && idx < points.Count);
        }
    }
}
