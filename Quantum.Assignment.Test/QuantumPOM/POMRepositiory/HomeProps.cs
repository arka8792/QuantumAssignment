using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumPOM.POMRepositiory
{
    public class HomeProps
    {
        public static string Search = "search-text";
        public By SearchBox = By.Id(Search);

        public static string CloseAd = "my-text";
        public By CloseButton = By.Id(CloseAd);

        public static string CovidLink = "PCRTDisplay";
        public By Link = By.Id(CovidLink);

        public static string MoreMenu = "widgetbar";
        public By Menu = By.Id(MoreMenu);

        
        public static string VaccinationCenter = "VaccinationDisplay";
        public By Center = By.Id(VaccinationCenter);

        public static string EssentialAmenities = "EssDisplay";
        public By Amenities = By.Id(EssentialAmenities);

        public static string MenuItems = "//span[@class='topView_text']";
        public By MenuItemsBy = By.XPath(MenuItems);

        public static string CovidMessageLink = "//div[@class='DroneCheckBox']//a";
        public By CovidMessageLinkBy = By.XPath(CovidMessageLink);

        public static string VaccinationCenterLink = "//a[contains(text(),'www.vaccine.gov.sg')]";
        public By VaccinationCenterLinkBy = By.XPath(VaccinationCenterLink);

        public static string SearchText = "search-text";
        public By SearchTextBy = By.XPath(SearchText);

        public static string CardTitle = "//div[@id='start_marker']//p[@class='block wrap']";
        public By CardTitleBy = By.XPath(CardTitle);

        public static string EssentialAmenitiesTab = "EssDisplay";
        public By EssentialAmenitiesTabBy = By.Id(EssentialAmenitiesTab);

        public static string ConfirmationCard = "//div[@class='swal2-buttonswrapper']//button";
        public By ConfirmationCardBy = By.XPath(ConfirmationCard);

        public static string IndividualTab = "//div[@class='DroneThemeNames ng-binding']";
        public By IndividualTabBy = By.XPath(IndividualTab);

    }
}
