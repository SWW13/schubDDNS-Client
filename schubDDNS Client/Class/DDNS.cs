using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Procurios.Public;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Collections;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace schubDDNS_Client
{
    public class DDNS
    {
        public static object Update(String URL)
        {
            URL = URL.ToLower();
            string strResult = null;

            //Deactivate SSL verification
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(AcceptAllCertifications);

            //Webrequest
            try
            {
                WebResponse objResponse;
                WebRequest objRequest = System.Net.HttpWebRequest.Create(URL);

                objResponse = objRequest.GetResponse();

                using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
                {
                    strResult = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "schubDDNS Error");
                return e;
            }

            //Request result not empty?
            if (String.IsNullOrEmpty(strResult))
            {
                MessageBox.Show("Server returned null or empty resultset", "schubDDNS Error");
                return null;
            }

            //Parse JSON response
            object response = JSON.JsonDecode(strResult);
            Hashtable response_hashtable = null;

            //Is Hashtable?
            if (response is Hashtable)
                response_hashtable = response as Hashtable;
            else
            {
                MessageBox.Show("Unknown response from server:\n" + strResult, "schubDDNS Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return strResult;
            }

            //Is status 200 ?
            if (response_hashtable["status"].ToString().ToUpper() != "200 OK")
            {
                MessageBox.Show("Unknown status from server:\n" + strResult, "schubDDNS Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return response_hashtable;
            }

            return response_hashtable;
        }
        public static object Update(String UpdateURL, String Token)
        {
            String URL = UpdateURL.ToLower().Replace("<token>", Token);
            return Update(URL);
        }

        public static bool AcceptAllCertifications(object sender, X509Certificate certification, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
