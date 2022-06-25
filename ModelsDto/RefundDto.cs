using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace SelfHostedServer.ModelsDTO.ModelsDto
{
    public class RefundDto
    {
        [JsonProperty("operation_type")]
        [Required]
        public String OperationType { get; set; }

        [Required]
        [JsonProperty("operation_time")]
        public DateTimeOffset OperationTime { get; set; }

        [Required]
        [JsonProperty("operation_place")]
        public String OperationPlace { get; set; }

        [Required]
        [JsonProperty("ticket_umber")]
        public UInt64 TicketNumber { get; set; }
    }
}
