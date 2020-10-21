using System;
using System.Collections.Generic;
using System.Text;

namespace Exception_handling_2
{
    class CustomCatError : System.ApplicationException
    {
        public CustomCatError(int age) : base(String.Format("A cats age can not be lower or equal to 0 , given age:{0}", age)) {}
    }
}
