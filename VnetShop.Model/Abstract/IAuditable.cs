using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VnetShop.Model.Abstract
{
    public interface IAuditable
    {
        // DateTime
        DateTime? CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }

        // SEO
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

        // Switchable
        bool Status { set; get; }

    }
}
