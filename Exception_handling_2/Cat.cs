using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_handling_2
{
    class Cat
    {
        public int Age { get; set; }

        public Cat() { }
        public Cat(int _age)
        {
            Age = _age;
        }
        public void AgeCheck()
        {
            if (Age <= 0) {throw new CustomCatError(Age);}
        }
    }
}
