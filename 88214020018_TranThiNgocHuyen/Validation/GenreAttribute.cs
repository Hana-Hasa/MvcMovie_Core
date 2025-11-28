public class GenreAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
{
int genreID = int.Parse(value.ToString());
var _context = (ApplicationDbContext)validationContext
.GetService(typeof(ApplicationDbContext));
if (_context.Genres.Any(x => x.ID == genreID))
{
return ValidationResult.Success;
}
return new ValidationResult(
ErrorMessage ?? "Genre khong ton tai");
}
}