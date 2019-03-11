using System;
using System.IO;
using System.Xml;
using System.Net;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Comp02_NetAssembly
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region StockQuote
        string StockQuoteSync(string Stock)
        {
            var ServiceClient = new ServiceReferenceQuotes.DelayedStockQuoteSoapClient("DelayedStockQuoteSoap");
            return ServiceClient.GetQuickQuote(Stock, "0").ToString();
        }
        Task<decimal> StockQuoteAsync(string Stock)
        {
            var ServiceClient = new ServiceReferenceQuotes.DelayedStockQuoteSoapClient("DelayedStockQuoteSoap");
            return ServiceClient.GetQuickQuoteAsync(Stock, "0");
        }
        string EndStockQuote(Task<decimal> StockQuote)
        {
            return StockQuote.Result.ToString();
        }

        private void btnStockQuoteSync_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch(); sw.Start();
            tbStockOutput.Text = StockQuoteSync(tbStockInput.Text);
            sw.Stop(); l_sqsync.Text = sw.ElapsedMilliseconds.ToString();
        }
        private void btnStockQuoteAsync_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch(); sw.Start();
            tbStockOutput.Text = EndStockQuote(StockQuoteAsync(tbStockInput.Text));
            sw.Stop(); l_sqasync.Text = sw.ElapsedMilliseconds.ToString();
        }
        #endregion

        #region IpGeo
        private string FormatIpgeo(string Ip, ServiceResolve.IPInformation IpInfo)
        {
            return string.Format("{0}\r\n{1}\r\n{2}\r\n",
                IpInfo.Country,
                IpInfo.Organization,
                Ip
                );
        }
        string IpGeoSync(string IP)
        {
            var ServiceClient = new ServiceResolve.P2GeoSoapClient("IP2GeoSoap");
            return FormatIpgeo(IP, ServiceClient.ResolveIP(IP, "0"));
        }
        Task<ServiceResolve.IPInformation> IpGeoAsync(string IP)
        {
            var ServiceClient = new ServiceResolve.P2GeoSoapClient("IP2GeoSoap");
            return ServiceClient.ResolveIPAsync(IP, "0");
        }
        string EndIpGeo(Task<ServiceResolve.IPInformation> IpGeo)
        {
            return FormatIpgeo("", IpGeo.Result);
        }

        private void btnIpgeoSync_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch(); sw.Start();
            tbIpGeoOutput.Text = IpGeoSync(tbIpGeoInput.Text);
            sw.Stop(); l_i2gsync.Text = sw.ElapsedMilliseconds.ToString();
        }
        private void btnIpgeoAsync_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch(); sw.Start();
            tbIpGeoOutput.Text = EndIpGeo(IpGeoAsync(tbIpGeoInput.Text));
            sw.Stop(); l_i2gasync.Text = sw.ElapsedMilliseconds.ToString();
        }
        #endregion

        #region Time
        string TimeSync()
        {
            var ServiceClient = new ServiceEcho.ServiceSoapClient("ServiceSoap1");
            return ServiceClient.GetTime();
        }
        Task<string> TimeAsync()
        {
            var ServiceClient = new ServiceEcho.ServiceSoapClient("ServiceSoap1");
            return ServiceClient.GetTimeAsync();
        }
        string EndTimeAsync(Task<string> Time)
        {
            return Time.Result;
        }

        private void btnTimeSync_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch(); sw.Start();
            tbTimeOutput.Text = TimeSync();
            sw.Stop(); l_timesync.Text = sw.ElapsedMilliseconds.ToString();
        }
        private void btnTimeAsync_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch(); sw.Start();
            tbTimeOutput.Text = EndTimeAsync(TimeAsync());
            sw.Stop(); l_timeasync.Text = sw.ElapsedMilliseconds.ToString();
        }
        #endregion

        #region Echo
        string EchoSync(string Msg)
        {
            var ServiceClient = new ServiceEcho.ServiceSoapClient("ServiceSoap1");
            return ServiceClient.Echo(Msg);
        }
        Task<string> EchoAsync(string Msg)
        {
            var ServiceClient = new ServiceEcho.ServiceSoapClient("ServiceSoap1");
            return ServiceClient.EchoAsync(Msg);
        }
        string EndEchoAsync(Task<string> Echo)
        {
            return Echo.Result;
        }

        private void btnEchoSync_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch(); sw.Start();
            tbEchoOutput.Text = EchoSync(tbEchoInput.Text);
            sw.Stop(); l_echosync.Text = sw.ElapsedMilliseconds.ToString();
        }
        private void btnEchoAsync_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch(); sw.Start();
            tbEchoOutput.Text = EndEchoAsync(EchoAsync(tbEchoInput.Text));
            sw.Stop(); l_echoasync.Text = sw.ElapsedMilliseconds.ToString();
        }
        #endregion

        #region Public orders
        string OrderString(DataSet OrderResult)
        {
            var Row0 = OrderResult.Tables[0].Rows[0];

            return string.Format(
                "Received {0} results. Showing result id 0 highlights:\r\n\r\nZamawiajacy Nazwa: {1}\r\n" +
                "Zamawiajacy REGON: {2}\r\nNazwa projektu: {3}\r\nFinansowanie z Unii: {4}\r\nData publikacji: {5}\r\n",
                 OrderResult.Tables[0].Rows.Count,
                 Row0["zamawiajacy_nazwa"],
                 Row0["regon"],
                 Row0["nazwa_projektu_programu"],
                 Row0["czy_finansowane_z_unii"],
                 Row0["data_publikacji"]
                );
        }
        string OrderSync(Int32 OrdererId, Int32 OrderId, string Voivodeship)
        {
            var ServiceClient = new ServicePublicData.BZP_PublicWebServiceSoapClient("BZP_PublicWebServiceSoap");
            return OrderString(ServiceClient.ogloszeniaZP400KryteriaWyszukiwaniaDataSet(
                OrdererId, OrderId, 99,
                "", "", "", "", "", 99,
                "", "",
                Voivodeship, -1, -1));
        }
        Task<DataSet> OrderAsync(Int32 OrdererId, Int32 OrderId, string Voivodeship)
        {
            var ServiceClient = new ServicePublicData.BZP_PublicWebServiceSoapClient("BZP_PublicWebServiceSoap");
            return ServiceClient.ogloszeniaZP400KryteriaWyszukiwaniaDataSetAsync(
                OrdererId, OrderId, 99,
                "", "", "", "", "", 99,
                "", "",
                Voivodeship, -1, -1);
        }
        string EndOrderAsync(Task<DataSet> OrderDataset)
        {
            return OrderString(OrderDataset.Result);
        }

        private void btnOrderSync_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch(); sw.Start();
            tbOrderOutput.Text = OrderSync(Convert.ToInt32(tbOrderer.Text), Convert.ToInt32(tbOrder.Text), tbVoivodeship.Text);
            sw.Stop(); l_posync.Text = sw.ElapsedMilliseconds.ToString();
        }
        private void btnOrderAsync_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch(); sw.Start();
            tbOrderOutput.Text = EndOrderAsync(OrderAsync(Convert.ToInt32(tbOrderer.Text), Convert.ToInt32(tbOrder.Text), tbVoivodeship.Text));
            sw.Stop(); l_poasync.Text = sw.ElapsedMilliseconds.ToString();
        }
        #endregion

        #region Weather
        private readonly HttpClient owmClient = new HttpClient();
        private readonly string owmApiKey = "c858c1cd867a64fa4ec99f3775852c8f";

        void FormatWeatherXml(RichTextBox rtb, string Xml)
        {
            XmlReader Reader = XmlReader.Create(new StringReader(Xml));
            string City = "", CityId = "", Temperature = "", WindSpeed = "", WindDirection = "";
            while(Reader.Read())
            {
                switch(Reader.Name)
                {
                    case "city":
                        if(City.Equals(string.Empty)) City = Reader.GetAttribute("name");
                        if (CityId.Equals(string.Empty)) CityId = Reader.GetAttribute("id");
                        break;

                    case "temperature":
                        if (Temperature.Equals(string.Empty)) Temperature = Reader.GetAttribute("value");
                        break;

                    case "speed":
                        if (WindSpeed.Equals(string.Empty)) WindSpeed = Reader.GetAttribute("value");
                        break;

                    case "direction":
                        if (WindDirection.Equals(string.Empty)) WindDirection = Reader.GetAttribute("name");
                        break;
                }
            }

            rtb.Clear();
            rtb.AppendText(string.Format(
                "{0}\r\n(city id={1})\r\nWind speed: {2}m/s\r\nWind dir: {3}\r\n",
                City, CityId,
                WindSpeed,
                WindDirection));

            int tmp = rtb.TextLength;
            string FormattedTemp = string.Format("Temp.: {0} C", Temperature);
            rtb.AppendText(FormattedTemp);
            rtb.Select(tmp, FormattedTemp.Length);

            float NumericTemp = 0;
            Temperature = Temperature.Replace(".", ",");
            if(float.TryParse(Temperature, out NumericTemp))
            {
                     if (NumericTemp < 0.0f) rtb.SelectionColor = Color.Red;
                else if (NumericTemp < 5.0f) rtb.SelectionColor = Color.Blue;
                else                         rtb.SelectionColor = Color.Green;
            }

        }
        string WeatherSync(string City)
        {
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&APPID={1}&mode=xml&units=metric", City, owmApiKey);
            return owmClient.GetStringAsync(url).Result;
        }
        Task<string> WeatherAsync(string City)
        {
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&APPID={1}&mode=xml&units=metric", City, owmApiKey);
            return owmClient.GetStringAsync(url);
        }
        string EndWeatherAsync(Task<string> Weather)
        {
            return Weather.Result;
        }

        private void btnWeatherSync_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch(); sw.Start();
            FormatWeatherXml(tbWeatherOutput, WeatherSync (tbWeatherInput.Text));
            sw.Stop(); l_owsync.Text = sw.ElapsedMilliseconds.ToString();
        }
        private void btnWeatherAsync_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch(); sw.Start();
            FormatWeatherXml(tbWeatherOutput, EndWeatherAsync(WeatherAsync(tbWeatherInput.Text)));
            sw.Stop(); l_owasync.Text = sw.ElapsedMilliseconds.ToString();
        }
        #endregion

        #region Batch request
        private bool ValidateForms()
        {
            if (tbStockInput.Text.Equals(string.Empty))
            {
                MessageBox.Show("Stock Quote input is empty!");
                return false;
            }
            if (tbIpGeoInput.Text.Equals(string.Empty) || !IPAddress.TryParse(tbIpGeoInput.Text, out IPAddress tmp))
            {
                MessageBox.Show("IP2Geo input is empty or not a valid IP!");
                return false;
            }
            if (tbEchoInput.Text.Equals(string.Empty))
            {
                MessageBox.Show("Echo input is empty!");
                return false;
            }
            if (tbWeatherInput.Text.Equals(string.Empty))
            {
                MessageBox.Show("OpenWeather input is empty!");
                return false;
            }
            if (tbOrderer.Text.Equals(string.Empty))
            {
                MessageBox.Show("Orderer input is empty or not a valid integer!");
                return false;
            }
            if (tbOrder.Text.Equals(string.Empty) || !Int32.TryParse(tbOrder.Text, out Int32 tmp2))
            {
                MessageBox.Show("Order input is empty or not a valid integer!");
                return false;
            }
            if (tbVoivodeship.Text.Equals(string.Empty))
            {
                MessageBox.Show("Voivodeship input is empty!");
                return false;
            }
            return true;
        }

        private void btnRunAllSync_Click(object sender, EventArgs e)
        {
            if (!ValidateForms()) return;
            Stopwatch sw = new Stopwatch(); sw.Start();

            tbStockOutput.Text = StockQuoteSync(tbStockInput.Text);
            tbIpGeoOutput.Text = IpGeoSync(tbIpGeoInput.Text);
            tbTimeOutput.Text = TimeSync();
            tbEchoOutput.Text = EchoSync(tbEchoInput.Text);
            tbOrderOutput.Text = OrderSync(Convert.ToInt32(tbOrderer.Text), Convert.ToInt32(tbOrder.Text), tbVoivodeship.Text);
            FormatWeatherXml(tbWeatherOutput, WeatherSync(tbWeatherInput.Text));

            sw.Stop(); l_synctotal.Text = sw.ElapsedMilliseconds.ToString();
        }

        private void btnRunAllAsync_Click(object sender, EventArgs e)
        {
            if (!ValidateForms()) return;
            Stopwatch sw = new Stopwatch(); sw.Start();

            Task<decimal>                      SQ = StockQuoteAsync(tbStockInput.Text);
            Task<ServiceResolve.IPInformation> IG = IpGeoAsync(tbIpGeoInput.Text);
            Task<string>                       TI = TimeAsync();
            Task<string>                       EC = EchoAsync(tbEchoInput.Text);
            Task<DataSet>                      PO = OrderAsync(Convert.ToInt32(tbOrderer.Text), Convert.ToInt32(tbOrder.Text), tbVoivodeship.Text);
            Task<string>                       OW = WeatherAsync(tbWeatherInput.Text);

            tbStockOutput.Text = EndStockQuote(SQ);
            tbIpGeoOutput.Text = EndIpGeo(IG);
            tbTimeOutput.Text = EndTimeAsync(TI);
            tbEchoOutput.Text = EndEchoAsync(EC);
            FormatWeatherXml(tbWeatherOutput, EndWeatherAsync(OW));
            tbOrderOutput.Text = EndOrderAsync(PO);

            sw.Stop(); l_asynctotal.Text = sw.ElapsedMilliseconds.ToString();
        }
        #endregion
    }
}
