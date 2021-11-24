using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Data
{
    public interface IUser
    {
        Task<IList<User>> GetUsers(IList<User> users);

        Task<User> AddUsers(User user);

        Task RemoveUsers(int adultId);

        Task<User> Update(User user);

        Task<User> Get(int ID);


    }
}