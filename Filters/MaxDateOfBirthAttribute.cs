﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SelfHostedServer.ModelsDTO.Filters
{
    public class MaxDateOfBirthAttribute : ValidationAttribute
    {
        public int Year { get; }
        public string GetErrorMessage() => "Your date of birth from the future.";

        public MaxDateOfBirthAttribute()
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (DateTime.Now.Year < ((DateTime)value).Year)
            {
                return new ValidationResult(GetErrorMessage());
            }
            return ValidationResult.Success;
        }
    }
}
