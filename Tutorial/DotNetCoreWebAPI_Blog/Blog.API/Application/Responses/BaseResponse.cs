namespace Application.Responses
{
    public class BaseResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<string>? ValidationErrors { get; set; }

        public BaseResponse(string message = "", bool success = true)
        {
            Success = success;
            if (!string.IsNullOrEmpty(message))
            {
                Message = message;
            }
        }
    }
}
