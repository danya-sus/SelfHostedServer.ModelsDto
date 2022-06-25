using System;
using System.ComponentModel.DataAnnotations;

namespace SelfHostedServer.ModelsDTO.Filters
{
    public class OldPassengerAttribute : ValidationAttribute
    {
        public int Age { get; }
        public string GetErrorMessage() => "The maximum age of the passenger has been exceeded.";
    
        public OldPassengerAttribute(int age)
        {
            this.Age = age;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var age = DateTime.Now.Year - ((DateTime)value).Year;
            if (Age < age)
            {
                return new ValidationResult(GetErrorMessage());
            }
            return ValidationResult.Success;
        }
    }
}
