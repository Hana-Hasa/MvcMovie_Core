using System;
using System.ComponentModel.DataAnnotations;

namespace _88214020018_TranThiNgocHuyen.Validation
{
    public class CheckDateGreaterThanTodayAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime dateValue)
            {
                if (dateValue <= DateTime.Today)
                {
                    return new ValidationResult(
                        ErrorMessage ?? "Ngày phải lớn hơn ngày hôm nay."
                    );
                }
            }

            return ValidationResult.Success;
        }
    }
}