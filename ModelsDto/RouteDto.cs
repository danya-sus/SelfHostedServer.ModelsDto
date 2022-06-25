using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace SelfHostedServer.ModelsDTO.ModelsDto
{
    public class RouteDto
    {
        [Required]
        [JsonProperty("airline_code")]
        public String AirlineCode { get; set; }

        [Required]
        [JsonProperty("flight_num")]
        public int FlightNum { get; set; }

        [Required]
        [JsonProperty("depart_place")]
        public String DepartPlace { get; set; }

        [Required]
        [JsonProperty("depart_datetime")]
        public DateTimeOffset DepartDatetime { get; set; }

        [Required]
        [JsonProperty("arrive_place")]
        public String ArrivePlace { get; set; }

        [Required]
        [JsonProperty("arrive_datetime")]
        public DateTimeOffset ArriveDatetime { get; set; }

        [Required]
        [JsonProperty("pnr_id")]
        public String PnrID { get; set; }
    }
}
