using System;
using Tvornica_ZD2;

class Program
{
    public static void Main()
    {
        LogInPageFactory factory = new ChromeLogInPageFactory();
        ILogInPage page = factory.CreatePage();

        page.loginButton();
        page.usernameInput();
    }
}