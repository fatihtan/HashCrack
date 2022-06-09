using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface ISettingsService
    {
        bool Save(Settings settings, string fileName);

        Settings Load(string fileName);
    }
}