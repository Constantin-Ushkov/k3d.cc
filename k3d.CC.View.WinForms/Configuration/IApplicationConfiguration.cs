using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IDataConfiguration = k3d.CC.Data.Impl.FS.IConfiguration;

namespace k3d.CC.View.WinForms.Configuration
{
    internal interface IApplicationConfiguration
    {
        IDataConfiguration DataConfiguration { get; }
    }
}
