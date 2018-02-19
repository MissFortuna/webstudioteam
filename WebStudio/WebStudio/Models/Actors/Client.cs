using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStudio.Classes
{
    public class Client
    {
        public int client_id { get; set; }
        public string client_name { get; set; }
        public string address { get; set; }

        public Client(int client_id, string client_name,string address)
        {
            this.client_id = client_id;
            this.client_name = client_name;
            this.address = address;
        }
    }
}