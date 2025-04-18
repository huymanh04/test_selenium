using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.IO;

namespace test_selenium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("ook.txt", "mạnh"+Environment.NewLine);
            var maaa = File.ReadAllLines("");
            for (int i = 0; i < 1; i++)
            {


                Thread t = new Thread(() =>
                {

                    this.Invoke((MethodInvoker)delegate
                    {
                        label1.Text ="bắt đầu rồi";
                    });
                    //        IWebDriver chrome = null; List<int> driverProcessIds = new List<int>();

                    //        IJavaScriptExecutor js = null;

                    //            ChromeOptions chromeOptions = new ChromeOptions();
                    //            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
                    //            chromeDriverService.HideCommandPromptWindow = true;
                    //            chromeOptions.AddArguments("start-maximized");
                    //            chromeOptions.AddArgument("--disabel-notifications");
                    //            chromeOptions.AddExcludedArgument("enable-automation");
                    //            chromeOptions.AddArguments(new string[]
                    //            {
                    //"--disable-3d-apis",
                    //        "--app=https://www.tiktok.com/login/phone/forget-password",
                    //"--disable-background-networking",
                    //"--disable-bundled-ppapi-flash",
                    //"--disable-client-side-phishing-detection",
                    //"--disable-default-apps",
                    //"--disable-hang-monitor",
                    //"--disable-gpu",
                    //"--no-sandbox",
                    //"--disable-prompt-on-repost",
                    //"--disable-sync",
                    //"--use-fake-device-for-media-stream",
                    //"--use-fake-ui-for-media-stream",
                    //"--disable-webgl",
                    //"--enable-blink-features=ShadowDOMV0",
                    //"--enable-logging",
                    //"--disable-notifications",
                    //"--disable-dev-shm-usage",
                    //"--disable-web-security",
                    //"--lang=vn",
                    //"--disable-rtc-smoothness-algorithm",
                    //"--disable-webrtc-hw-decoding",
                    //"--disable-webrtc-hw-encoding",
                    //"--disable-webrtc-multiple-routes",
                    //"--disabel-images",
                    //"--disable-webrtc-hw-vp8-encoding",
                    //"--enforce-webrtc-ip-permission-check",
                    //"--force-webrtc-ip-handling-policy",
                    //"--ignore-certificate-errors",
                    //"--disable-infobars",
                    //"--disable-popup-blocking",
                    //"--enable-precise-memory-info",
                    //"--disable-3d-apis",
                    //"--start-maximized",

                    //"--disable-blink-features=\"BlockCredentialedSubresources\"",
                    //"--mute-audio",

                    //"--window-size=450,600",
                    //"--disable-popup-blocking" });
                    //            chromeOptions.AddUserProfilePreference("profile.default_contextn[ii,0]t_setting_values.geolocation", 1);
                    //            chromeOptions.AddUserProfilePreference("profile.default_contextn[ii,0]t_setting_values.notifications", 1);
                    //            chromeOptions.AddUserProfilePreference("profile.default_contextn[ii,0]t_setting_values.plugins", 1);
                    //            chromeOptions.AddUserProfilePreference("profile.default_contextn[ii,0]t_setting_values.popups", 1);
                    //            chromeOptions.AddUserProfilePreference("profile.default_contextn[ii,0]t_setting_values.auto_select_certificate", 1);
                    //            chromeOptions.AddUserProfilePreference("profile.default_contextn[ii,0]t_setting_values.mixed_script", 1);
                    //            chromeOptions.AddUserProfilePreference("profile.default_contextn[ii,0]t_setting_values.media_stream", 1);
                    //            chromeOptions.AddUserProfilePreference("profile.default_contextn[ii,0]t_setting_values.media_stream_mic", 1);
                    //            chromeOptions.AddUserProfilePreference("profile.default_contextn[ii,0]t_setting_values.media_stream_camera", 1);
                    //            chromeOptions.AddUserProfilePreference("profile.default_contextn[ii,0]t_setting_values.protocol_handlers", 1);
                    //            chromeOptions.AddUserProfilePreference("profile.default_contextn[ii,0]t_setting_values.midi_sysex", 1);
                    //            chromeOptions.AddUserProfilePreference("profile.default_contextn[ii,0]t_setting_values.push_messaging", 1);
                    //            chromeOptions.AddUserProfilePreference("profile.default_contextn[ii,0]t_setting_values.ssl_cert_decisions", 1);
                    //            chromeOptions.AddUserProfilePreference("profile.default_contextn[ii,0]t_setting_values.metro_switch_to_desktop", 1);
                    //            chromeOptions.AddUserProfilePreference("profile.default_contextn[ii,0]t_setting_values.protected_media_identifier", 1);
                    //            chromeOptions.AddUserProfilePreference("profile.default_contextn[ii,0]t_setting_values.site_engagement", 1);
                    //            chromeOptions.AddUserProfilePreference("profile.default_contextn[ii,0]t_setting_values.durable_storage", 1);
                    //            chromeOptions.AddArgument("--disable-blink-features=AutomationControlled");
                    //            chromeOptions.AddUserProfilePreference("credentials_enable_service", false);
                    //            chromeOptions.AddArgument("--disabel-notifications");
                    //            chromeOptions.AddArgument("--disabel-images");
                    //            //chromeOptions.AddArgument("--proxy-server=119.3.113.150:9094");/// fake proxy dạng http https 119.3.113.150:9094 proxy https

                    //        chrome = new ChromeDriver(chromeDriverService, chromeOptions);
                    //        chrome.Navigate().GoToUrl("https://www.tinywebgallery.com/blog/advanced-iframe/free-iframe-checker");
                    //        Thread.Sleep(1000);
                    //        try { 
                    //        chrome.SwitchTo().Frame(chrome.FindElement(By.Name("advanced_iframe")));
                    //            chrome.SwitchTo().DefaultContent();
                    //    var m=    chrome.FindElement(By.Name("submit")).GetAttribute("value");
                    //            chrome.SwitchTo().DefaultContent();
                    //            chrome.FindElement(By.XPath("/html/body/div/div/div/main/article/div/div/p[3]"));
                    //        }
                    //        catch { }
                    HttpRequest h = new HttpRequest();
                    //var m = h.Get("https://api.viotp.com/users/balance?token=e208f7198d8894ea1ad4296f602db9dd7").ToString();
                    //string pattern = "\"balance\"\\s*:\\s*(\\d+)";

                    //Match match = Regex.Match(m, pattern);
                    //if (match.Success)
                    //{
                    //    int balance = int.Parse(match.Groups[1].Value);
                    //    Console.WriteLine("Balance: " + balance);
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Không tìm thấy balance.");
                    //}
                    //string data = "{\"api_key\": \"f22233ec016d520d7cd7af94f8a6a168e\"}";
                    //var ma = h.Post("https://api.otpmmo.xyz/api/customer/user-info", data, "application/json").ToString();
                    //JObject obj = JObject.Parse(ma);
                    //string amount = (string)obj["data"]["amount"];
                    var m = h.Get("https://api.viotp.com/request/getv2?token=e208f71988894ea1ad4d296f602db9dd7&serviceId=698").ToString();
                    Thread.Sleep(1000);
                    JObject obj = JObject.Parse(m);
                    string rePhone = (string)obj["data"]["re_phone_number"];
                    long requestId = (long)obj["data"]["request_id"];
                    string ma = "";
                    for (int ia = 0; ia < 60; ia++)
                    {


                        var mn = h.Get($"https://api.viotp.com/session/getv2?requestId={requestId}&token=e208f71988d894ea1ad4296f602db9dd7").ToString();
                  
                        JObject obaj = JObject.Parse(mn);
                        JToken smsContentToken = obaj["data"]["SmsContent"];

                        string smsContent = smsContentToken?.ToString() ?? "null";
                        if (smsContent != null)
                        {
                            JToken smsContentTokena= obaj["data"]["Code"];
                            ma = smsContentTokena.ToString();
                            break;
                        }
                        Thread.Sleep(1000);
                    }
                    File.WriteAllText("ook.txt", "mạnh");
                }); t.Start();
        }
        }
    }
}
