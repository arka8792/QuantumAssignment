using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuantumPOM.POMRepositiory;
using AventStack.ExtentReports;
using System.IO;
using AventStack.ExtentReports.Reporter;

namespace Quantum.Assignment
{
    [TestFixture]
    public class QuantumTests : WebBaseTest
    {
        ExtentReports extentReports = null;

        [OneTimeSetUp]
        public void ExtentStart()
        {
            extentReports = new ExtentReports();
            var binPath = AppDomain.CurrentDomain.BaseDirectory;
            var filePath = string.Concat(binPath, "\\QuantumAssignment.html");
            var htmlReporter = new ExtentHtmlReporter(filePath);
            extentReports.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extentReports.Flush();
        }

        [Test]
        public void QTM_Assignment_ValidateMenu()
        {
            IWebDriver driver = null;
            ExtentTest report = null;
            try
            {

                report = extentReports.CreateTest("QTM_Assignment_ValidateMenu").Info("Starting Menu Validation Test");

                driver = LaunchApplication();
                report.Log(Status.Info, "Application launched");

                HomePage home = new HomePage();
                var isEqual = home.ValidateMenu(driver);

                report.Log(Status.Info, "Menu Items Validated");

                Assert.That(isEqual, Is.True, "Menu Items not displayed properly");

                report.Log(Status.Pass, "QTM_Assignment_ValidateMenu Passed");
            }
            finally
            {
                Cleanup();
            }
        }

        [Test]
        public void QTM_Assignment_ValidateLinkText()
        {
            var driver = LaunchApplication();
            try
            {
                HomePage home = new HomePage();
                var isEqual = home.ValidateLinkText(driver);
                Assert.That(isEqual, Is.True, "Link is not visible properly");

            }
            finally
            {
                Cleanup();
            }
        }

        [Test]
        public void QTM_Assignment_validateVaccinationLinkText()
        {
            var driver = LaunchApplication();
            try
            {
                HomePage home = new HomePage();
                var isEqual = home.validateVaccinationLink(driver);
                Assert.That(isEqual, Is.True, "Link is not visible on the screen");

            }
            finally
            {
                Cleanup();
            }
        }

        [Test]
        public void QTM_Assignment_CardTitleText()
        {
            var driver = LaunchApplication();
            try
            {
                HomePage home = new HomePage();
                var isEqual = home.ValidateSearchText(driver);
                Assert.That(isEqual, Is.True, "Pointer is not visible with details");

            }
            finally
            {
                Cleanup();
            }
        }

        [Test]
        public void QTM_Assignment_EssentialAmenities()
        {
            var driver = LaunchApplication();
            try
            {
                HomePage home = new HomePage();
                var isEqual = home.validateAmenities(driver);
                Assert.That(isEqual, Is.True, "List is not visible");

            }
            finally
            {
                Cleanup();
            }
        }
    }
}

