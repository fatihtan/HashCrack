using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ExactChar
    {
        public int Index { get; set; }
        public string Chars { get; set; }

        public ExactChar()
        {

        }

        public ExactChar(int Index, string Chars)
        {
            this.Index = Index;
            this.Chars = Chars;
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(this.Chars))
            {
                return string.Format("[{0}:( )]", this.Index);
            }
            else
            {
                return string.Format("[{0}:({1})]", this.Index, this.Chars);
            }
        }

        public static string ToString(List<ExactChar> list)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("{");

            foreach (var item in list)
            {
                sb.Append(item);

                if (item != list.LastOrDefault())
                {
                    sb.Append(", ");
                }
            }

            sb.Append("}");

            return sb.ToString();
        }
    }
}