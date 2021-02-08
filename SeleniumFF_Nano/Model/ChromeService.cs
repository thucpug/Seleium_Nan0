using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumFF_Nano.Services.UtilsByMe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumFF_Nano.Model
{
    public class ChromeService
    {
        private ChromeDriver Chrome { get; set; }
        public string Proxy { get; set; }

        public ChromeService(ChromeOptions options)
        {
            Chrome = new ChromeDriver(options);
        }
        public IWebElement ScrollTo(IWebElement element)
        {
            Chrome.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }
        public bool NextStepOfVideo(int stepCount)
        {
            int maxStep = stepCount;
            while (maxStep > 0)
            {
                var data = Chrome.FindElement(By.CssSelector(@"#next-video-form > button"));
                var x = data.GetAttribute("disabled");
                if (string.IsNullOrEmpty(x))
                {
                    data = ScrollTo(data);
                    data.Click();
                    maxStep--;
                }
                Thread.Sleep(2000);
            }
            return true;
        }
        public dynamic ExcuteJs(ChromeDriver chrome,string Js)
        {
            return chrome.ExecuteScript(Js);
        }
        public void AddExtentionProxyChrome(ChromeOptions options, string pathExtention, ProxyModel proxy)
        {
            if (!string.IsNullOrEmpty(proxy.Ip))
            {
                if (!string.IsNullOrEmpty(proxy.Username) && !string.IsNullOrEmpty(proxy.Password))
                {
                    options.AddExtension(pathExtention);
                }
                options.AddArgument(string.Format("--proxy-server={0}", proxy.Ip + $":{proxy.Port}"));
            }
        }
        public void AddExtentionChrome(ChromeOptions options, string pathExtention)
        {
            options.AddExtension(pathExtention);
        }
        public void SetCredentialForChrome(ProxyModel proxy)
        {
             if (!string.IsNullOrEmpty(proxy.Ip))
            {
                if (!string.IsNullOrEmpty(proxy.Username) && !string.IsNullOrEmpty(proxy.Password))
                {
                    Chrome.Url = "chrome-extension://ggmdpepbjljkkkdaklfihhngmmgmpggp/options.html";
                    Chrome.Navigate();

                    Chrome.FindElement(By.Id("login")).SendKeys(proxy.Username);
                    Chrome.FindElement(By.Id("password")).SendKeys(proxy.Password);
                    Chrome.FindElement(By.Id("retry")).Clear();
                    Chrome.FindElement(By.Id("retry")).SendKeys("10");
                    Chrome.FindElement(By.Id("save")).Click();
                }
            }
        }
    }
}
