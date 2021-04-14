
namespace RestASPNET_NET5.Data.VO
{
    public class PersonVO
    {
        public long Id { get; set; }

        public string FirstName { get; set; }

        public string LasName { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }

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
