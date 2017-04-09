using System;
using System.Collections.Generic;
using System.Text;

namespace blogCore.Model
{
    public class BaseModel
    {
        public int ID { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public bool isDeleted { get; set; }
        public byte[] Rowversion { get; set; }
    }
}
