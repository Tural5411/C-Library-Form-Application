//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_K300.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reader()
        {
            this.Book_To_Reader = new HashSet<Book_To_Reader>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phono { get; set; }
        public Nullable<int> FacultyId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book_To_Reader> Book_To_Reader { get; set; }
        public virtual Faculty Faculty { get; set; }
    }
}
