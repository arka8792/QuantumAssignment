﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuantumPOM.POMRepositiory
{
    public class HomePage
    {
        public HomeProps Property { get; set; }
        IWebDriver driver;

        public HomePage()
        {
            Property = new HomeProps();
        }
        public void SearchHomePage()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.onemap.gov.sg/main/v2/");
            driver.FindElement(Property.CloseButton).Click();
            driver.FindElement(Property.SearchBox).SendKeys("ABCD");
            driver.FindElement(Property.Link).Click();
            driver.FindElement(Property.Menu).Click();
            Thread.Sleep(2000);
            driver.FindElement(Property.Menu).Click();
            driver.FindElement(Property.Center).Click();
            driver.FindElement(Property.Amenities).Click();
            Thread.Sleep(5000);
            driver.Quit();

        }


        public List<string> ValidateMenu()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.onemap.gov.sg/main/v2/");
            driver.FindElement(Property.CloseButton).Click();
            driver.FindElement(Property.Menu).Click();

            var menuItems = driver.FindElements(Property.MenuItemsBy);
            var menuItemTexts = new List<string>();

            foreach (var item in menuItems)
            {
                menuItemTexts.Add(item.Text);
            }

            menuItemTexts = menuItemTexts.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();

            return menuItemTexts;
        }
    }
}
