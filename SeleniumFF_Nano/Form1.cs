using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeleniumFF_Nano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        IWebDriver firefoxDriver;

        private void Form1_Load(object sender, EventArgs e)
        {
            //FirefoxOptions firefoxProfile = new FirefoxOptions();

            //#region fakeProxy
            //firefoxProfile.SetPreference("network.proxy.type", 1);
            //firefoxProfile.SetPreference("network.proxy.http", "zproxy.lum-superproxy.io");
            //firefoxProfile.SetPreference("network.proxy.http_port", 22225);
            //firefoxProfile.SetPreference("network.proxy.ssl", "zproxy.lum-superproxy.io");
            //firefoxProfile.SetPreference("network.proxy.ssl_port", 22225);
            //firefoxProfile.SetPreference("network.proxy.no_proxies_on", "add website url(s)");
            //#endregion

            ////firefoxProfile.SetPreference("media.peerconnection.enabled", false);

            //// khởi tạo WebDriver
            //firefoxDriver = new FirefoxDriver(firefoxProfile);

            //// chuyển trang đến website howkteam.com
            //firefoxDriver.Url = "https://whoer.net/fr";
            //firefoxDriver.Navigate();

            var temp = "zproxy.lum-superproxy.io:22225:lum-customer-hl_73c21fb6-zone-zone2-ip-191.101.140.205:740ux8jhaur6".Split(':');
            try
            {
                var proxy = new
                {
                    Ip = temp[0],
                    Username = temp[2],
                    Password = temp[3],
                    Port = temp[1]
                };

                string PROXY = proxy.Ip + ":" + proxy.Port;

                Proxy pro = new Proxy();
                pro.HttpProxy = PROXY;
                pro.FtpProxy = PROXY;
                pro.SslProxy = PROXY;

                FirefoxOptions firefoxOptions = new FirefoxOptions();
                firefoxOptions.Proxy = pro;

                firefoxDriver = new FirefoxDriver(firefoxOptions);
                firefoxDriver.Url = "https://whoer.net/fr";
                firefoxDriver.Navigate(); //this method is my internal method, just navigate in to page, this makes the proxy credentials dialog to appear
                try
                {

                    //WebDriverWait wait = new WebDriverWait(firefoxDriver, TimeSpan.FromSeconds(5));
                    //wait.Until(driver => IsAlertShown(driver));
                    WebDriverWait wait = new WebDriverWait(firefoxDriver, TimeSpan.FromSeconds(2));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.AlertIsPresent());

                    IAlert alert = firefoxDriver.SwitchTo().Alert();
                    alert.SendKeys(proxy.Username + OpenQA.Selenium.Keys.Tab + proxy.Password);
                }
                catch (Exception x)
                {

                }

                //return true;
            }
            catch (Exception exc)
            {
                //Logger.Log("Could not start browser.", exc);
                // return false;
            }
        }
        bool IsAlertShown(IWebDriver driver)
        {
            try
            {
                driver.SwitchTo().Alert();
            }
            catch (NoAlertPresentException e)
            {
                return false;
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var account = new { mail = "hoangthuc280797@gmail.com", pass = "thuc0533" };
            var inputEmail = firefoxDriver.FindElement(By.Id("user_email"));
            var inputPass = firefoxDriver.FindElement(By.Id("user_password"));
            inputEmail.SendKeys(account.mail);
            inputPass.SendKeys(account.pass);
            firefoxDriver.FindElement(By.XPath(@"//*[@id=""new_user""]/div[3]/div/input")).Click();
        }

        private void btnEarn_Click(object sender, EventArgs e)
        {
            //try
            //{
            IJavaScriptExecutor jse = (IJavaScriptExecutor)firefoxDriver;

            // jse.ExecuteScript("scroll(250, 0)"); // if the element is on top.

            jse.ExecuteScript("scroll(0, 250)"); // if the element is on bottom.
            firefoxDriver.FindElement(By.XPath(@"//*[@id=""features""]/div/div/div[1]/div/div[1]/a/div"));
            var element = firefoxDriver.FindElement(By.XPath(@"//*[@id=""features""]/div/div/div[1]/div/div[1]/a/div"));

            Actions actions = new Actions(firefoxDriver);

            actions.MoveToElement(element).Click().Perform();

            //Thread.Sleep(1000);
            jse.ExecuteScript("scroll(0, 250)"); // if the element is on bottom.
            firefoxDriver.FindElement(By.Id(@"watch-link")).Click();
            // Thread.Sleep(1000);
            jse.ExecuteScript("scroll(0, 1000)");
            firefoxDriver.FindElement(By.XPath(@"/html/body/main/section/div/div[2]/div[1]/div[3]/div/form")).Click();
            //}
            //catch (Exception)
            //{

            //}
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)firefoxDriver;
            jse.ExecuteScript("scroll(0, 1300)"); // if the element is on bottom.
            firefoxDriver.FindElement(By.XPath(@"/html/body/main/section/div/div[2]/div[1]/div[4]/div/form/button")).Click();
        }

        private void btnCheckBoxCaptcha_Click(object sender, EventArgs e)
        {
            firefoxDriver.FindElement(By.Id(@"checkbox")).Click();
        }
        private void clickEarnAndContinueWatch()
        {
            firefoxDriver.FindElement(By.XPath(@"//*[@id=""watch - videos""]/div/div[2]/div[1]/form/div[2]/div[1]/button")).Submit();
        }
        private void btnClaimAndContinue_Click(object sender, EventArgs e)
        {
            clickEarnAndContinueWatch();
        }


    }
}
