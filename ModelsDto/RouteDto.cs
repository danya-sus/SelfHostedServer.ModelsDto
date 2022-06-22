using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace SelfHostedServer.ModelsDTO.ModelsDto
{
    public class RouteDto
    {
        [Required]
        [JsonProperty("airline_code")]
        public String Airline_code { get; set; }

        [Required]
        [JsonProperty("flight_num")]
        public int Flight_num { get; set; }

        [Required]
        [JsonProperty("depart_place")]
        public String Depart_place { get; set; }

        [Required]
        [JsonProperty("depart_datetime")]
        public DateTimeOffset Depart_datetime { get; set; }

        [Required]
        [JsonProperty("arrive_place")]
        public String Arrive_place { get; set; }

        [Required]
        [JsonProperty("arrive_datetime")]
        public DateTimeOffset Arrive_datetime { get; set; }

        [Required]
        [JsonProperty("pnr_id")]
        public String Pnr_id { get; set; }
    }
}
