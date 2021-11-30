using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Client.Models;

namespace Client.Data
{
    public interface ITest
    { 
        Task<Test> GetTestAsync(string z);
        Task<string> PostTest(string x, string y);

        Task<MenuObject> GetMenuAsync(int z);

        Task<OrderObject> SendOrderAsync(OrderObject o);

    }
}