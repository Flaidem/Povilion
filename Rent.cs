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
    
    public partial class Rent
    {
        public int rent_id { get; set; }
        public int tentats_id { get; set; }
        public int Shop_Centr_id { get; set; }
        public int Emp_id { get; set; }
        public string num_povil { get; set; }
        public int stat_rent_id { get; set; }
        public System.DateTime start_date { get; set; }
        public System.DateTime end_time { get; set; }
    
        public virtual Empoloy Empoloy { get; set; }
        public virtual pavilion pavilion { get; set; }
        public virtual status_rent status_rent { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
