using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using _88214020018_TranThiNgocHuyen.Validation;

namespace _88214020018_TranThiNgocHuyen.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Display(Name = "Tên phim")]
        [Required]
        [StringLength(200)]
        public string Title { get; set; } = string.Empty;

        [Display(Name = "Tóm tắt")]
        [StringLength(500)]
        public string? Summary { get; set; }

        [Display(Name = "Ngày phát hành")]
        [DataType(DataType.Date)]
        [CheckDateGreaterThanToday(ErrorMessage = "Ngày phát hành phải lớn hơn hôm nay")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Giá")]
        [Range(0, 999999)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

[Display(Name = "Đánh giá")]
[Range(0, 10)]
public double Rating { get; set; }

        [Display(Name = "Thể loại")]
        [StringLength(50)]
        public string GenreName { get; set; } = string.Empty;

        [ForeignKey("Genre")]
        [Display(Name = "Mã thể loại")]
        public int? GenreId { get; set; }

        public Genre? Genre { get; set; }

        [Display(Name = "Ảnh")]
        [StringLength(255)]
        public string? PicturePath { get; set; }

        [NotMapped]
        [Display(Name = "Chọn ảnh")]
        public IFormFile? PictureUpload { get; set; }

        [NotMapped]
        [Display(Name = "Thông tin đầy đủ")]
        public string FullInfo => $"{Title} ({ReleaseDate:yyyy}) - {GenreName}";
    }
}