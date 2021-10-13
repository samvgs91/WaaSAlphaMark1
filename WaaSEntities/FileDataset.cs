using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaaSEntities
{
    public class FileDataset:File
    {
        public string DatasetId { get; set; }
        public string Status { get; set; }
    }
}
