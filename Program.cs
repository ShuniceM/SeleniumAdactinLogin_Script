using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace E4SeleiumTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://adactinhotelapp.com/SearchHotel.php");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("username")).SendKeys("ShuniceM");
            driver.FindElement(By.Id("password")).SendKeys("Password@19");
            driver.FindElement(By.Id("login")).Click();
            driver.FindElement(By.Id("location")).SendKeys("London");
            driver.FindElement(By.Id("hotels")).SendKeys("Hotel Creek");
            driver.FindElement(By.Id("room_type")).SendKeys("Standard");
            driver.FindElement(By.Id("room_nos")).SendKeys("1-One");
            driver.FindElement(By.Id("datepick_in")).SendKeys("17/05/2024");
            driver.FindElement(By.Id("datepick_out")).SendKeys("15/05/2024");
            driver.FindElement(By.Id("adult_room")).SendKeys("1-One");
            driver.FindElement(By.Id("child_room")).SendKeys("0-None");
            driver.FindElement(By.Id("Submit")).Click();
            

        }
      
      
    }
}
