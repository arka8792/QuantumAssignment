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
    public class QuantumTests
    {
        private List<string> expectedList = new List<string> {        
            "Vaccination Centres","COVID-19 Test Providers", "Nearby Parks",
            "Essential Amenities (2km)", "SchoolQuery", "PHPC near you",
            "LandQuery","DroneQuery","TrafficQuery", "PropertyQuery",
            "PopulationQuery","Nearby","BizQuery","Bus Explorer",
            "Basemaps","Gallery"
        };

        [Test]
        public void Sample()
        {
            HomePage home = new HomePage();
            home.SearchHomePage();            
        }

        [Test]
        public void QTM_Assignment_ValidateMenu()
        {
            HomePage home = new HomePage();
            var actualList = home.ValidateMenu();
            CollectionAssert.AreEqual(expectedList, actualList);
        }
    }
}
