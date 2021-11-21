using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LSolutions.Entities.Dtos
{
    public class CategoryAddDto
    {
        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} adı boş olamaz.")]
        [MaxLength(70,ErrorMessage = "{0} {1} karakterden fazla olamaz.")]
        [MinLength(3,ErrorMessage = "{0} {1} karakterden az olamaz.")]
        public string Name { get; set; }
        [DisplayName("Kategori Açıklaması")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden fazla olamaz.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olamaz.")]
        public string Description { get; set; }
        [DisplayName("Kategori Özel Not Alanı")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden fazla olamaz.")]
        [MinLength(3, ErrorMessage = "{0} {1} karakterden az olamaz.")]
        public string Note { get; set; }
        [DisplayName("Kategori Aktif Mi?")]
        [Required(ErrorMessage = "{0} adı boş olamaz.")]
        public bool IsActive { get; set; }

    }
}