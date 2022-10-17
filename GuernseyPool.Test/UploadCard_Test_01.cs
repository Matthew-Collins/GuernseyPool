using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GuernseyPool.Test
{
    [TestClass]
    public class UploadCard_Test_01
    {
        [TestMethod]
        public void TestSub()
        {
            var Model = new GuernseyPool.Model.ScoreCard(true);
            var Data = JsonContent.Create(Model);
            var Client = new HttpClient();
            var Response = Client.PostAsync("https://leaguenights.click/GuernseyPool/Submit", Data).Result;
            if (Response.IsSuccessStatusCode)
            {
                Console.WriteLine(Response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                Assert.Fail(Response.StatusCode.ToString());
            }
        }
    }
}