using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using Selenium_Nano._2Captcha;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Selenium_Nano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ChromeDriver chromeDriver;
        string ProfileFolderPath = "Profile";
        string ExtentionFolderPath = "Extention";
        public void SetValueForAttribute()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)chromeDriver;
            js.ExecuteScript(@"document.getElementsByName(""h-captcha-response"").setAttribute('style', '10')");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            if (chromeDriver != null)
            {
                try
                {
                    chromeDriver.Close();
                    chromeDriver.Quit();
                }
                catch (Exception ex)
                {
                }
            }

            ChromeOptions options = new ChromeOptions();

            if (!Directory.Exists(ProfileFolderPath))
            {
                Directory.CreateDirectory(ProfileFolderPath);
            }

            if (Directory.Exists(ProfileFolderPath))
            {
                var foldesChild = Directory.GetDirectories(ProfileFolderPath).Count();
                int nameCount = foldesChild++;

                options.AddArguments("user-data-dir=" + ProfileFolderPath + "\\" + nameCount);
            }

            var temp = "zproxy.lum-superproxy.io:22225:lum-customer-hl_73c21fb6-zone-zone2-ip-178.171.0.70:740ux8jhaur6".Split(':');

            var proxy = new
            {
                Ip = temp[0],
                Username = temp[2],
                Password = temp[3],
                Port = temp[1]
            };
            if (!string.IsNullOrEmpty(proxy.Ip))
            {
                if (!string.IsNullOrEmpty(proxy.Username) && !string.IsNullOrEmpty(proxy.Password))
                {
                    options.AddExtension(ExtentionFolderPath + "\\Crx4Chrome.com.crx");
                }
                options.AddArgument(string.Format("--proxy-server={0}", proxy.Ip + $":{proxy.Port}"));
            }


            //List<String> ext = new List<string>();
            //byte[] byteExt = File.ReadAllBytes(ExtentionFolderPath + "\\WebRTC.crx");
            //ext.Add(Convert.ToBase64String(byteExt));
            options.AddExtension(ExtentionFolderPath + "\\WebRTC.crx");

            chromeDriver = new ChromeDriver(options);
            if (!string.IsNullOrEmpty(proxy.Ip))
            {
                if (!string.IsNullOrEmpty(proxy.Username) && !string.IsNullOrEmpty(proxy.Password))
                {
                    chromeDriver.Url = "chrome-extension://ggmdpepbjljkkkdaklfihhngmmgmpggp/options.html";
                    chromeDriver.Navigate();

                    chromeDriver.FindElement(By.Id("login")).SendKeys(proxy.Username);
                    chromeDriver.FindElement(By.Id("password")).SendKeys(proxy.Password);
                    chromeDriver.FindElement(By.Id("retry")).Clear();
                    chromeDriver.FindElement(By.Id("retry")).SendKeys("10");

                    chromeDriver.FindElement(By.Id("save")).Click();
                }
            }



            #region xxx
            chromeDriver.Url = "https://playnano.online/login/";
            chromeDriver.Navigate();

            var account = new { mail = "ygg15179@eoopy.com", pass = "trinh123" };
            var inputEmail = chromeDriver.FindElement(By.Id("user_email"));
            var inputPass = chromeDriver.FindElement(By.Id("user_password"));
            inputEmail.SendKeys(account.mail);
            inputPass.SendKeys(account.pass);
            chromeDriver.FindElement(By.XPath(@"//*[@id=""new_user""]/div[3]/div/input")).Click();


            try
            {
                ScrollTo(chromeDriver.FindElement(By.XPath(@"//*[@id=""features""]/div/div/div[1]/div/div[1]/a/div"))).Click();
                ScrollTo(chromeDriver.FindElement(By.Id(@"watch-link"))).Click();
                var startVideo = ScrollTo(chromeDriver.FindElement(By.XPath(@"/html/body/main/section/div/div[2]/div[1]/div[3]/div/form")));
                startVideo.Submit();
            }
            catch (Exception)
            {

            }
            NextMax:
            bool isNext = NextMax(5);
            #region SolverCapt
            try
            {

                var IdKey = chromeDriver.FindElement(By.XPath(@"/html/body/main/section/div/div[2]/div[1]/form/div[1]/div/div")).GetAttribute("data-sitekey");
                Hcaptcha_2CaptchaKteam hcaptcha = new Hcaptcha_2CaptchaKteam("d852f98cc988c9b50db00f69227468a6", "https://playnano.online/watch-and-learn/nano/captcha");
                string captpChaToken;
                bool isSolver = hcaptcha.SolveHcaptcha(IdKey, out captpChaToken);
                chromeDriver.ExecuteScript($"var vcaptcha = document.getElementsByTagName(\"textarea\"); vcaptcha[0].innerText=\"{captpChaToken}\"; vcaptcha[1].innerText=\"{captpChaToken}\";");
                var button = ScrollTo(chromeDriver.FindElement(By.CssSelector(@"#watch-videos > div > div:nth-child(2) > div.col-12.col-lg-8 > form > div:nth-child(4) > div:nth-child(1) > button")));
                button.Submit();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            #endregion

            CheckElement:
            try
            {
                // clickEarnAndContinueWatch();
                var a = chromeDriver.FindElement(By.CssSelector(@"#next-video-form > button"));
                goto NextMax;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("no such element"))
                {
                    Thread.Sleep(2000);
                    goto CheckElement;
                }
            }
            //no such element
            #endregion

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = chromeDriver.PageSource;
            chromeDriver.Navigate().Back();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var account = new { mail = "jpy82845@eoopy.com", pass = "thuc123" };
            var inputEmail = chromeDriver.FindElement(By.Id("user_email"));
            var inputPass = chromeDriver.FindElement(By.Id("user_password"));
            inputEmail.SendKeys(account.mail);
            inputPass.SendKeys(account.pass);
            chromeDriver.FindElement(By.XPath(@"//*[@id=""new_user""]/div[3]/div/input")).Click();
            //Thread.Sleep(8000);
            //var element = chromeDriver.FindElement(By.XPath(@"//*[@id=""features""]/div/div/div[1]/div/div[1]/a/div"));

            //Actions actions = new Actions(chromeDriver);

            //actions.MoveToElement(element).Click().Perform();
        }

        private void btnEarn_Click(object sender, EventArgs e)
        {
            try
            {
                IJavaScriptExecutor jse = (IJavaScriptExecutor)chromeDriver;

                // jse.ExecuteScript("scroll(250, 0)"); // if the element is on top.

                jse.ExecuteScript("scroll(0, 250)"); // if the element is on bottom.
                chromeDriver.FindElement(By.XPath(@"//*[@id=""features""]/div/div/div[1]/div/div[1]/a/div"));
                var element = chromeDriver.FindElement(By.XPath(@"//*[@id=""features""]/div/div/div[1]/div/div[1]/a/div"));

                Actions actions = new Actions(chromeDriver);

                actions.MoveToElement(element).Click().Perform();

                Thread.Sleep(1000);
                jse.ExecuteScript("scroll(0, 250)"); // if the element is on bottom.
                chromeDriver.FindElement(By.Id(@"watch-link")).Click();
                Thread.Sleep(1000);
                jse.ExecuteScript("scroll(0, 1000)");
                chromeDriver.FindElement(By.XPath(@"/html/body/main/section/div/div[2]/div[1]/div[3]/div/form")).Submit();
            }
            catch (Exception)
            {

            }

            bool isNext = NextMax(5);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int max = 5;
            IJavaScriptExecutor jse = (IJavaScriptExecutor)chromeDriver;
            while (max > 0)
            {

                var data = chromeDriver.FindElement(By.CssSelector(@"#next-video-form > button"));
                var x = data.GetAttribute("disabled");
                if (string.IsNullOrEmpty(x))
                {
                    //jse.ExecuteScript("scroll(0, 2000)"); // if the element is on bottom.
                    //jse.ExecuteScript("scroll(0, 2000)");
                    data = ScrollTo(data);
                    data.Click();
                    max--;
                }
                Thread.Sleep(2000);
            }

        }
        bool NextMax(int max)
        {
            int maxStep = max;
            IJavaScriptExecutor jse = (IJavaScriptExecutor)chromeDriver;
            while (maxStep > 0)
            {
                var data = chromeDriver.FindElement(By.CssSelector(@"#next-video-form > button"));
                var x = data.GetAttribute("disabled");
                if (string.IsNullOrEmpty(x))
                {
                    //jse.ExecuteScript("scroll(0, 2000)"); // if the element is on bottom.
                    //jse.ExecuteScript("scroll(0, 2000)");
                    // ((IJavaScriptExecutor)chromeDriver).ExecuteScript("window.scrollTo(0, document.body.scrollHeight - 150)");
                    data = ScrollTo(data);
                    data.Click();
                    maxStep--;
                }
                Thread.Sleep(2000);
            }
            return true;
        }
        private void btnCheckBoxCaptcha_Click(object sender, EventArgs e)
        {
            clickFrameCheckBox();
        }
        public void clickFrameCheckBox()
        {
            var iframeCapt = chromeDriver.FindElement(By.XPath("/html/body/main/section/div/div[2]/div[1]/form/div[1]/div/div/iframe"));
            chromeDriver.SwitchTo().Frame(iframeCapt);
            chromeDriver.FindElement(By.Id(@"checkbox")).Click();
        }
        public IWebElement ScrollTo(IWebElement element)
        {
            chromeDriver.ExecuteScript("arguments[0].scrollIntoView(true);", element);
            return element;
        }
        private void clickEarnAndContinueWatch()
        {
            CheckEarnCapt:
            try
            {
                //var iframeCapt = chromeDriver.FindElement(By.XPath("/html/body/main/section/div/div[2]/div[1]/form/div[1]/div/div/iframe"));
                //chromeDriver.SwitchTo().Frame(iframeCapt);
                //var CaptchaVerify = chromeDriver.FindElement(By.XPath("/html/body/div/div[1]/div[1]/div[1]/div[2]"));
                //var str = CaptchaVerify.GetAttribute("innerHTML");
                //Console.WriteLine(str);
                //if (str.Contains("You are verified"))
                //{
                //   // Console.WriteLine("verified");
                //    chromeDriver.SwitchTo().DefaultContent();
                chromeDriver.FindElement(By.XPath(@"/html/body/main/section/div/div[2]/div[1]/form/div[2]/div[1]/button")).Submit();
                // }
            }
            catch (Exception ex)
            {
                Thread.Sleep(1000);
                goto CheckEarnCapt;
            }

        }

        private void btnClaimAndContinue_Click(object sender, EventArgs e)
        {
            clickEarnAndContinueWatch();
        }
    }
}
