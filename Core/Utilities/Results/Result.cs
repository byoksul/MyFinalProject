using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Dont Repeat Your Self
    public class Result : IResult
    {
       

        public Result(bool succes, string mesage):this(succes)
        {
            Message = mesage;
             

        }
        public Result(bool succes)
        {
            Success = succes;

        }

        public bool Success {get;}
        public string Message { get; }

    }
}
