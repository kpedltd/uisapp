using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UisApp.Helpers
{
    class CustomDateConverter : IsoDateTimeConverter
    {
        public CustomDateConverter()
        {
            base.DateTimeFormat = "yyyy-MM-dd";
        }
    }

    class CustomTimeConverter : IsoDateTimeConverter
    {
        public CustomTimeConverter()
        {
            base.DateTimeFormat = "HH:mm:ss";
        }
    }

    class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter()
        {
            base.DateTimeFormat = "yyyy-MM-dd HH:mm";
        }
    }
}
