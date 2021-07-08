
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace BotLogarFacebook
{
    public class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.facebook.com/";
            string email = "your@email.com";
            string pass = "yourpassword";

            FirefoxDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            Thread.Sleep(1000);

            var emailEl = driver.FindElementById("email");
            emailEl.SendKeys(email);

            var passEl = driver.FindElementById("pass");
            passEl.SendKeys(pass);

            var loginEl = driver.FindElementByName("login");
            loginEl.Click();

            Thread.Sleep(3000);

            var profileEl = driver.FindElementByXPath("//span[@class='a8c37x1j ni8dbmo4 stjgntxs l9j0dhe7']");
            profileEl.Click();

            Thread.Sleep(5000);
            driver.Close();
        }
    }
}
