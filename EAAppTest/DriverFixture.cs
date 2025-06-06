using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Safari;
using System;

namespace EAAppTest
{
    public class DriverFixture : IDisposable
    {
        RemoteWebDriver? driver;

        public void Setup(BrowserType browserType)
        {
            int retries = 5;
            Exception? lastException = null;

            for (int i = 0; i < retries; i++)
            {
                try
                {
                    driver = new RemoteWebDriver(
                        new Uri("http://selenium-hub:4444/wd/hub"),
                        GetBrowserOptions(browserType));
                    return; // Exit if driver is successfully initialized
                }
                catch (Exception ex)
                {
                    lastException = ex;
                    System.Threading.Thread.Sleep(5000); // Wait before retrying
                }
            }

            throw new InvalidOperationException("Driver initialization failed after retries", lastException);
        }

        // This solution provided by co-pilot.
        public RemoteWebDriver Driver => driver ?? throw new InvalidOperationException("Driver is not initialized. Call Setup() before accessing the Driver.");

        private dynamic GetBrowserOptions(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Firefox:
                    {
                        var firefoxOption = new FirefoxOptions();
                        firefoxOption.AddAdditionalOption("se:recordVideo", true);
                        return firefoxOption;
                    }
                case BrowserType.Edge:
                    return new EdgeOptions();
                case BrowserType.Safari:
                    return new SafariOptions();
                case BrowserType.Chrome:
                    {
                        var chromeOption = new ChromeOptions();
                        chromeOption.AddAdditionalOption("se:recordVideo", true);
                        return chromeOption;
                    }
                default:
                    return new ChromeOptions();
            }
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }

    public enum BrowserType
    {
        Chrome,
        Firefox,
        Safari,
        Edge
    }
}
