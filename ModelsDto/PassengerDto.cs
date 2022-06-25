using Newtonsoft.Json;
using SelfHostedServer.ModelsDTO.Filters;
using System;
using System.ComponentModel.DataAnnotations;

namespace SelfHostedServer.ModelsDTO.ModelsDto
{
    public class PassengerDto
    {
        [Required]
        [JsonProperty("name")]
        [MinLength(2, ErrorMessage = "Name can't be less than 2 characters.")]
        public String Name { get; set; }

        [Required]
        [JsonProperty("surname")]
        [MinLength(2, ErrorMessage = "Surame can't be less than 2 characters.")]
        public String Surname { get; set; }

        [Required]
        [JsonProperty("patronymic")]
        public String Patronymic { get; set; }

        [Required]
        [JsonProperty("doc_type")]
        public String DocType { get; set; }

        [Required]
        [JsonProperty("doc_number")]
        public UInt64 DocNumber { get; set; }

        [Required]
        [YoungPassenger(2)]
        [OldPassenger(80)]
        [MaxDateOfBirth]
        [JsonProperty("birthdate")]
        public DateTime Birthdate { get; set; }

        [Required]
        [RightGender]
        [JsonProperty("gender")]
        public String Gender { get; set; }

        [Required]
        [JsonProperty("passenger_type")]
        public String PassengerType { get; set; }

        [Required]
        [JsonProperty("ticket_number")]
        [Range(1000000000000, 9999999999999)]
        public UInt64 TicketNumber { get; set; }

        [Required]
        [JsonProperty("ticket_type")]
        public int TicketType { get; set; }
    }
}
