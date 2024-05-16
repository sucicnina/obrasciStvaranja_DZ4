using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvornica_ZD2
{
    public class ChromeLogInPageFactory : LogInPageFactory
    {
        public override ILogInPage CreatePage()
        {
            return new ChromeLoginPage();
        }
    }
}
