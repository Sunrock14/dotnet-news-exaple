namespace News.Core.Response
{
    public class DataResponse<T> : IDataResponse<T>
    {
        public T Data { get; }
        public int StatusCode { get; }
        public string Message { get; }
        public Exception Exception { get; }

        public DataResponse(T data)
        {
            Data = data;
        }
        public DataResponse(int statusCode, T data)
        {
            StatusCode = statusCode;
            Data = data;
        }
        public DataResponse(int statusCode, string message, T data)
        {
            StatusCode = statusCode;
            Message = message;
            Data = data;
        }
        public DataResponse(int statusCode, string message, T data, Exception exception)
        {
            StatusCode = statusCode;

            Message = message;
            Data = data;
            Exception = exception;
        }
    }
}
