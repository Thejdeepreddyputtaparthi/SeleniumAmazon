using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System.Drawing.Imaging;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace AmazonTest
{
    [TestClass]
    public class AmazonEbayTest
    {
        [TestMethod]
        public void AmazonEbatTestMethod()
        {

            using (var driver = new ChromeDriver())
            {
                // 1. Maximize the browser
                driver.Manage().Window.Maximize();

                // 2. Go to the "Amazon" homepage
                driver.Navigate().GoToUrl("https://www.amazon.com/");

                // 3. Find the search textbox (by ID) on the homepage
                var searchBox = driver.FindElementById("twotabsearchtextbox");

                // 4. Enter the text (to search for) in the textbox
                searchBox.SendKeys("Iphone 7");


                // 5. Find the search button (by Name) on the homepage
                var searchButton = driver.FindElementById("nav-search-submit-text");

                // 6. Click "Submit" to start the search
                searchButton.Submit();

                // 7. Find the "Id" of the "Div" containing results stats,
                // located just above the results table.
                var sort = driver.FindElementById("sort");

                Actions actions = new Actions(driver);
                actions.MoveToElement(sort).Perform();

                var sortPrice = driver.FindElementByCssSelector("#sort > option:nth-child(3)");

                sortPrice.Click();
               

                IReadOnlyCollection <IWebElement> searchResults = driver.FindElementsByCssSelector("a > h2");

                IReadOnlyCollection<IWebElement> searchResultsPrice = driver.FindElementsByCssSelector("span.a-color-base.sx-zero-spacing");


                driver.Navigate().GoToUrl("https://www.ebay.com/");


                var searchBoxeBay = driver.FindElementById("gh-ac");

                searchBoxeBay.SendKeys("Iphone 7"); 

                var searchButtoneBay = driver.FindElementById("gh-btn");

                searchButtoneBay.Click();

                IReadOnlyCollection<IWebElement> searchResultseBay = driver.FindElementsByCssSelector("a > h3");


                IReadOnlyCollection<IWebElement> searchResultsPriceEBay = driver.FindElementsByCssSelector(".s-item__price");

                

            }

        }
    }
}
