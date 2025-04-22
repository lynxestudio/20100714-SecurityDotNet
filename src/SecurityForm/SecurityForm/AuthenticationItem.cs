using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityForm
{
    internal class AuthenticationItem
    {
        public string Id { get; private set; }
        public string Name { get; private set; }

        public AuthenticationItem(string id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
