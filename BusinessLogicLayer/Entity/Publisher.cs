using BusinessLogicLayerEntityBase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Entity
{
    public class Publisher:EntityBase
    {
        public string pub_id { get; set; }
        public string pub_name { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
    }
}
