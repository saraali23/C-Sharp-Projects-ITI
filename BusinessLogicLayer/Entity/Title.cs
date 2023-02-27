using BusinessLogicLayerEntityBase.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Entity
{
    public class Title:EntityBase
    {
        public string title_id { get; set; }
        string title_name;
        public string title
        {
            get => title_name;
            set
            {
                if (value != title_name)
                {
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Changed;
                    title_name = value;
                }
            }
        }
        string title_type;
        public string type
        {
            get => title_type;
            set
            {
                if (value != title_type)
                {
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Changed;
                    title_type = value;
                }
            }
        }
        string title_pub_id;
        public string pub_id
        {
            get => title_pub_id;
            set
            {
                if (value != title_pub_id)
                {
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Changed;
                    title_pub_id = value;
                }
            }
        }
        float title_price;
        public float price
        {
            get => title_price;
            set
            {
                if (value != title_price)
                {
                    if (this.State != EntityState.Added)
                        this.State = EntityState.Changed;
                    title_price = value;
                }
            }
        }

        public float advance { get; set; }        
        public int royalty { get; set; }
        public int ytd_sales { get; set; }
        public string notes { get; set; }
        public DateTime pubdate { get; set; }


        public Title() {
            this.State= EntityState.Added;
        }
    }
}
