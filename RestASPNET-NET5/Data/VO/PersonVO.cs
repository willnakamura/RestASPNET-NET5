
using RestASPNET_NET5.Hypermedia;
using RestASPNET_NET5.Hypermedia.Abstract;
using System.Collections.Generic;

namespace RestASPNET_NET5.Data.VO
{
    public class PersonVO :ISupportsHyperMedia
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }

        public bool Enabled { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

        /*
         *CUSTOM SERIALIZATION
        [JsonPropertyName("code")]
        public long Id { get; set; }

        [JsonPropertyName("name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonIgnore]
        public string Address { get; set; }

        [JsonPropertyName("sex")]
        public string Gender { get; set; }
        */
    }
}
