using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SelfHostedServer.ModelsDTO.ModelsDto
{
    public class SaleDto
    {
        [Required]
        [JsonProperty("operation_type")]
        public String OperationType { get; set; }

        [Required]
        [JsonProperty("operation_time")]
        public DateTimeOffset OperationTime { get; set; }

        [Required]
        [JsonProperty("operation_place")]
        public String OperationPlace { get; set; }

        [Required]
        [JsonProperty("passenger")]
        public PassengerDto Passenger { get; set; }

        [Required]
        [JsonProperty("routes")]
        public IEnumerable<RouteDto> Routes { get; set; }
    }
}
