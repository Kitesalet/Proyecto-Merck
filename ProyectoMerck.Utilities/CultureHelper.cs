using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMerck.Utilities
{
    public static class CultureHelper
    {

        public static string GetCultureFromCookie(string cookieString)
        {

            string culture = cookieString;

            string[] culturePart = culture.Split('|');

            string realCulture = culturePart[0].Substring(2);

            return realCulture;
        }

    }
}
