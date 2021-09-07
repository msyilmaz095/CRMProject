using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Specialized;
using System.Web;


namespace Alaca.Core.Utilities.Extension
{
    public static class ExtensionMethods
    {
        public static NameValueCollection QueryString(this NavigationManager navigationManager)
        {
            return HttpUtility.ParseQueryString(new Uri(navigationManager.Uri).Query);
        }

        public static string QueryString(this NavigationManager navigationManager, string key)
        {
            return navigationManager.QueryString()[key];
        }

        public static string QueryStringGG(this String cc, int key)
        {
            switch (key)
            {
                case 1:
                    return "Bir";
                    break;
                case 2:
                    return "İki";
                    break;
                case 3:
                    break;
                default:
                    return "İç";
                    break;
            }
            return "Sıfır";
        }
    }

}