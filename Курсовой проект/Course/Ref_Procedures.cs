//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Course
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ref_Procedures
    {
        public int Id { get; set; }
        public int Id_proced { get; set; }
        public int Count_proced { get; set; }
        public int Id_Patient { get; set; }
        public int Id_Therapist { get; set; }
        public System.DateTime Date_proc { get; set; }
    
        public virtual Card_Patients Card_Patients { get; set; }
        public virtual Procedures Procedures { get; set; }
        public virtual Therapists Therapists { get; set; }
    }
}
