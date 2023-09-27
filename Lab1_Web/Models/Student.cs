using System.ComponentModel.DataAnnotations;

namespace Lab1_Web.Models
{
    public class Student
    {
        [Display(Name ="Mã sinh viên")]
        public int Id { get; set; }//Mã sinh viên

        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Họ tên bắt buộc phải được nhập và tối thiểu 4 ký tự, tối đa 100 ký tự")]
        [StringLength(100, MinimumLength = 4)]
        public string? Name { get; set; } //Họ tên

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email bắt buộc phải được nhập")]
        /*[RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]*/
        [RegularExpression(@"^\w+([\.-]?\w+)*@gmail\.com$", ErrorMessage = "Địa chỉ email phải có đuôi gmail.com")]
        public string? Email { get; set; } //Email

        /*[StringLength(100, MinimumLength = 8)]
        [Required]*/
        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu là bắt buộc.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W).{8,}$", ErrorMessage = "Mật khẩu từ 8 ký tự trở lên, có ký tự viết hoa, viết thường, chữ số và ký tự đặc biệt.")]
        public string? Password { get; set; }//Mật khẩu
       
        [Display(Name = "Ngành học")]
        [Required]
        public Branch? Branch { get; set; }//Ngành học
        [Display(Name = "Giới tính")]
        [Required(ErrorMessage = "Trường giới tính là bắt buộc.")]
        public Gender? Gender { get; set; }//Giới tính

        [Display(Name = "Hệ: ")]
        public bool IsRegular { get; set; }//Hệ: true-chính quy, false-phi chính quy

        [Display(Name = "Địa chỉ")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Trường địa chỉ là bắt buộc.")]
        public string? Address { get; set; }//Địa chỉ

        [Display(Name = "Ngày sinh")]
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005", ErrorMessage = "Ngày sinh phải trong khoảng 1/1/1963 đến 12/31/2005.")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Trường ngày sinh là bắt buộc.")]
        public DateTime DateOfBorth { get; set; }//Ngày sinh

        [Display(Name = "Điểm")]
        [Required(ErrorMessage = "Trường điểm là bắt buộc.")]
        [Range(0.0, 10.0, ErrorMessage = "Trường điểm phải nằm trong khoảng [0,10].")]
        public double Score { get; set; } //Điểm
    }
}
