using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

[WebService(Namespace = "http://localhost/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class Service : System.Web.Services.WebService
{
    public Service () {
    }

    [WebMethod]
    public int Fibonaci(int N)
    {
        if (N >= 1 & N <= 100)
        {
            return FibonaciSequence(N);
        }
        else
        {
            return -1;
        }
    }

    public int FibonaciSequence(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return FibonaciSequence(n - 1) + FibonaciSequence(n - 2);
        }
    }

    [WebMethod]
    public string XmlToJson(string xml)
    {
        XmlDocument doc = new XmlDocument();

        try
        {
            doc.LoadXml(xml);
        }
        catch (Exception)
        {
            return "Bad Xml Format";
        }
        
        string jsonText = JsonConvert.SerializeXmlNode(doc);

        return jsonText;
    }
    //TESTS OK
    //<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>
    //<foo>bar</foo>

    //TEST KO
    //<foo>hello</bar>
}