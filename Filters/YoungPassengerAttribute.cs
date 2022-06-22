using System;
using System.ComponentModel.DataAnnotations;

namespace SelfHostedServer.ModelsDTO.Filters
{
    public class YoungPassengerAttribute : ValidationAttribute
    {
        public int Age { get; }
        public string GetErrorMessage() => $"For a child of {Age} years, you can not buy a ticket.";

        public YoungPassengerAttribute(int age)
        {
            Age = age;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var age = DateTime.Now.Year - ((DateTime)value).Year;
            if (age < Age && age >= 0)
            {
                return new ValidationResult(GetErrorMessage());
            }
            return ValidationResult.Success;
        }
    }
}
