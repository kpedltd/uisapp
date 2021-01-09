using Newtonsoft.Json.Converters;

namespace UisApp.Helpers
{
    internal class CustomDateConverter : IsoDateTimeConverter
    {
        public CustomDateConverter()
        {
            base.DateTimeFormat = "yyyy-MM-dd";
        }
    }

    internal class CustomTimeConverter : IsoDateTimeConverter
    {
        public CustomTimeConverter()
        {
            base.DateTimeFormat = "HH:mm:ss";
        }
    }

    internal class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter()
        {
            base.DateTimeFormat = "yyyy-MM-dd HH:mm";
        }
    }
}