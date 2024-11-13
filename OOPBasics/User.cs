using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    internal class User
    {
        public string UserName { get; set; }
        public string Password { get; private set; }

        protected string id;

        public string Id
        {
            get { return id; }
        }

        public User(string usesrname, string password)
        {
            UserName = usesrname;
            Password = password;
        }

        public void ChangePassword(string oldPass, string newPass)
        {
            if(oldPass == Password)
            {
                Password = newPass;
            }
        }
        public void CreateId()
        {
            id = new IdGenerator().Generate();
        }
        
    }
}
