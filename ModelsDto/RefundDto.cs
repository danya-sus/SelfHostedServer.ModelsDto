using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace SelfHostedServer.ModelsDTO.ModelsDto
{
    public class RefundDto
    {
        [JsonProperty("operation_type")]
        [Required]
        public String Operation_type { get; set; }

        [Required]
        [JsonProperty("operation_time")]
        public DateTimeOffset Operation_time { get; set; }

        [Required]
        [JsonProperty("operation_place")]
        public String Operation_place { get; set; }

        [Required]
        [JsonProperty("ticket_umber")]
        public UInt64 Ticket_number { get; set; }
    }
}
