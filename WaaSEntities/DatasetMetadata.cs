using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaaSEntities
{
    public class DatasetMetadata
    {
        public string Id { get; set; }
        public string DatasetId { get; set; }
        public string SourceColumn { get; set; }
        public string ColumnName { get; set; }
        public string ColumnDataType { get; set; }
        public string ColumnModelType { get; set; }
        public string MetricAggFunction { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    }
}
