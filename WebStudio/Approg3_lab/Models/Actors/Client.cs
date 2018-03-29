using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStudio.Classes
{
    public class Client
    {
        public string client_id { get; set; }
        public string client_name { get; set; }

        //TODO: id
        public Client(string client_name)
        {
            //    client_id = client_id;
            this.client_name = client_name;
        }
    }
}