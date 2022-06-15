using MiniCommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Models
{
    public class ResponseBase
    {
        public ResponseBase(string message,ResultTypeEnum resultType)
        {
            Message = message;
            ResultType = resultType;
            ResponseType = resultType.ToString();
        }

        public string ResponseType{ get; set; }

        public string Message { get; }

        public ResultTypeEnum ResultType { get; set; }

       
       
    }
}
