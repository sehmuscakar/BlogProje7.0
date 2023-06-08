using System.ComponentModel.DataAnnotations;

namespace BlogProjeCore7._0.Entites
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "Adı"), StringLength(50)]
        public string Name { get; set; }
        [Display(Name = "Soyadı"), StringLength(50)]
        public string Surname { get; set; }
        [Display(Name = "Email"),EmailAddress] // display gürünecejk olan isim yani 
        public string Email { get; set; }
        [Display(Name = "Şİfre"), StringLength(50)]
        public string Password { get; set; }
        [Display(Name = "Kullanıci Adı"), StringLength(50)]
        public string? UserName { get; set; }
        [Display(Name = "Durum")]
        public bool IsActive { get; set; }
        [Display(Name = "Admin")]
        public bool IsAdmin { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        public DateTime? CreateDate { get; set; }=DateTime.Now;

    }
 }
