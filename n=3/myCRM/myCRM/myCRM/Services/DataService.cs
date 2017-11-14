using myCRM.Models;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;


namespace myCRM.Services
{
    public class DataService:IDataService
    {
        public DataService()
        {

        }
        
        public async Task<List<Contact>> GetContacts()
        {
            await Task.Delay (TimeSpan.FromSeconds(3));
            return new List<Contact>
            {
                new Contact { Name = "Peter", Number = "12345" },
                new Contact { Name = "Punk", Number = "12346" }
            };
        }

    }
}