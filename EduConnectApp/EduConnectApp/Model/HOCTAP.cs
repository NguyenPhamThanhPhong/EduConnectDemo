//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EduConnectApp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOCTAP
    {
        public int MAHT { get; set; }
        public Nullable<int> MAHS { get; set; }
        public Nullable<int> MALOP { get; set; }
        public Nullable<bool> DELETED { get; set; }
    
        public virtual HOCSINH HOCSINH { get; set; }
        public virtual LOP LOP { get; set; }
    }
}
