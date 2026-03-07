using System;
using System.Collections.Generic;
using System.Text;

namespace CountryCodeValidation
{
    public class InvalidCodeException : Exception
    {
        public InvalidCodeException(string message) : base(message)
        {
        }
    }

    public class Repository
    {
        public static string GetCountryName(string countryCode)
        {
            int code = int.Parse(countryCode);

            if (code >= 70 && code <= 99)
                return "India";

            if (code == 908)
                return "US";

            if (code == 011)
                return "Dial somewhere outside of USA";

            throw new InvalidCodeException("Invalid Country Code");
        }
    }

    public class RepositoryImplementation
    {
        public static string GetCountry(string countryCode)
        {
            return Repository.GetCountryName(countryCode);
        }
    }
}
