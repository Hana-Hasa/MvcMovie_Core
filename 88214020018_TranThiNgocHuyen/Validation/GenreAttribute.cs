using System.ComponentModel.DataAnnotations;

namespace _88214020018_TranThiNgocHuyen.Validation
{
    public class GenreAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
            {
                return new ValidationResult(ErrorMessage ?? "Thể loại không được để trống.");
            }

            // Ví dụ: không cho nhập toàn số
            var str = value.ToString()!;
            if (int.TryParse(str, out _))
            {
                return new ValidationResult(ErrorMessage ?? "Thể loại không được chỉ toàn số.");
            }

            return ValidationResult.Success;
        }
    }
}