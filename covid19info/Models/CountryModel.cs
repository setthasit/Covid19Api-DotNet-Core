using System;


namespace covid19info.Models {
    public class CountryBase {
        public string Country { get; }
        public string CountryCode { get; }
        public string ISO2 { get; }
        public string Slug { get; }
        public string Lat { get; }
        public string Lon { get; }
    }

    public class CountrySummary : CountryBase {
        public long newConfirmed { get; }
        public long totalConfirmed { get; }
        public long newDeaths { get; }
        public long totalDeaths { get; }
        public long newRecovered { get; }
        public long totalRecovered { get; }
        public String date { get; }
    }

    public class CountryCase : CountryBase {
        public long Cases { get; }
        public string Status { get; }
    }
}
