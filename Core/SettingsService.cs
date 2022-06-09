using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class SettingsService : ISettingsService
    {
        public bool Save(Settings settings, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);

            writer.WriteLine(string.Format("TKEncrytionAlgorithm:{0}", (int)settings.TKEncrytionAlgorithm));
            writer.WriteLine(string.Format("Output:{0}", settings.Output));
            writer.WriteLine(string.Format("MinPasswordLength:{0}", settings.MinPasswordLength));
            writer.WriteLine(string.Format("MaxPasswordLength:{0}", settings.MaxPasswordLength));
            writer.WriteLine(string.Format("IsExactCharDefined:{0}", settings.IsExactCharDefined));
            writer.WriteLine(string.Format("ExactCharList:{0}", ExactChar.ToString(settings.ExactCharList)));
            writer.WriteLine(string.Format("IncludeCharsBigAZ:{0}", settings.IncludeCharsBigAZ));
            writer.WriteLine(string.Format("IncludeCharsSmallAZ:{0}", settings.IncludeCharsSmallAZ));
            writer.WriteLine(string.Format("IncludeNumbers:{0}", settings.IncludeNumbers));
            writer.WriteLine(string.Format("IncludeSpace:{0}", settings.IncludeSpace));
            writer.WriteLine(string.Format("IncludeAdditionalChars:{0}", settings.IncludeAdditionalChars));
            writer.WriteLine(string.Format("AdditionalChars:{0}", settings.AdditionalChars));

            writer.Close();
            return true;
        }


        public Settings Load(string fileName)
        {
            Settings settings = null;

            StreamReader reader = new StreamReader(fileName);
            TK.TKEncrytionAlgorithm tempTKEncrytionAlgorithm;
            Enum.TryParse<TK.TKEncrytionAlgorithm>(reader.ReadLine().Split(':')[1], out tempTKEncrytionAlgorithm);
            settings.TKEncrytionAlgorithm = tempTKEncrytionAlgorithm;
            settings.Output = reader.ReadLine().Split(':')[1];
            settings.MinPasswordLength = Convert.ToInt32(reader.ReadLine().Split(':')[1]);
            settings.MaxPasswordLength = Convert.ToInt32(reader.ReadLine().Split(':')[1]);
            settings.IsExactCharDefined = Convert.ToBoolean(reader.ReadLine().Split(':')[1]);
            settings.ExactCharList = ExactChar.ToList(reader.ReadLine().Split(':')[1]);
            settings.IncludeCharsBigAZ = Convert.ToBoolean(reader.ReadLine().Split(':')[1]);
            settings.IncludeCharsSmallAZ = Convert.ToBoolean(reader.ReadLine().Split(':')[1]);
            settings.IncludeNumbers = Convert.ToBoolean(reader.ReadLine().Split(':')[1]);
            settings.IncludeSpace = Convert.ToBoolean(reader.ReadLine().Split(':')[1]);
            settings.IncludeAdditionalChars = Convert.ToBoolean(reader.ReadLine().Split(':')[1]);
            settings.AdditionalChars = reader.ReadLine().Split(':')[1];
            
            return settings;
        }
    }
}