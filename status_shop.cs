//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Povilion
{
    using System;
    using System.Collections.Generic;
    
    public partial class status_shop
    {
        public status_shop()
        {
            this.Shop_Centers = new HashSet<Shop_Centers>();
        }
    
        public int Status_id { get; set; }
        public string desc_shop { get; set; }
    
        public virtual ICollection<Shop_Centers> Shop_Centers { get; set; }
    }
}
