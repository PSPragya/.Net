//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.DateTime Duration { get; set; }
        public bool Active { get; set; }
        public int Description { get; set; }
    
        public virtual Vehicle Vehicle { get; set; }
    }
}
