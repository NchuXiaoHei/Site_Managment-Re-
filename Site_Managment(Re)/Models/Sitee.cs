using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Site_Managment_Re_.Models
{
    public class Sitee
    {
        //教室名称，主键
        [Key]
        public virtual string Site_name { get; set; }
        //教师状态，0：可借，1:不可借
        public virtual string Site_status { get; set; }
        //备注
        public virtual string Note { get; set; }
    }
}