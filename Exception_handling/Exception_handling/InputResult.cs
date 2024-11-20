using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    public class InputResult
    {
        public bool Sucess { get; set; }
        public int[] Result = new int[2];
        public string Message {  get; set; }



        public InputResult()
        {
        }
    }
}
