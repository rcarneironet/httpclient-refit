namespace HttpClientFactoryProject.Configuration
{
    public interface IApiConfig
    {
        public string BaseUrl { get; set; }
    }
    public class ApiConfig : IApiConfig
    {
        public string BaseUrl { get; set; }
    }
}
