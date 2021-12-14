using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaaSEntities
{
    public class Dataset
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
        public int Files { get; set; }
        public int RowCount { get; set; }
        public int SizeKB { get; set; }
        public List<DatasetMetadata> columns { get; set; }
    }
}
