//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace THDShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class GIFT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIFT()
        {
            this.MYGIFTs = new HashSet<MYGIFT>();
        }
    
        public string ID { get; set; }
        public int G_POINT { get; set; }
        public double G_VALUE { get; set; }
        public Nullable<System.DateTime> G_START { get; set; }
        public Nullable<System.DateTime> G_END { get; set; }
        public string DESCREPTION { get; set; }
        public Nullable<int> QUANTITY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MYGIFT> MYGIFTs { get; set; }
    }
}
