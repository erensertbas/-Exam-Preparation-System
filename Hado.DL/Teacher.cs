//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hado.DL
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Teacher
    {
        [DataMember]
        public int TeacherId { get; set; }
        [DataMember]
        public string Firstname { get; set; }
        [DataMember]
        public string Lastname { get; set; }
        [DataMember]
        public string IdentityNumber { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public Nullable<System.DateTime> Birthday { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public int SchoolId { get; set; }
        [DataMember]
        public int UserId { get; set; }
    }
}
