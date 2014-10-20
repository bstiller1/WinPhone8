using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MapApp.Resources;
using System.Device.Location;
using Windows.Devices.Geolocation;
using Microsoft.Phone.Maps.Services;
using Microsoft.Phone.Maps.Controls;
using Microsoft.Phone.Tasks;


namespace MapApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        List<GeoCoordinate> MyCoordinates = new List<GeoCoordinate>();
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            MapsDirectionsTask mapsDirectionsTask = new MapsDirectionsTask();

            // You can specify a label and a geocoordinate for the end point.
            // GeoCoordinate spaceNeedleLocation = new GeoCoordinate(47.6204,-122.3493);
            // LabeledMapLocation spaceNeedleLML = new LabeledMapLocation("Space Needle", spaceNeedleLocation);

            // If you set the geocoordinate parameter to null, the label parameter is used as a search term.
            LabeledMapLocation spaceNeedleLML = new LabeledMapLocation("Space Needle", null);

            mapsDirectionsTask.End = spaceNeedleLML;

            // If mapsDirectionsTask.Start is not set, the user's current location is used as the start point.

            mapsDirectionsTask.Show(); 

        }
        
    }
}