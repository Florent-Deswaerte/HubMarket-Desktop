using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubMarket_Desktop
{
    public sealed class Singleton
    {
        private User user;
        private Singleton() { }

        private static Singleton _instance;

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public User GetUser()
        {
            return this.user;
        }

        public User SetUser(User user)
        {
            this.user = user;
            return this.user;
        }
    }
}
