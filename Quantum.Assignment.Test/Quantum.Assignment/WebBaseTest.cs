﻿using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum.Assignment
{
    public class WebBaseTest
    {
        IWebDriver driver;
        ExtentReports extentReports = null;
        public IWebDriver LaunchApplication()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.onemap.gov.sg/main/v2/");
            return driver;
        }

        public void Cleanup()
        {
            driver.Close();
        }

        
    }
}
