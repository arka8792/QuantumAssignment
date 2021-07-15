using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuantumPOM.POMRepositiory;

namespace Quantum.Assignment
{
    [TestFixture]
    public class QuantumTests : WebBaseTest
    {
        

        [Test]
        public void Sample()
        {
            HomePage home = new HomePage();
            home.SearchHomePage();            
        }

        [Test]
        public void QTM_Assignment_ValidateMenu()
        {
            var driver = LaunchApplication();
            try
            {
                HomePage home = new HomePage();
                var isEqual = home.ValidateMenu(driver);
                Assert.That(isEqual, Is.True, "Menu Items not displayed properly");
            }
            finally
            {
                Cleanup();
            }
        }
    }
}
