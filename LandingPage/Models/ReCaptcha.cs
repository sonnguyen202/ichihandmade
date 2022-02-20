using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LandingPage.Models
{
    public class ReCaptcha
    {
        public readonly string SiteKey = "6LfMeisdAAAAAM-_Rb0f5zbwMZkPSfdbcd8_1Tno";
        public readonly string SecretKey = "6LfMeisdAAAAADgFDrtb7pMlNnBFbLusqkMYRqM1";
        public string Response { get; set; }
    }
}
