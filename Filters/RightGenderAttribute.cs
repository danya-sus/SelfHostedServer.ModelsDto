using System;
using System.ComponentModel.DataAnnotations;

namespace SelfHostedServer.ModelsDTO.Filters
{
    public class RightGenderAttribute : ValidationAttribute
    {
        public string GetErrorMessage() => "There is no such gender.";

        public RightGenderAttribute() { }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var gender = (string)value;

            if (gender != "M" && gender != "F")
            {
                return new ValidationResult(GetErrorMessage());
            }
            return ValidationResult.Success;
        }
    }
}
