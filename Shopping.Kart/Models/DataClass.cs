using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Kart.Models
{
    public class DataClass  
    {
        [Table("tbl_UserDetail")]
        public class tbl_UserDetail
        {
            [Key]
            public int Id { get; set; }
            public string UserName { get; set; }
            public string email { get; set; }
            public string Password { get; set; }
            //public string rePassword { get; set; }
            //public bool Active { get; set; }
        }
    }
}
