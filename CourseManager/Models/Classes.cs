//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Classes
    {
        public int Id { get; set; }
    
        [Required(ErrorMessage="请输入班级名称")]
        [StringLength(20,MinimumLength=2,ErrorMessage="班级名称至少包含两个字符")]
        public string Name { get; set; }
     
        public Nullable<int> TeacherId { get; set; }
        
    }
}
