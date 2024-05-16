using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tvornica_ZD2
{
    public class ChromeLoginPage : ILogInPage
    {

        public WebElement loginButton()
        {
            return new WebElement("Click");
        }

        public WebElement passwordInput()
        {
            return new WebElement("Enter password");
        }

        public WebElement usernameInput()
        {
            return new WebElement("Enter username");
        }
    }
}
