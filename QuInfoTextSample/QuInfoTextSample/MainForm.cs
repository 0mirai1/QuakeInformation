using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuInfoTextSample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private  void MainForm_Load(object sender, EventArgs e)
        {
            Check();
        }
        string Last_eventid = "0";
        string Last_dateTime = "0";
        string Webapiurl = "https://dev.narikakun.net/webapi/earthquake/post_data.json?_ga=2.102905280.1911846031.1635327567-1306914555.1619779464";//←API
        private async void QuInfoTimer_Tick(object sender, EventArgs e)
        {
            //API上5000ミリ秒(5秒間隔)で取得
            //QuInfoにアクセス
            await Task.Run(() => Check());
        }
        private void Check()
        {
            try
            {
                WebClient WebC = new WebClient() { Encoding = Encoding.GetEncoding("UTF-8") };
                string Api = WebC.DownloadString(Webapiurl);
                try
                {
                    var Json = JObject.Parse(Api);
                    if (Json["Control"]["DateTime"].Value<string>() == Last_dateTime) return;
                    string cityint1 = "", cityint2 = "", cityint3 = "", cityint4 = "", cityint5 = "", cityint5plus = "", cityint6 = "", cityint6plus = "", cityint7 = "", cityintF = "";
                    if (Last_eventid ==Json["Head"]["EventID"].Value<string>())
                    {
                        if (Json["Head"]["Title"].Value<string>() != "震源に関する情報")
                        {
                            CityInfoRichTextBox1.Text = "";
                        }
                    }
                    else
                    {
                        CityInfoRichTextBox1.Text = "";
                    }
                    if (Json["Head"]["Title"].Value<string>() != "震源に関する情報")
                    {
                        foreach (JObject pref in Json["Body"]["Intensity"]["Observation"]["Pref"])
                        {
                      CityInfoRichTextBox1.Text += pref["Name"].Value<string>() + "：";
                          
                            foreach (JObject area in pref["Area"])
                            {
                                if (Json["Head"]["Title"].Value<string>() == "震源・震度情報")
                                {
                                    foreach (JObject city in area["City"])
                                    {
                                        foreach (JObject stationin in city["IntensityStation"])
                                        {
                                            switch(stationin["Int"].Value<string>())
                                            {
                                                case "1":
                                                    cityint1 += stationin["Name"].Value<string>().Replace("＊", "") + " ";
                                                        break;
                                                case "2":
                                                    cityint2 += stationin["Name"].Value<string>().Replace("＊", "") + " ";
                                                    break;
                                                case "3":
                                                    cityint3 += stationin["Name"].Value<string>().Replace("＊", "") + " ";
                                                    break;
                                                case "4":
                                                    cityint4 += stationin["Name"].Value<string>().Replace("＊", "") + " ";
                                                    break;
                                                case "5-":
                                                    cityint5 += stationin["Name"].Value<string>().Replace("＊", "") + " ";
                                                    break;
                                                case "5+":
                                                    cityint5plus += stationin["Name"].Value<string>().Replace("＊", "") + " ";
                                                    break;
                                                case "6-":
                                                    cityint6 += stationin["Name"].Value<string>().Replace("＊", "") + " ";
                                                    break;
                                                case "6+":
                                                    cityint6plus += stationin["Name"].Value<string>().Replace("＊", "") + " ";
                                                    break;
                                                case "7":
                                                    cityint7 += stationin["Name"].Value<string>().Replace("＊", "") + " ";
                                                    break;
                                                default:
                                                    cityintF += stationin["Name"].Value<string>().Replace("＊", "") + " ";
                                                    break;
                                            }
                                        }
                                    }
                                }
                                else if (Json["Head"]["Title"].Value<string>() == "震度速報")
                                {
                                    switch(area["MaxInt"].Value<string>())
                                    {
                                        case "1":
                                            cityint1 += area["Name"].Value<string>() + " ";
                                            break;
                                        case "2":
                                            cityint2 += area["Name"].Value<string>() + " ";
                                            break;
                                        case "3":
                                            cityint3 += area["Name"].Value<string>() + " ";
                                            break;
                                        case "4":
                                            cityint4 += area["Name"].Value<string>() + " ";
                                            break;
                                        case "5-":
                                            cityint5 += area["Name"].Value<string>() + " ";
                                            break;
                                        case "5+":
                                            cityint5plus += area["Name"].Value<string>() + " ";
                                            break;
                                        case "6-":
                                            cityint6 += area["Name"].Value<string>() + " ";
                                            break;
                                        case "6+":
                                            cityint6plus += area["Name"].Value<string>() + " ";
                                            break;
                                        case "7":
                                            cityint7 += area["Name"].Value<string>() + " ";
                                            break;
                                        default:
                                            cityintF += area["Name"].Value<string>() + " ";
                                            break;
                                    }
                                }
                            }
                            if (cityintF != "") { CityInfoRichTextBox1.Text += "【震度5弱以上未入電】" + cityintF; }
                            if (cityint7 != "") { CityInfoRichTextBox1.Text += "【震度7】" + cityint7; }
                            if (cityint6plus != "") { CityInfoRichTextBox1.Text += "【震度6強】" + cityint6plus; }
                            if (cityint6 != "") { CityInfoRichTextBox1.Text += "【震度6弱】" + cityint6; }
                            if (cityint5plus != "") { CityInfoRichTextBox1.Text += "【震度5強】" + cityint5plus; }
                            if (cityint5 != "") { CityInfoRichTextBox1.Text += "【震度5弱】" + cityint5; }
                            if (cityint4 != "") { CityInfoRichTextBox1.Text += "【震度4】" + cityint4; }
                            if (cityint3 != "") { CityInfoRichTextBox1.Text += "【震度3】" + cityint3; }
                            if (cityint2 != "") { CityInfoRichTextBox1.Text += "【震度2】" + cityint2; }
                            if (cityint1 != "") { CityInfoRichTextBox1.Text += "【震度1】" + cityint1; }
                            cityint1 = "";
                            cityint2 = "";
                            cityint3 = "";
                            cityint4 = "";
                            cityint5 = "";
                            cityint5plus = "";
                            cityint6 = "";
                            cityint6plus = "";
                            cityint7 = "";
                            cityintF = "";
                            CityInfoRichTextBox1.Text += "\r\n";
                        }
                    }
                    Console.WriteLine(Json["Body"]["Comments"]["Observation"]);
                    if (Json["Head"]["Title"].Value<string>() == "遠地地震に関する情報")
                    {
                        string d = Json["Body"]["Earthquake"]["ArrivalTime"].Value<string>();
                        string f = "yyyy-MM-dd HH:mm:ss";
                        DateTime dt = DateTime.ParseExact(d, f, null);
                        TimeLabel.Text = dt.ToString("dd日hh時mm分") + "　発生";
                        MaxintLabel.Text = "遠地地震";
                        CityInfoRichTextBox1.Text = dt.ToString("dd日hh時mm分ごろ") + "海外で地震がありました。震源地は" + Json["Body"]["Earthquake"]["Hypocenter"]["Name"].Value<string>() + "で、震源の深さは" + Json["Body"]["Earthquake"]["Hypocenter"]["Depth"].Value<string>() + "km、地震の規模を示すマグニチュードは" + Json["Body"]["Earthquake"]["Magnitude"].Value<string>() + "と推定されます。";
                    }
                    if (Json["Head"]["Title"].Value<string>() == "震源・震度情報")
                    {
                        string d = Json["Head"]["TargetDateTime"].Value<string>();
                        string f = "yyyy-MM-dd HH:mm:ss";
                        DateTime dt = DateTime.ParseExact(d, f, null);
                       TimeLabel.Text = dt.ToString("dd日hh時mm分") + "　発生";
                        EpicenterLabel.Text = "震源地名　"+Json["Body"]["Earthquake"]["Hypocenter"]["Name"].Value<string>();
                        DepthLabel.Text = "深さ　" + Json["Body"]["Earthquake"]["Hypocenter"]["Depth"].Value<string>()+"km";
                        MagnitubeLabel.Text = "マグニチュード　" + Json["Body"]["Earthquake"]["Magnitude"].Value<string>();
                        MaxintLabel.Text = "最大震度" + Json["Body"]["Intensity"]["Observation"]["MaxInt"].Value<string>();
                    }
                    else if (Json["Head"]["Title"].Value<string>() == "震度速報")
                    {
                        MaxintLabel.Text = "最大震度 " + Json["Body"]["Intensity"]["Observation"]["MaxInt"].Value<string>().Replace("-", "弱").Replace("+", "強");
                        string d = Json["Head"]["TargetDateTime"].Value<string>();
                        string f = "yyyy-MM-dd HH:mm:ss";
                        DateTime dt = DateTime.ParseExact(d, f, null); TimeLabel.Text = dt.ToString("dd日hh時mm分") + "　発生";
                        EpicenterLabel.Text = "調査中";
                        DepthLabel.Text = "";
                        MagnitubeLabel.Text = "";
                        DepthLabel.Visible = false;
                        MagnitubeLabel.Visible = false;
                    }
                    if (Json["Head"]["Title"].Value<string>() == "震源に関する情報")
                    {
                        string d = Json["Head"]["TargetDateTime"].Value<string>();
                        string f = "yyyy-MM-dd HH:mm:ss";
                        DateTime dt = DateTime.ParseExact(d, f, null);
                        TimeLabel.Text = dt.ToString("dd日hh時mm分") + "　発生";
                        EpicenterLabel.Text = "震源地名　" + Json["Body"]["Earthquake"]["Hypocenter"]["Name"].Value<string>();
                        DepthLabel.Text = "深さ　" + Json["Body"]["Earthquake"]["Hypocenter"]["Depth"].Value<string>()+"km";
                        MagnitubeLabel.Text = "マグニチュード　" + Json["Body"]["Earthquake"]["Magnitude"].Value<string>();
                        MaxintLabel.Text = "";
           
                        CityInfoRichTextBox1.Text = dt.ToString("dd日hh時mm分ごろ") + "地震がありました。震源地は" + Json["Body"]["Earthquake"]["Hypocenter"]["Name"].Value<string>() + "で、震源の深さは" + Json["Body"]["Earthquake"]["Hypocenter"]["Depth"].Value<string>() + "km、地震の規模を示すマグニチュードは" + Json["Body"]["Earthquake"]["Magnitude"].Value<string>() + "と推定されます。";
                    }
                    CommentLabel.Text = Json["Body"]["Comments"]["Observation"].Value<string>();
                    Last_eventid = Json["Head"]["EventID"].Value<string>();
                    Last_dateTime = Json["Control"]["DateTime"].Value<string>();
                    TitleLabel.Text = Json["Head"]["Title"].Value<string>();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
