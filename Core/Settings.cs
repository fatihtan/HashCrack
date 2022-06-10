using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Settings
    {
        public TK.TKEncrytionAlgorithm TKEncrytionAlgorithm { get; set; }
        public string Output { get; set; }
        public int MinPasswordLength { get; set; }
        public int MaxPasswordLength { get; set; }
        public bool IsExactCharDefined { get; set; }
        public List<ExactChar> ExactCharList { get; set; }
        public bool IncludeCharsBigAZ { get; set; }
        public string CharsBigAZ { get; set; }
        public bool IncludeCharsSmallAZ { get; set; }
        public string CharsSmallAZ { get; set; }
        public bool IncludeCharsNumbers { get; set; }
        public string CharsNumbers { get; set; }
        public bool IncludeSpace { get; set; }
        public bool IncludeAdditionalChars { get; set; }
        public string AdditionalChars { get; set; }

        public static List<char> GetChars(Settings settings)
        {
            List<char> list = new List<char>();

            if (settings.IncludeCharsBigAZ)
            {
                list.AddRange(settings.CharsBigAZ);
            }

            if (settings.IncludeCharsSmallAZ)
            {
                list.AddRange(settings.CharsSmallAZ);
            }

            if (settings.IncludeCharsNumbers)
            {
                list.AddRange(settings.CharsNumbers);
            }

            if (settings.IncludeSpace)
            {
                list.Add(' ');
            }

            if (settings.IncludeAdditionalChars)
            {
                list.AddRange(settings.AdditionalChars);
            }

            return list;
        }
    }
}