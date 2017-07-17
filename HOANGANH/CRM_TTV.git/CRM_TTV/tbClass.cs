//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM_TTV
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbClass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbClass()
        {
            this.tbAttendances = new HashSet<tbAttendance>();
            this.tbBookRooms = new HashSet<tbBookRoom>();
            this.tbStudents = new HashSet<tbStudent>();
            this.tbTimeStudies = new HashSet<tbTimeStudy>();
            this.tbTimeTables = new HashSet<tbTimeTable>();
            this.tbTranscripts = new HashSet<tbTranscript>();
        }
    
        public int idClass { get; set; }
        public int idCompany { get; set; }
        public int idEducation { get; set; }
        public int idSpecialized { get; set; }
        public int idServicePack { get; set; }
        public int idScience { get; set; }
        public int @object { get; set; }
        public int idLever { get; set; }
        public string name { get; set; }
        public string timeStudy { get; set; }
        public double saveOff { get; set; }
        public Nullable<int> studentRepresent { get; set; }
        public Nullable<int> teacherRepresent { get; set; }
        public string note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAttendance> tbAttendances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbBookRoom> tbBookRooms { get; set; }
        public virtual tbCategory tbCategory { get; set; }
        public virtual tbCompany tbCompany { get; set; }
        public virtual tbEducation tbEducation { get; set; }
        public virtual tbLever tbLever { get; set; }
        public virtual tbScience tbScience { get; set; }
        public virtual tbServicePack tbServicePack { get; set; }
        public virtual tbSpecialized tbSpecialized { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbStudent> tbStudents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTimeStudy> tbTimeStudies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTimeTable> tbTimeTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbTranscript> tbTranscripts { get; set; }
        public virtual tbUser tbUser { get; set; }
        public virtual tbUser tbUser1 { get; set; }
    }
}