using System;
using System.Drawing;
namespace TelCo.ColorCoder
{
    /// <summary>
    /// data type defined to Get the Pair Number
    /// </summary>
    internal static class PairNumber
    {

        /// <summary>
        /// Given the two colors the function returns the pair number corresponding to them
        /// </summary>
        /// <param name="pair">Color pair with major and minor color</param>
        /// <param name="colorMapMajor"></param>
        /// <param name="colorMapMinor"></param>
        /// <returns></returns>
        public static int GetPairNumberFromColor(ColorPair pair, Color[] colorMapMajor, Color[] colorMapMinor)
        {
            // Find the major color in the array and get the index
            int majorIndex = -1;
            int minorIndex = -1;
            for (int i = 0; i < colorMapMajor.Length; i++)
            {
                if (colorMapMajor[i] == pair.majorColor)
                {
                    majorIndex = i;
                    break;
                }
            }
            // Find the minor color in the array and get the index
            for (int i = 0; i < colorMapMinor.Length; i++)
            {
                if (colorMapMinor[i] == pair.minorColor)
                {
                    minorIndex = i;
                    break;
                }
            }
            // If colors can not be found throw an exception
            if (majorIndex == -1 || minorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", pair.ToString()));
            }
            return (majorIndex * colorMapMinor.Length) + (minorIndex + 1);
        }
    }
}
