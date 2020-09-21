namespace backend.Models.Response
{
    public class  ErrorResponse
    {
        public int code { get; set; }
        public string error { get; set; }
        public ErrorResponse(string e,int c)
        {
            this.code = c;
            this.error = e;
        }
    }
}