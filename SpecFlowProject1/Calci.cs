using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject1
{
    public class Calci
    {
        public int Add(int i, int j)
        {
            return i + j;
        }
        public bool res(string uid,string p)
        {
            if(p=="Test@123" && uid== "testuser1")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool res1(string pname,int q)
        {
            if(pname!=null &&pname!=" " && q > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
