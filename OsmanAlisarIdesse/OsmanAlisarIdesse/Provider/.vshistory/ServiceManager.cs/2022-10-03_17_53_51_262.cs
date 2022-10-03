using OsmanAlisarIdesse.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace OsmanAlisarIdesse.Provider
{
    internal class ServiceManager
    {
        string basaeUrl = "https://demo2.idesse.com/";
        static HttpClient client = new HttpClient();
        //private async Task<HttpClient> GetClient()
        //{
        //    if (client == null)
        //    {
        //        client = new HttpClient();
        //    }
        //    //  client.DefaultRequestHeaders.Add("Accept", "application/json");
        //    return client;
        //}
        private async Task<HttpClient> GetClient()
        {
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }
        public async Task<SMResult> Login(string userName, string password)
        {
            SMResult result = new SMResult();
            Dictionary<string, string> loginParams = new Dictionary<string, string>();
            loginParams.Add("username", userName);
            loginParams.Add("password", password);
            await GetClient();

            var responsen = client.PostAsync(basaeUrl + @"Account/Login", new StringContent(JsonConvert.SerializeObject(loginParams), Encoding.UTF8, "application/json")).Result;
            var stringResult = responsen.Content.ReadAsStringAsync().Result;
            if (responsen != null)
            {
                result.Success = true;
                result.ResultData = JsonConvert.DeserializeObject<Dictionary<string, string>>(stringResult);
            }
            else
            {
                result.Success = false;
                result.Message = "Yanıt yok";
            }
            return result;
        }
        public async Task<SMResult> GetListMobile(int limit, int start, bool includeVisitStats)
        {
            Dictionary<string, object> paramList = new Dictionary<string, object>();
            paramList.Add("Limit", limit);
            paramList.Add("Start", start);
            paramList.Add("IncludeVisitStats", includeVisitStats);
            SMResult result = new SMResult();
            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
            var responsen = client.PostAsync(basaeUrl + @"Card/GetListMobile", new StringContent(JsonConvert.SerializeObject(paramList), Encoding.UTF8, "application/json")).Result;
            var stringResult = responsen.Content.ReadAsStringAsync().Result;
            GetListResponseData rp = JsonConvert.DeserializeObject<GetListResponseData>(stringResult);
            result.Success = rp.success;
            result.ResultData = JsonConvert.DeserializeObject<List<MobileDataModel>>(rp.data.ToString());
            return result;
        }
        public async Task<SMResult> GetUserMobile()
        {
            SMResult sMResult = new SMResult();
            var response = client.GetStringAsync(basaeUrl + @"Account/GetUserMobile").Result;
            GetListResponseData gld = JsonConvert.DeserializeObject<GetListResponseData>(response.ToString());
            sMResult.Success = gld.success;
            var userInfo = JsonConvert.DeserializeObject<Dictionary<string, object>>(gld.data.ToString());
            var user = new User();
            user.UserName = userInfo["UserName"].ToString();
            user.FullName = userInfo["FullName"].ToString();
            user.PositionDescription = userInfo["PositionDescription"].ToString();
            user.EMail = userInfo["EMail"].ToString();
            user.UserId = Guid.Parse(userInfo["UserId"].ToString());
            user.CardId = int.Parse(userInfo["CardId"].ToString());
            sMResult.ResultData = user;
            return sMResult;
        }
    }
}
