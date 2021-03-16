﻿using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMyLocations.src
{
	class MapModel
	{
		private GMapControl map;

		private GMapOverlay markersOverlay;
		private GMapOverlay polygonOverlay;

		public MapModel(ref GMapControl map)
		{
			this.map = map;
			markersOverlay = new GMapOverlay(Constants.markerOverlayName);
			polygonOverlay = new GMapOverlay(Constants.polygonOverlayName);
		}

		public GMapMarker placeMarkerOnMap(PointLatLng location)
		{
			GMapMarker tmpMarker = new GMarkerGoogle(location, GMarkerGoogleType.red_pushpin);
			map.Overlays.Add(markersOverlay);
			markersOverlay.Markers.Add(tmpMarker);
			return tmpMarker;
		}

		public GMapPolygon drawPolyline(PointLatLng start, PointLatLng end)
		{
			IList<PointLatLng> points = new List<PointLatLng>() { start, end };
			GMapPolygon polygon = new GMapPolygon((List<PointLatLng>)points, "mypolygon");
			polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
			polygon.Stroke = new Pen(Color.Red, 1);
			map.Overlays.Add(polygonOverlay);
			polygonOverlay.Polygons.Add(polygon);
			return polygon;
		}

		//very complex method for calculating distance
		public string calculateDistance(GMapPolygon polygon)
		{
			return String.Format("{0:0.##}", polygon.Distance);     // distance in km
		}

		public void defaultMapPosition()
		{
			map.Position = new PointLatLng(33.1375511923461,-10.546875);
			map.Zoom = Constants.MIN_ZOOM;
		}

		public void zoomToCoverMarkers()
		{
			map.ZoomAndCenterMarkers(Constants.markerOverlayName);
		}

		internal void initMap()
		{
			map.MapProvider = GMapProviders.GoogleMap;
			map.DragButton = MouseButtons.Left; // enable dragging
			map.MouseWheelZoomEnabled = true;
			map.MinZoom = Constants.MIN_ZOOM;
			map.MaxZoom = Constants.MAX_ZOOM;
			map.Zoom = Constants.MIN_ZOOM;
			map.ShowCenter = true;
		}

		public void removeMarker(GMapMarker marker)
		{
			if (marker != null)
				markersOverlay.Markers.Remove(marker);
		}

		public void removePolygon(GMapPolygon polygon)
		{
			if (polygon != null)
				polygonOverlay.Polygons.Remove(polygon);
		}
	}
}
