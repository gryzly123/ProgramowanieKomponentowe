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
        private Task<decimal> QuoteTask;
        private void btnStockQuoteSync_Click(object sender, EventArgs e)
        {
            var ServiceClient = new ServiceReferenceQuotes.DelayedStockQuoteSoapClient("DelayedStockQuoteSoap");
            tbStockOutput.Text = ServiceClient.GetQuickQuote(tbStockInput.Text, "0").ToString();
        }

        private void btnStockQuoteAsync_Click(object sender, EventArgs e)
        {
            var ServiceClient = new ServiceReferenceQuotes.DelayedStockQuoteSoapClient("DelayedStockQuoteSoap");
            QuoteTask = ServiceClient.GetQuickQuoteAsync(tbStockInput.Text, "0");
            tbStockOutput.Text = QuoteTask.Result.ToString();
        }

        #endregion

        private Task<ServiceResolve.IPInformation> IpgeoTask;

        private string FormatIpgeo(string Ip, ServiceResolve.IPInformation IpInfo)
        {
            return string.Format("{0}\r\n{1}\r\n{2}\r\n",
                IpInfo.Country,
                IpInfo.Organization,
                Ip
                );
        }

        private void btnIpgeoSync_Click(object sender, EventArgs e)
        {
            var ServiceClient = new ServiceResolve.P2GeoSoapClient("IP2GeoSoap");
            string ip = tbIpGeoInput.Text;
            tbIpGeoOutput.Text = FormatIpgeo(ip, ServiceClient.ResolveIP(ip, "0"));
        }

        private void btnIpgeoAsync_Click(object sender, EventArgs e)
        {
            var ServiceClient = new ServiceResolve.P2GeoSoapClient("IP2GeoSoap");
            string ip = tbIpGeoInput.Text;
            IpgeoTask = ServiceClient.ResolveIPAsync(ip, "0");
            tbIpGeoOutput.Text = FormatIpgeo(ip, IpgeoTask.Result);
        }
    }
}
