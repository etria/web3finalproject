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

    public partial class Item
    {
        public int ItemId { get; set; }
        public Nullable<int> ConditionId { get; set; }
        public Nullable<int> TypeId { get; set; }

        public virtual Condition Condition { get; set; }
        public virtual Type Type { get; set; }
        public virtual Accessory Accessory { get; set; }
        public virtual Console Console { get; set; }
        public virtual Game Game { get; set; }






    }
}