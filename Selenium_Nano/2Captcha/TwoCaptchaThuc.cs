using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Nano._2Captcha
{
    public class TwoCaptchaThuc
    {
        _2CaptchaAPI._2Captcha captcha;
        _2CaptchaAPI._2Captcha captchaCustomHttp;
        public string PropertyToSet = "data-hcaptcha-response";
        public static string apiKey2Captcha = "2a81c246e112362de84594b056c80704";
        public TwoCaptchaThuc(string apiKey,string urlSet)
        {
            captcha = new _2CaptchaAPI._2Captcha(apiKey);
            captchaCustomHttp = new _2CaptchaAPI._2Captcha(apiKey, new HttpClient());
           // captcha.SetApiUrl(urlSet);
        }
        public async Task<_2CaptchaAPI._2Captcha.Result> SolverCaptchaAsync(string siteKey, string urlSite)
        {
            var hCaptcha = await captcha.SolveHCaptcha(siteKey, urlSite);
            return hCaptcha;
        }

    }
}
