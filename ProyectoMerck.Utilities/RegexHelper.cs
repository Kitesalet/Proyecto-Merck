using Microsoft.Extensions.Configuration;
using ProyectoMerck.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProyectoMerck.Utilities
{
    public class RegexHelper : IRegexHelper
    {

        private string _emailRegex { get; set; }

        public RegexHelper(IConfiguration configuration)
        {
            _emailRegex = configuration["Regex:EmailRegex"];
        }

        public bool ValidEmail(string email)
        {

            if (String.IsNullOrEmpty(email))
            {
                return false;
            }

            Regex regex = new Regex(_emailRegex);

            if(!regex.IsMatch(email))
            {
                return false;
            }

            return true;

        }
    }
}
