namespace ApiOfThings.Models
{
    public class ReturnResult<T>
    {
        public ReturnResult()
        {

        }

        public ReturnResult(T data)
        {
            Data = data;
        }

        public string ErrorMessage { get; set; }
        public T Data { get; set; }
        public bool HasError
        {
            get
            {
                return !string.IsNullOrWhiteSpace(ErrorMessage);
            }
        }
    }
}
