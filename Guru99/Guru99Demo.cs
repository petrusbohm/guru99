using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace Guru99Demo
{
    class TestSelect
    {
        IWebDriver driver;

        [Test]
        public void selectDemo()
        {
            driver = new ChromeDriver();
            driver.Url = "http://demo.guru99.com/test/guru99home/";
            driver.Manage().Window.Maximize();

            IWebElement course = driver.FindElement(By.XPath(".//*[@id='awf_field-91977689']"));

            var selectTest = new SelectElement(course);
            // Select a value from the dropdown				
            selectTest.SelectByValue("awlist4232620");

        }

        [TearDown]
        public void TearDownTest()
        {
            driver.Close();
        }




    }




}