//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp10.db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Расписание
    {
        public System.DateTime Дата { get; set; }
        public int Класс { get; set; }
        public int Предмет { get; set; }
        public int Номер_урока { get; set; }
        public int Журнал { get; set; }
    
        public virtual Предметы Предметы { get; set; }
    }
}
