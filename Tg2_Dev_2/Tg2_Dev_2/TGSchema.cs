using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tg2_Dev_2
{
    public class TGSchema
    {
        public List<Field> Fields { get; set; }
        
    }

    public class Field
    {
        public string FieldName { get; set; }
        public string FieldType { get; set; }
        public string FieldValue { get; set; }
    } 

    
}
