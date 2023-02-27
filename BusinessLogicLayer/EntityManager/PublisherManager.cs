using BusinessLogicLayer.Entity;
using BusinessLogicLayer.EntityList;
using BusinessLogicLayerEntityBase.Entity;
using DatabaseAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.EntityManager
{
    public class PublisherManager
    {
        static DBManager manager = new();


        public static PublisherList SelectAllPublishers()
        {
            try
            {
                return DataTableToPublisherList(manager.ExecuteDataTable("selectPublishers"));
            }
            catch
            {
                return new PublisherList();
            }
        }

        

        internal static PublisherList DataTableToPublisherList(DataTable Dt)
        {
            PublisherList PrdLst = new();
            try
            {
                foreach (DataRow row in Dt.Rows)
                    PrdLst.Add(DataRowToPublisher(row));
            }
            catch
            {

            }
            return PrdLst;
        }

        internal static Publisher DataRowToPublisher(DataRow Dr)
        {
            Publisher publisher = new();
            try
            {

                publisher.pub_id = Dr["pub_id"]?.ToString() ?? "NA";
                publisher.pub_name = Dr["pub_name"]?.ToString() ?? "NA";
                publisher.city = Dr["city"]?.ToString() ?? "NA";
                publisher.state = Dr["state"]?.ToString() ?? "NA";
                publisher.country = Dr["nocountrytes"]?.ToString() ?? "NA";
                publisher.State = EntityState.UnChanged;

            }
            catch
            {

            }
            return publisher;
        }

    }
}
