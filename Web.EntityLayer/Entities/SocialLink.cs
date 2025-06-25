using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.EntityLayer.Entities
{
  public  class SocialLink
    {
        public int Id { get; set; }

        public int FooterContentId { get; set; }
        public FooterContent FooterContent { get; set; }

        public string PlatformName { get; set; } // Örn: Instagram, LinkedIn
        public string Url { get; set; }          // Örn: https://instagram.com/dukkan
        public string IconUrl { get; set; }    // (isteğe bağlı) CSS ikon class'ı: fab fa-instagram gibi
    }
}
