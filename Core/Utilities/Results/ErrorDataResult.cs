using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T>:DataResult<T>
    {

        public ErrorDataResult() : base(default, false)
        {      
               
        }      
        public ErrorDataResult(T Data) : base(Data, false)
        {    
        }    
             
        public ErrorDataResult(T Data, string message) : base(Data, false, message)
        {     
              
        }     
              
              
        public ErrorDataResult(string message) : base(default, false, message)
        {
        }
    }
}
