using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net.NetworkInformation;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loader;
using Leaf.xNet;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;



namespace Loader
{
    public partial class Loginfrm : UserControl
    {
        public Loginfrm()
        {
            InitializeComponent();
        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                Ping myPing = new Ping();
                String host = "google.com";
                byte[] buffer = new byte[32];
                int timeout = 1000;
                PingOptions pingOptions = new PingOptions();
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                return false;
            }
        }



        private void Loginfrm_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {
       

            if (exchangecode_textbox.TextLength != 32)
            {
                MessageBox.Show("Code must be 32 char!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                exchangecode_textbox.Text = "";
                return;
            }

            if (!CheckForInternetConnection()) 
            {

                MessageBox.Show("Please check your Intrnet Connection!");
                return;
            }



            statos.Text = "Please wait ...";

            using (HttpRequest httpRequest = new HttpRequest())
            {
               
                httpRequest.KeepAlive = true;
                httpRequest.IgnoreProtocolErrors = true;
                httpRequest.ConnectTimeout = 5000;
                httpRequest.AllowAutoRedirect = false;
                httpRequest.AddHeader("Authorization", "basic MzQ0NmNkNzI2OTRjNGE0NDg1ZDgxYjc3YWRiYjIxNDE6OTIwOWQ0YTVlMjVhNDU3ZmI5YjA3NDg5ZDMxM2I0MWE=");
                string text = httpRequest.Post("https://account-public-service-prod03.ol.epicgames.com/account/api/oauth/token", "grant_type=exchange_code&exchange_code=" + this.exchangecode_textbox.Text + "&includePerms=true&token_type=eg1", "application/x-www-form-urlencoded").ToString();
                if (text.Contains("access_token"))
                {
                    Json json = JsonConvert.DeserializeObject<Json>(text);
                    httpRequest.ClearAllHeaders();
                    string access_token = json.access_token;
                    string account_id = json.account_id;
                    httpRequest.AddHeader("Authorization", "bearer " + access_token);
                    Json json2 = JsonConvert.DeserializeObject<Json>(httpRequest.Get("https://account-public-service-prod.ol.epicgames.com/account/api/public/account/" + account_id, null).ToString());
                    Vars.idd = json2.id;
                    Vars.email = json2.email;
                    Vars.emailverffied = json2.emailVerified;
                    byte[] bytes = Encoding.Default.GetBytes(json2.first_name);
                    Vars.firstnamee = Encoding.UTF8.GetString(bytes);

                    byte[] bytes1 = Encoding.Default.GetBytes(json2.lastName);
                    Vars.lastnamee = Encoding.UTF8.GetString(bytes1);

                   
                    Vars.lastloginn = new string(json2.lastLogin.Take(10).ToArray<char>());

                    byte[] bytes2 = Encoding.Default.GetBytes(json2.displayName);
                    Vars.displayyname = Encoding.UTF8.GetString(bytes2);
               
                    Vars.Displaychantm = json2.numberOfDisplayNameChanges;
                    Vars.country = json2.country;
                    Vars.phonenum = json2.phoneNumber;
					//   Vars.cretaiondate = new string(json2.created.Take(10).ToArray<char>());




					httpRequest.AddHeader("Authorization", "bearer " + access_token);
                    httpRequest.Post("https://account-public-service-prod.ol.epicgames.com/account/api/public/account/" + Vars.idd + "/deviceAuth");


					httpRequest.AddHeader("Authorization", "bearer " + access_token);
					List<Order> list = JsonConvert.DeserializeObject<List<Order>>(httpRequest.Get("https://account-public-service-prod.ol.epicgames.com/account/api/public/account/" + Vars.idd + "/externalAuths", null).ToString());
				
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i].Type == "nintendo")
						{
							
							string text3 = new string(list[i].DateAdded.ToString().Take(10).ToArray<char>());
							Vars.nintindodate = text3;
						}
						else if (list[i].Type == "twitch")
						{
							string text4 = new string(list[i].DateAdded.ToString().Take(10).ToArray<char>());
							Vars.twitchdate = text4;
							Vars.twitchname = list[i].ExternalDisplayName.ToString();
						}
						else if (list[i].Type == "psn")
						{
							string text5 = new string(list[i].DateAdded.ToString().Take(10).ToArray<char>());
							Vars.psndate = text5;
							Vars.psnname = list[i].ExternalDisplayName.ToString();
						}
						else if (list[i].ExternalAuthIdType == "xuid")
						{
							string text6 = new string(list[i].DateAdded.ToString().Take(10).ToArray<char>());
							Vars.xb1date = text6;
							Vars.xb1name = list[i].ExternalDisplayName.ToString();
						}

                  
                    }

					httpRequest.AddHeader("Authorization", "bearer " + access_token);
					string text7 = httpRequest.Post("https://fortnite-public-service-prod11.ol.epicgames.com/fortnite/api/game/v2/profile/" + account_id + "/client/QueryProfile?profileId=athena&rvn=-1", "{}", "application/json").ToString();
					JObject jobject = JObject.Parse(text7);
					jobject.ToObject<JObject>();
					string text8 = new string(DateTime.Parse(jobject["profileChanges"][0]["profile"]["created"].ToString()).ToString("o").Take(10).ToArray<char>());
					Vars.cretaiondate = text8;



                    httpRequest.AddHeader("Authorization", "bearer " + access_token);
                    List<IP> iplist = JsonConvert.DeserializeObject<List<IP>>(httpRequest.Get("https://account-public-service-prod.ol.epicgames.com/account/api/public/account/" + Vars.idd + "/deviceAuth", null).ToString());
                    for (int i = 0; i < iplist.Count; i++)
                    {
                        Vars.ips.Add("*************************************");
                        Vars.ips.Add("IP: " + iplist[i].Created.IpAddress);
                        Vars.ips.Add("Location: " + iplist[i].Created.Location);
                        Vars.ips.Add("Date: " + iplist[i].Created.DateTime);
                        Vars.ips.Add("*************************************");
                    }


        

                    statos.Text = "";
                    MessageBox.Show("Done");
                    
                    Vars.done = true;
                        } else
                {
                    statos.Text = "Error";
                    MessageBox.Show("Exchange code is invalid!");
                    Vars.done = false;
                    statos.Text = "";
                }
            }
        }
    }
}
