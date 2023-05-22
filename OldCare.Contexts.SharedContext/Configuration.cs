using OldCare.Contexts.SharedContext.Extensions;

namespace OldCare.Contexts.SharedContext;

public static class Configuration
{
    public static string Host { get; set; } = "https://oldcare.azurewebhosts.com/";
    public static SecretsConfiguration Secrets { get; set; } = new();
    public static DatabaseConfiguration Database { get; set; } = new();
    public static SendGridConfiguration SendGrid { get; set; } = new();
    public static AzureConfiguration Azure { get; set; } = new();
    public static GoogleConfiguration Google { get; set; } = new();
    public static FacebookConfiguration Facebook { get; set; } = new();
    public static OneSignalConfiguration OneSignal { get; set; } = new();
    public static DiscordConfiguration Discord { get; set; } = new();

    public class SecretsConfiguration
    {
        public string JwtTokenSecret { get; set; } = string.Empty;
        public string ApiKey { get; set; } = string.Empty;
        public string PrivateKey { get; set; } = string.Empty;
    }

    public class DatabaseConfiguration
    {
        public string ConnectionString { get; set; } = string.Empty;
        public string InMemoryDatabaseName { get; set; } = string.Empty;
    }

    
    public class SendGridConfiguration
    {
        public string ApiKey { get; set; } = string.Empty;
        public string ApiUrl { get; set; } = string.Empty;
    }

    public class TwillioConfiguration
    {
        public string AccountSID { get; set; } = string.Empty;
        public string AuthToken { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
    }

    public class AzureConfiguration
    {
        public AzureCdnConfiguration Cdn { get; set; } = new();

        public class AzureCdnConfiguration
        {
            public string Root { get; set; } = string.Empty;
            public string Images { get; set; } = string.Empty;
            public string Css { get; set; } = string.Empty;
            public string Js { get; set; } = string.Empty;
            public string Articles { get; set; } = string.Empty;
            public string Agendas { get; set; } = string.Empty;
            public string Courses { get; set; } = string.Empty;
            public string Lectures { get; set; } = string.Empty;
            public string Careers { get; set; } = string.Empty;
            public string Plans { get; set; } = string.Empty;
        }
    }

    public class GoogleConfiguration
    {
        public GoogleAnalyticsConfiguration Analytics { get; set; } = new();
        public GoogleReCaptchaConfiguration ReCaptcha { get; set; } = new();

        public class GoogleAnalyticsConfiguration
        {
            public string Key { get; set; } = string.Empty;
        }

        public class GoogleReCaptchaConfiguration
        {
            public string ApiUrl { get; set; } = string.Empty;
            public string SiteKey { get; set; } = string.Empty;
            public string SiteSecret { get; set; } = string.Empty;
        }
    }

    public class FacebookConfiguration
    {
        public string PixelId { get; set; } = string.Empty;
    }

    public class OneSignalConfiguration
    {
        public string AppId { get; set; } = string.Empty;
    }

    public class DiscordConfiguration
    {
        public DiscordConfigurationWebhooks Webhooks { get; set; } = new();

        public class DiscordConfigurationWebhooks
        {
            public string ApplicationEventsLog { get; set; } = string.Empty;
            public string UserActivitiesLog { get; set; } = string.Empty;
            public string WarningsLog { get; set; } = string.Empty;
            public string ErrorsLog { get; set; } = string.Empty;
        }
    }
}