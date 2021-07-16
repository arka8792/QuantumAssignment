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

            IWebDriver driver = null;
            ExtentTest report = null;

            try
            {
                report = extentReports.CreateTest("QTM_Assignment_ValidateLinkText").Info("Starting Link Validation Test");
                driver = LaunchApplication();
                report.Log(Status.Info, "Application launched");

                HomePage home = new HomePage();
                var isEqual = home.ValidateLinkText(driver);

                report.Log(Status.Info, "LinkText is Validated");

                Assert.That(isEqual, Is.True, "Link is not visible properly");
                report.Log(Status.Pass, "QTM_Assignment_ValidateLinkText Passed");

            }
            finally
            {
                Cleanup();
            }
        }

        [Test]
        public void QTM_Assignment_validateVaccinationLinkText()
        {

            IWebDriver driver = null;
            ExtentTest report = null;
            
            try
            {
                report = extentReports.CreateTest("QTM_Assignment_validateVaccinationLinkText").Info("Starting VaccinationLink Validation Test");
                driver = LaunchApplication();
                report.Log(Status.Info, "Application launched");

                HomePage home = new HomePage();
                var isEqual = home.validateVaccinationLink(driver);

                report.Log(Status.Info, "VaccinationLink is Validated");


                Assert.That(isEqual, Is.True, "Link is not visible on the screen");
                report.Log(Status.Pass, "QTM_Assignment_VaccinationLink Passed");

            }
            finally
            {
                Cleanup();
            }
        }

        [Test]
        public void QTM_Assignment_CardTitleText()
        {
            IWebDriver driver = null;
            ExtentTest report = null;
            
            try
            {
                report = extentReports.CreateTest("QTM_Assignment_ValidateCardTitleText").Info("Starting CardTitleText Validation Test");
                driver = LaunchApplication();
                report.Log(Status.Info, "Application launched");

                HomePage home = new HomePage();
                var isEqual = home.ValidateSearchText(driver);

                report.Log(Status.Info, "CardTitleText is Validated");

                Assert.That(isEqual, Is.True, "Pointer is not visible with details");
                report.Log(Status.Pass, "QTM_Assignment_CardTitleText Passed");

            }
            finally
            {
                Cleanup();
            }
        }

        [Test]
        public void QTM_Assignment_EssentialAmenities()
        {
            IWebDriver driver = null;
            ExtentTest report = null;
            
            try
            {
                report = extentReports.CreateTest("QTM_Assignment_ValidateEssentialAmenities").Info("Starting EssentialAmenities Validation Test");
                driver = LaunchApplication();
                report.Log(Status.Info, "Application launched");

                HomePage home = new HomePage();
                var isEqual = home.validateAmenities(driver);

                report.Log(Status.Info, "EssentialAmenities is Validated");

                Assert.That(isEqual, Is.True, "List is not visible");
                report.Log(Status.Pass, "QTM_Assignment_EssentialAmenities Passed");

            }
            finally
            {
                Cleanup();
            }
        }
    }
}

