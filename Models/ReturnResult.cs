namespace ApiOfThings.Models
{
    public class ReturnResult
    {
        public string ErrorMessage { get; set; }
        public string Data { get; set; }
        public bool HasError
        {
            get
            {
                return !string.IsNullOrWhiteSpace(ErrorMessage);
            }
        }
    }
}
