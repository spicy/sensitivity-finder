using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensitivityFinder
{
    public class Collection
    {
        public List<ClickData> clickDataList;

        public Collection()
        {
            clickDataList = new List<ClickData>();
        }

        /// <summary>
        /// Gets the average difference on a given side for
        /// all points in clickDataList
        /// </summary>
        /// <param name="side"> Input: Screenside Type </param>
        /// <returns> Average difference </returns>
        double GetSideAvgDiff(ScreenSide side)
        {
            int total = 0;
            double totalDiff = 0;

            foreach(ClickData clickData in clickDataList)
            {
                if (clickData.targetSide == side)
                {
                    total++;
                    totalDiff += clickData.xDifferencePx;
                }
            }

            return (totalDiff / (double)total);
        }

        /// <summary>
        /// Gets the average difference for all matching
        /// target points in clickDataList
        /// </summary>
        /// <param name="point"> Input: reference point </param>
        /// <returns> Average difference </returns>
        double GetPointAvgDiff(ClickData point)
        {
            int total = 0;
            double totalDiff = 0;

            foreach (ClickData clickData in clickDataList)
            {
                if (clickData.targetPoint == point.targetPoint)
                {
                    total++;
                    totalDiff += clickData.xDifferencePx;
                }
            }

            return (totalDiff / (double)total);
        }

        /// <summary>
        /// Gets the standard deviation of the difference
        /// for all points in vecData
        /// </summary>
        /// <returns> standard deviation of difference </returns>
        double GetStandardDeviation()
        {
            double sum = 0.0, mean, standardDeviation = 0.0;

            foreach (ClickData clickData in clickDataList)
            {
                sum += clickData.xDifferencePx;
            }

            mean = sum / clickDataList.Count;

            foreach (ClickData clickData in clickDataList)
            {
                standardDeviation += Math.Pow(clickData.xDifferencePx - mean, 2);
            }

            return Math.Sqrt(standardDeviation / clickDataList.Count);
        }
    }
}
