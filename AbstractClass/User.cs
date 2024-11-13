using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public abstract class User
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

        public virtual void ChangePassword(string oldPass, string newPass)
        {
            if(oldPass == Password)
            {
                Password = newPass;
            }
        }
        public abstract void CreateId();

    }
}
