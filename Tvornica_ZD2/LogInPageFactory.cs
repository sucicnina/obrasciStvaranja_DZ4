using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvornica_ZD2
{
    public abstract class LogInPageFactory
    {
        public abstract ILogInPage CreatePage();
    }
}
