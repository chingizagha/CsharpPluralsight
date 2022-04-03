using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    public class Worker
    {
        public int age;

        public Worker(int age)
        {
            this.age = age;
        }
    
        public Worker() : this(15)
        {

        }
    }
}
