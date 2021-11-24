using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Data
{
    public class UserService: IUser
    {
        private string uri = "http://localhost:8080/";
        
        public UserService()
        {
            client = new HttpClient();
        }
        HttpClient client = new HttpClient();
        private IUser _userImplementation;

       

        public async Task<IList<User>> GetUsers(IList<User> users)
        {
            using HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync("http://localhost:8080/friend/"+users);
            if (!responseMessage.IsSuccessStatusCode)
                throw new Exception(@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
        
            string result = await responseMessage.Content.ReadAsStringAsync();
            users = new[]
            {
                JsonSerializer.Deserialize<User>(result, new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                })
            };
            return users;
        }

        public Task<User> AddUsers(User user)
        {
            return _userImplementation.AddUsers(user);
        }

        public Task RemoveUsers(int adultId)
        {
            return _userImplementation.RemoveUsers(adultId);
        }

        public Task<User> Update(User user)
        {
            return _userImplementation.Update(user);
        }

        public Task<User> Get(int ID)
        {
            return _userImplementation.Get(ID);
        }
    }
}