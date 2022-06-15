namespace MiniCommerce.UI.Models
{
    public enum Status
    {
        Ok,
        Error,
        BadRequest,
        NotFound
    }
    public class JResult
    {
        public Status Status { get; set; }
        public string Message { get; set; }
        public string Title { get; set; }
    }

}
