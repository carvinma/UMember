//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace UMember
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbJmail
    {
        public int Mail_ID { get; set; }
        public string Mail_Content { get; set; }
        public string Receiver_MailAddress { get; set; }
        public System.DateTime Send_Time { get; set; }
        public int Mail_Type { get; set; }
        public string Description { get; set; }
        public bool Is_Failed { get; set; }
    }
}
