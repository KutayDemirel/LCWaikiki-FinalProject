using MiniCommerce.UI.Enums;

namespace MiniCommerce.UI.Models
{
    public class ResponseBase
    {
        public ResultTypeEnum ResultType { get; }
        public string Message { get; }
        public string ResponseType { get; set; }

        public ResponseBase(string message, ResultTypeEnum resultType)
        {
            Message = message;
            ResultType = resultType;
            ResponseType = resultType.ToString();

        }
    }

}
