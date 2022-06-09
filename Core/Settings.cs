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
        public bool IncludeCharsSmallAZ { get; set; }
        public bool IncludeNumbers { get; set; }
        public bool IncludeSpace { get; set; }
        public bool IncludeAdditionalChars { get; set; }
        public string AdditionalChars { get; set; }
    }
}