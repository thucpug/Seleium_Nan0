using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _2CaptchaAPI._2Captcha;

namespace Selenium_Nano._2Captcha
{
    public struct ResultCapt
    {
        public readonly bool Success;
        public readonly JToken ResponseObject;

        public string ResponseJson;
        public string Response;
        public double ResponseDouble;
        public Coordinates[] ResponseCoordinates;

    }
}
