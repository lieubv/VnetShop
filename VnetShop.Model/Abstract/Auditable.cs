using System;
using System.ComponentModel.DataAnnotations;

namespace VnetShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { set; get; }

        [MaxLength(256)]
        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }

        [MaxLength(256)]
        public string UpdatedBy { set; get; }

        // SEO
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
        
        // Switchable
        public bool Status { set; get; }
    }
}