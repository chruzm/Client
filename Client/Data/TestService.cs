using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Data
{
    public class TestService : ITest
    {
        private string uri = "http://localhost:8080/";
        
        public TestService()
        {
            client = new HttpClient();
        }
        HttpClient client = new HttpClient();
        

            //get method virker nu, connected til server. 
        public async Task<Test> GetTestAsync(string z)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync("http://localhost:8080/friend/"+z);
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception(@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
        
            string result = await responseMessage.Content.ReadAsStringAsync();
            Test fams = JsonSerializer.Deserialize<Test>(result, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return fams;
        }

        
        public async Task<string> PostTest(string x, string y) {
            HttpClient client = new HttpClient();
            Test tst = new Test {
                name = x,
                phoneNo = y
            };
            string testSerialized = JsonSerializer.Serialize(tst);

            StringContent content = new StringContent(
                testSerialized,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage response = await client.PostAsync("http://localhost:8080/friend/"+tst.phoneNo, content);
            return response.ToString();
        }
    }
}