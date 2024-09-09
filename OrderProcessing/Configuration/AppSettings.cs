namespace OrderProcessing.Configuration
{
    /// <summary>
    /// Collection of app settings taken from appsettings.json
    /// </summary>
    public class AppSettings
    {
        public ConnectionStrings ConnectionStrings { get; set; }

        public AppSettings()
        {
            ConnectionStrings = new ConnectionStrings();
        }
    }
}
