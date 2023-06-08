using System.ComponentModel.DataAnnotations;

namespace BlogProjeCore7._0.Entites
{
    public class Contact
    {
        public int Id { get; set; }
        [Display(Name = "Adı"), StringLength(50)]
        public string Name { get; set; }
        [Display(Name = "Soyadı"), StringLength(50)]
        public string Surname { get; set; }
        [Display(Name = "Email"), EmailAddress] // display gürünecejk olan isim yani 
        public string? Email { get; set; }
        [Display(Name = "Mesaj"), StringLength(500)]
        public string Message { get; set; }
        [Display(Name = "Telefon"), StringLength(20)]
        public string? Phone { get; set; }

     
        [Display(Name = "Eklenme Tarihi")]
        public DateTime? CreateDate { get; set; } = DateTime.Now;
    }
}
