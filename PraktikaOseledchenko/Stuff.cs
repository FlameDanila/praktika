//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PraktikaOseledchenko
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stuff
    {
        public int id { get; set; }
        public string name { get; set; }
        public string post { get; set; }
        public Nullable<bool> isAdmin { get; set; }
        public string login { get; set; }
        public string password { get; set; }
    
        public virtual TypeOfWorkers TypeOfWorkers { get; set; }
    }
}
