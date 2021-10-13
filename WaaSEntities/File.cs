using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaaSEntities
{
    public class File
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public int Size { get; set; }
        public string StorageAccountName { get; set; }
        public string Container { get; set; }
        public string Path { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
