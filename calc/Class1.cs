using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.ComponentModel;
using System.Xml.Linq;
namespace calc
{
    public class Currencies
    {
        double dollar = 0;
        double euro = 0;
        string htmlCode = "";
        public Currencies()
        {
            Get_Exchange_Rate();
        }
        public double Get_Dollar() { return dollar; }
        public double Get_Euro() { return euro; }
        private void Get_Exchange_Rate()
        {
            WebClient webClient = new WebClient();
            //webClient.DownloadFileAsync(new Uri(url), @"c:\myfile.txt");
            string[] sep = { "<Valute ", "</Valute>" };
            XDocument xml = XDocument.Load("http://www.cbr.ru/scripts/XML_daily.asp");
            dollar = Convert.ToDouble(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "840").Elements("Value").FirstOrDefault().Value);
            euro = Convert.ToDouble(xml.Elements("ValCurs").Elements("Valute").FirstOrDefault(x => x.Element("NumCode").Value == "978").Elements("Value").FirstOrDefault().Value);
        }

    
    }
}
