namespace OrderProcessing.Configuration
{
    public static class AppSettingsManager
    {
        private static AppSettings? _appSettings;

        public static void Initialize(IConfiguration configuration)
        {
            _appSettings = configuration.GetSection("AppSettings").Get<AppSettings>() ?? new AppSettings();
        }

        public static AppSettings AppSettings => _appSettings ?? new AppSettings();
    }
}
