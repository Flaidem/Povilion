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
    
    public partial class pavilion
    {
        public pavilion()
        {
            this.Rents = new HashSet<Rent>();
        }
    
        public int Shop_Centr_id { get; set; }
        public string num_povil { get; set; }
        public int floor { get; set; }
        public int status_id { get; set; }
        public float area { get; set; }
        public decimal cost { get; set; }
        public Nullable<float> value_added { get; set; }
    
        public virtual Shop_Centers Shop_Centers { get; set; }
        public virtual status_povil status_povil { get; set; }
        public virtual ICollection<Rent> Rents { get; set; }
    }
}
