using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Duck
    {
        public void Quack()
        {
            throw new System.NotImplementedException();
        }

        public void Swim()
        {
            throw new System.NotImplementedException();
        }

        public abstract void Display();        
    }
}