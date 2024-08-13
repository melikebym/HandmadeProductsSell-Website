using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E_CommerceAppMVC.Identity
{
    public enum EnumOrderState
    {
        [Display(Name ="Hazırlanıyor")]
        Hazırlanıyor,
        [Display(Name = "Tamamlandı")]
        Tamamlandı
    }
}