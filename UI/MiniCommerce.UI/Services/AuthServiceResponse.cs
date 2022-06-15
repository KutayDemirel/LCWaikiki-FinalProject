using MiniCommerce.UI.Enums;
using MiniCommerce.UI.Models;
using Newtonsoft.Json;

namespace MiniCommerce.UI.Services
{
    public class AuthServiceResponse<TKey> : ResponseBase
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TKey Data { get; }
        public AuthServiceResponse(ResultTypeEnum resultType, string message, TKey data) : base(message, resultType)
        {
            Data = data;
        }
    }
}
