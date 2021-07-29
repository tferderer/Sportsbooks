using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOddsApi.Models
{
    public class Settings
    {
        public TheOddsApi TheOddsApi { get; set; }
    }

    public class TheOddsApi
    {
        public string Key { get; set; }

        public string BaseUrl { get; set; }
    }
}
