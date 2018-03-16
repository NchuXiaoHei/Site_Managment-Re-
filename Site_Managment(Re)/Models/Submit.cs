using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Site_Managment_Re_.Models
{
    public class Submit
    {
        //申请人证件号
        [Key,Column(Order = 0)]
        public virtual string Per_ID { get; set; }
        //申请人姓名
        public virtual string Per_name { get; set; }
        //申请人联系电话
        public virtual string Telephone { get; set; }
        //申请教室
        [Key, Column(Order = 1)]
        public virtual Sitee Site { get; set; }
        //申请日期
        [Key, Column(Order = 2)]
        public virtual string Datee { get; set; }
        //开始时间
        [Key, Column(Order = 3)]
        public virtual string S_time { get; set; }
        //结束时间
        public virtual string E_time { get; set; }
        //注明用途
        public virtual string Note { get; set; }
        
    }
}