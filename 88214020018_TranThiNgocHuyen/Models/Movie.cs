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
        [StringLength(1000)]
        public string? Summary { get; set; }

        // Thể loại text (dùng để hiển thị)
        [Display(Name = "Thể loại")]
        [StringLength(50)]
        [Genre]
        public string GenreName { get; set; } = string.Empty;

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

        // Khóa ngoại Genre
        [Display(Name = "Mã thể loại")]
        public int? GenreId { get; set; }

        public Genre? Genre { get; set; }

        // ✅ Alias cho các View/Controller đang dùng GenreID
        [NotMapped]
        public int? GenreID
        {
            get => GenreId;
            set => GenreId = value;
        }

        // ✅ Alias cho các View/Controller đang dùng Rated
        [NotMapped]
        public double Rated
        {
            get => Rating;
            set => Rating = value;
        }

        // ✅ Chỗ lưu đường dẫn file hình trong DB
        [Display(Name = "Đường dẫn ảnh")]
        public string? PicturePath { get; set; }

        // ✅ Dùng để upload file từ form (không lưu trong DB)
        [NotMapped]
        [Display(Name = "Ảnh")]
        public IFormFile? PictureUpload { get; set; }

        [NotMapped]
        [Display(Name = "Thông tin đầy đủ")]
        public string FullInfo =>
            $"{Title} ({ReleaseDate:yyyy}) - {GenreName}";
    }
}