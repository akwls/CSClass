using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    class SingleTon { 

        private static SingleTon instance = null;
    
        private SingleTon()
        {

        }

        public static SingleTon getInstance()
        {
            if(instance == null)
            {
                return new SingleTon();
            }
            return instance;
        }
    }
}
