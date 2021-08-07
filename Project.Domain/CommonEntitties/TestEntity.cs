using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.CommonEntitties
{
    public class TestEntity:BaseEntity
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public DateTime Issuse { get; set; }
    }
}
