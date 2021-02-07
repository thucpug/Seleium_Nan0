using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leaf.xNet;
using Newtonsoft.Json;

namespace Selenium_Nano._2Captcha
{
    public class ByPassHCaptchaByAPIPHP
    {
        public readonly static string APIKEY = "2a81c246e112362de84594b056c80704";
        public static string GetSiteKeyResult(string SiteKey, string urlSite)
        {
            HttpRequest httpRequest = new HttpRequest();
            var res = httpRequest.Get($"http://2captcha.com/in.php?key={APIKEY}&method=hcaptcha&sitekey={SiteKey}&pageurl={urlSite}").ToString();
            //string id = JsonConvert.DeserializeObject<JsonGetSiteKey>(res).request;
            return res.Split('|')[1];
        }

        public static string GetResult(string idRequest)
        {
            HttpRequest httpRequest = new HttpRequest();
            var res = httpRequest.Get($"http://2captcha.com/res.php?key={APIKEY}&action=get&id={idRequest}").ToString();
        
            return res;
        }
    }
}

public class JsonGetSiteKey
{
    public int status { get; set; }
    public string request { get; set; }
}
