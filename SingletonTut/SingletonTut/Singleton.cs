using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTut
{
    public class Singleton
    {
        // Our Unique Singleton Instance
        private static Singleton uniqueInstance;

        // Private Constructor
        private Singleton() { }

        // Retrieve your unique instance
        public static Singleton GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Singleton();
            }
            return uniqueInstance;
        }
    }
}
