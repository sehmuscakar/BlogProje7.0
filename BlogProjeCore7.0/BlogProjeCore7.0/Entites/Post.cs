using System.ComponentModel.DataAnnotations;

namespace BlogProjeCore7._0.Entites
{
    public class Post// coklu ,bir postun bir tane categorisi olacak ,categorinin birden fazla postu olabailir
    {
        public int Id { get; set; }
        [Display(Name = "Gönderi Adı"), StringLength(100)]
        public string Name { get; set; }
        [Display(Name = "Gönderi Açıklaması")]
        public string? Description { get; set; }
        [Display(Name = "Gönderi Resmi"), StringLength(100)]
        public string? Image { get; set; }
        [Display(Name = "Durum")]
        public bool IsActive { get; set; }

        [Display(Name = "Eklenme Tarihi")]
        public DateTime? CreateDate { get; set; } = DateTime.Now;

        [Display(Name = "Güncellenme Tarihi")]
        public DateTime? UpdateDate { get; set; } = DateTime.Now;
        [Display(Name = "Kategori")] // burda view de gürünecek olan isim 
        public int CategoryId { get; set; } // tekli olan kısım 
        [Display(Name = "Kategori")]
        public Category? Category { get; set; } //buralara ? koy boş ta geçilebilsin yoksa crud işlemlerinde hataya sebep olabiliyor
    }
}
