using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;

namespace Selenium_Learning.BrowserInitialization
{
    internal class DriverProperties
    {
        // Please read the Driver Proerties doc 
        // https://github.com/Bala-Murugan473/Selenium_Learning/blob/main/BrowserInitialization/DriverProperties.md

        public static void Main()
        {
            // Create Driver Instance
            IWebDriver Driver = new ChromeDriver();

            // To navigate to the given url
            Driver.Url = "https://www.selenium.dev/";

            // To get the current url
            string current_url = Driver.Url;
            Console.WriteLine("\nCurrent URL in tab : "+current_url);

            // To get the current title
            string title = Driver.Title;
            Console.WriteLine("\nTitle of the page : " + title);

            // To get the current url
            string pageSource = Driver.PageSource;
            // page source print vast text
            Console.WriteLine("\nPage Source or DoM : " + pageSource);

            // To get the current tab id
            string current_window_id = Driver.CurrentWindowHandle;
            Console.WriteLine("\nCurrent Window Id : " + current_window_id);

            // To get all tabs/windows id
            ReadOnlyCollection<string> lst_ids = Driver.WindowHandles;
            Console.WriteLine("\nList of tab/window id:");
            foreach (var item in lst_ids)
            {
                Console.WriteLine(item);
            }
            //Note: we will get only one Id here, because only one tab is opened by driver
        }
    }
}
