//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameStoreDB1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Console
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Console()
        {
            this.Items = new HashSet<Item>();
        }
    
        public int ConsoleId { get; set; }
        public Nullable<int> ModelID { get; set; }
        public string SerialNumber { get; set; }
        public Nullable<int> Color { get; set; }
    
        public virtual Color Color1 { get; set; }
        public virtual Model Model { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Item> Items { get; set; }
    }
}
