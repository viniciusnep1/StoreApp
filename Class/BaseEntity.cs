using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool Ativo { get; set; }
    }
}