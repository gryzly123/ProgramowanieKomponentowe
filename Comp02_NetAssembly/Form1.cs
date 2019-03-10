using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp02_NetAssembly
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void btnStockQuoteSync_Click(object sender, EventArgs e)  => tbStockOutput.Text = StockQuoteSync(tbStockInput.Text);
        private void btnStockQuoteAsync_Click(object sender, EventArgs e) => tbStockOutput.Text = EndStockQuote(StockQuoteAsync(tbStockInput.Text));
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

        private void btnIpgeoSync_Click(object sender, EventArgs e) => tbIpGeoOutput.Text = IpGeoSync(tbIpGeoInput.Text);
        private void btnIpgeoAsync_Click(object sender, EventArgs e) => tbIpGeoOutput.Text = EndIpGeo(IpGeoAsync(tbIpGeoInput.Text));
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

        private void btnTimeSync_Click(object sender, EventArgs e)  => tbTimeOutput.Text = TimeSync();
        private void btnTimeAsync_Click(object sender, EventArgs e) => tbTimeOutput.Text = EndTimeAsync(TimeAsync());
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

        private void btnEchoSync_Click(object sender, EventArgs e)  => tbEchoOutput.Text =              EchoSync (tbEchoInput.Text);
        private void btnEchoAsync_Click(object sender, EventArgs e) => tbEchoOutput.Text = EndEchoAsync(EchoAsync(tbEchoInput.Text));
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
            => tbOrderOutput.Text = OrderSync               (Convert.ToInt32(tbOrderer.Text), Convert.ToInt32(tbOrder.Text), tbVoivodeship.Text);
        private void btnOrderAsync_Click(object sender, EventArgs e) 
            => tbOrderOutput.Text = EndOrderAsync(OrderAsync(Convert.ToInt32(tbOrderer.Text), Convert.ToInt32(tbOrder.Text), tbVoivodeship.Text));
        #endregion
    }
}
