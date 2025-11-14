using System.ComponentModel.DataAnnotations;

namespace ThucHanh1.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên
        [Required]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Ho ten phai co do dai tu 4 den 100 ky tu")]
        [Display(Name = "Họ tên")]
        public string? Name { get; set; } //Họ tên
        [Required(ErrorMessage = "Email bat buoc phai duoc nhap")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Email khong hop le")]
        public string? Email { get; set; } //Email
        [Required]
        [Display(Name = "Mật khẩu")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mat khau phai co do dai tu 8 den 100 ky tu")]
        public string? Password { get; set; }//Mật khẩu
        [Required]
        [Display(Name = "Ngành học")]
        public Branch? Branch { get; set; }//Ngành học
        [Required]
        [Display(Name = "Giới tính")]
        public Gender? Gender { get; set; }//Giới tính
        [Display(Name = "Hệ đào tạo")]
        public bool IsRegular { get; set; }//Hệ: true chính qui, false-phi cq
        [Required]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Địa chỉ")]
        public string? Address { get; set; }//Địa chỉ
        [Required]
        [Range(typeof(DateTime), "1/1/1963", "31/12/2005")]
        [DataType(DataType.Date)]
        [Display(Name = "Ngày sinh")]
        public DateTime DateOfBorth { get; set; }//Ngày sinh
        [Display(Name = "Ảnh đại diện")]
        public string? ProfilePicture { get; set; } //ảnh đại diện
        [Required]
        [Display(Name = "Điểm")]
        [Range(0.0, 10.0, ErrorMessage = "Diem phai trong khoang tu 0.0 den 10.0")]
        public double Point { get; set; } //Điểm
    }
}
