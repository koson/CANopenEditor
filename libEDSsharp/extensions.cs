using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libEDSsharp
{
    public static class extensions
    {
        public static string ToHexString(this byte val)
        {
            return String.Format("0x{0:x}", val);
        }

        public static string ToHexString(this UInt16 val)
        {
            return String.Format("0x{0:x}",val);
        }

        public static string ToHexString(this UInt32 val)
        {
            return String.Format("0x{0:x}", val);
        }

    }

    public static class StringExtensions
    {
        public static bool Contains(this String str, String substring,
                                    StringComparison comp)
        {
            if (substring == null)
                throw new ArgumentNullException("substring",
                                             "substring cannot be null.");
            else if (!Enum.IsDefined(typeof(StringComparison), comp))
                throw new ArgumentException("comp is not a member of StringComparison",
                                         "comp");

            return str.IndexOf(substring, comp) >= 0;
        }
    }
}
