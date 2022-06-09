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
            this.Chars = string.Empty;
        }

        public ExactChar(int Index, string Chars)
        {
            this.Index = Index;
            this.Chars = Chars;
        }

        public override string ToString()
        {
            return string.Format("[{0}:({1})]", this.Index, this.Chars);
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

        public static List<ExactChar> ToList(string rawData)
        {
            List<ExactChar> list = new List<ExactChar>();

            rawData = rawData.Replace("{", "").Replace("}", "");
            var dataList = rawData.Split(new char[] { ',', ' ' });
            foreach (var item in dataList)
            {
                string tempItem = item.Replace("[", "").Replace("]", "");
                string []parts = tempItem.Split(':');

                list.Add(new ExactChar(Convert.ToInt32(parts[0]), parts[1].Replace("(", "").Replace(")", "")));
            }

            return list;
        }
    }
}