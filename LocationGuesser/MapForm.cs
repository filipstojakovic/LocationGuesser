﻿using FindMyLocations.src;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Location = FindMyLocations.src.Location;

namespace FindMyLocations
{
	public partial class MapForm : Form
	{
		//TODO: reset map to default location
		//TODO: reset distace text
		private static string currentUrl;
		private List<Location> locations;

		private MapModel mapModel;

		private GMapMarker currentLocationMarker; // your position on map
		private GMapMarker chosenLocationMarker;	// onMapClicked position
		private GMapPolygon polygon;

		public MapForm()
		{
			Utils.SetBrowserEmulationMode();
			InitializeComponent();

			mapModel = new MapModel(ref map);
			locations = new LocationGrabber().getAllLocations();
			initRandomStreetLocation();
			initializeMap();
		}

		private void initRandomStreetLocation()
		{
			Location randomLocation = getAndPopRandomLocation();
			navigateToLocation(randomLocation);
		}

		private Location getAndPopRandomLocation()
		{
			int randIndex = Utils.getRandomIndex(locations.Count);
			Location location = locations[randIndex];
			locations.RemoveAt(randIndex);
			return location;
		}

		private void navigateToLocation(Location location)
		{
			string randomLocationUrl = Utils.getUrlFromCoordinates(location);
			webBrowser.Navigate(randomLocationUrl);
			webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
			webBrowser.WebBrowserShortcutsEnabled = false;  //disable keyboard
			webBrowser.Navigated += WebBrowser_Navigated;   //saving urls that dont contain place in url (that is marker)
		}

		private void initializeMap()
		{
			mapModel.initMap();
			map.OnMapClick += Map_OnMapClick;
		}

		private void Map_OnMapClick(PointLatLng pointClick, MouseEventArgs e)
		{
			mapModel.removeMarker(chosenLocationMarker);
			chosenLocationMarker = mapModel.placeMarkerOnMap(pointClick);
			Console.WriteLine(chosenLocationMarker.Position);
		}

		//chose new location clicked
		private void newLocation_Click(object sender, EventArgs e)
		{
			((Control)webBrowser).Enabled = true;
			map.OnMapClick += Map_OnMapClick;
			distanceLbl.Visible = false;

			mapModel.removeMarker(currentLocationMarker);
			mapModel.removeMarker(chosenLocationMarker);
			mapModel.removePolygon(polygon);

			mapModel.defaultMapPosition();
			initRandomStreetLocation();
		}


		private void chooseBtn_Click(object sender, EventArgs e)
		{
			if (chosenLocationMarker == null)
			{
				MessageBox.Show("Please select location first", "Need location"
					, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			var location = Utils.extractLocationFromUrl(currentUrl);
			currentLocationMarker = mapModel.placeMarkerOnMap(location);

			this.polygon = mapModel.drawPolyline(chosenLocationMarker.Position, currentLocationMarker.Position);
			mapModel.zoomToCoverMarkers();

			distanceLbl.Visible = true;
			distanceLbl.Text = mapModel.calculateDistance(polygon) + " km";

			map.OnMapClick -= Map_OnMapClick;
			((Control)webBrowser).Enabled = false;
		}

		//saving urls that do NOT contain string "place" (coz that is marker)
		private void WebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			var url = webBrowser.Url.ToString();
			if (!url.Contains("place"))
			{
				currentUrl = url;
			}
			else
				webBrowser.Navigate(currentUrl);
		}

		//hide helpful elements/attributes
		private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			var doc = webBrowser.Document as HtmlDocument;
			var links = doc.GetElementsByTagName("div");
			foreach (HtmlElement link in links)
			{
				if (link.GetAttribute("className") == "app-viewcard-strip"
					|| link.GetAttribute("id") == "titlecard"
					|| link.GetAttribute("id") == "image-header"
					|| link.GetAttribute("id") == "fineprint"
					)
				{
					link.Style = "display:none";
				}
			}
		}

	}
}