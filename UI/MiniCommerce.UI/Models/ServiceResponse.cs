using MiniCommerce.Application.Models;
using MiniCommerce.UI.Enums;
using Newtonsoft.Json;

namespace MiniCommerce.UI.Models
{
    public class ServiceResponse<TKey> : ResponseBase

    {

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TKey Data { get; }
        public ServiceResponse(ResultTypeEnum resultType, string message, TKey data) : base(message, resultType)
        {
            Data = data;
        }
    }

}
