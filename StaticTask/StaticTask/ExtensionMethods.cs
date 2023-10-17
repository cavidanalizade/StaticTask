using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTask
{
    internal static class ExtensionMethods
    {
        public static bool CustomContains(this string extension , string searchString)
        {
            return extension.ToLower().Contains(searchString.ToLower());

        }
        public static bool CustomContains(this string extension, char searchChar)
        {
            return extension.ToLower().Contains(searchChar.ToString().ToLower());

        }

        public static bool IsPrime(this int extension)
        {
            if (extension <= 1)
                return false;

            for (int i = 2; i * i <= extension; i++)
            {
                if (extension % i == 0)
                    return false;
            }

            return true;
        }

        public static bool IsPowOfTwo(this int extension)
        {
            if (extension <= 0)
                return false;

 
            return (extension & (extension - 1)) == 0;

        }


    }
}
