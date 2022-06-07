using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class TypeService
    {
        public static List<TypeValue> GetList(TK.TKEncrytionAlgorithm TKEncrytionAlgorithm)
        {
            List<TypeValue> list = new List<TypeValue>();

            list.Add(new TypeValue(TK.TKEncrytionAlgorithm.MD5.ToString(), (int)TK.TKEncrytionAlgorithm.MD5));
            list.Add(new TypeValue(TK.TKEncrytionAlgorithm.SHA256.ToString(), (int)TK.TKEncrytionAlgorithm.SHA256));

            return list;
        }
    }
}