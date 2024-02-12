using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAlPhabet.Utils
{
    internal static class CoreUtils
    {
        public static void FetchImage(string imageUrl) 
        {
            // use request to page
        }

        public static int GetRandomImagePage(int maxPages) 
        {
            return new Random().Next(maxPages);
        }

        public static bool IsPictureInLimits()
        {

            return true;
        }

    }
}
