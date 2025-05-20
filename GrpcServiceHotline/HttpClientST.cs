namespace GrpcServiceHotline
{
    public class HttpClientST
    {
        private static HttpClient httpClient;

        public static HttpClient HttpClient 
        { 
            get 
            {
                if (httpClient == null)
                    httpClient = new HttpClient()
                    {
                        BaseAddress = new Uri("http://192.168.4.100:61234/api")
                    };
                return httpClient;
            }
            
        }
    }
}
