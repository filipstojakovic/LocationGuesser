using GMap.NET;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FindMyLocations.src
{
	class Utils
	{
        public static int getRandomIndex(int maxNum)
		{
            return new Random().Next(maxNum);   // [0, maxNum) 
		}



        public static string getUrlFromCoordinates(Location location)
        {
            return String.Format(@"https://www.google.com/maps?cbll={0},{1}&cbp=12,20.09,,0,5&layer=c", location.lat, location.lng);
        }

        public static PointLatLng extractLocationFromUrl(string url)
        {
            // https://www.google.com/maps?cbll={0},{1}&cbp=12,20.09,,0,5&layer=c
            //"https://www.google.com/maps/@62.7410318,14.5851076,3a,75y,355.72h,89.07t/data=!3m6!1e1!3m4!1s69XmWWlUqnbMazWMNRV8vg!2e0!7i13312!8i6656"
            const string decimalNumRegex = @"(-?\d+(\.\d+)?)";
            const string regexPattern = @"https://www.google.com/maps(/@|\?cbll=)" + decimalNumRegex + "," + decimalNumRegex + ".*";
            MatchCollection matches = new Regex(regexPattern).Matches(url);

            string latstrin = matches[0].Groups[2].Value;
            string lngstring = matches[0].Groups[4].Value;

            var lat = Convert.ToDouble(latstrin.Replace('.',','));
            var lng = Convert.ToDouble(lngstring.Replace('.', ','));
            return new PointLatLng(lat, lng);
        }


        private static void SetBrowserFeatureControlKey(string feature, string appName, uint value)
        {
            using (var key = Registry.CurrentUser.CreateSubKey(
                String.Concat(@"Software\Microsoft\Internet Explorer\Main\FeatureControl\", feature),
                RegistryKeyPermissionCheck.ReadWriteSubTree))
            {
                key.SetValue(appName, (UInt32)value, RegistryValueKind.DWord);
            }
        }

        public static void SetBrowserEmulationMode()
        {
            var fileName = System.IO.Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName);

            if (String.Compare(fileName, "devenv.exe", true) == 0 || String.Compare(fileName, "XDesProc.exe", true) == 0)
                return;
            UInt32 mode = 10000;
            SetBrowserFeatureControlKey("FEATURE_BROWSER_EMULATION", fileName, mode);
        }
    }
}
