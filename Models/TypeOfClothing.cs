//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WardrobeProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypeOfClothing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypeOfClothing()
        {
            this.Wardrobes = new HashSet<Wardrobe>();
        }
    
        public int TypeOfClothingID { get; set; }
        public string ClothingType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Wardrobe> Wardrobes { get; set; }
    }
}
