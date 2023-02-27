using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer.Entity;
using BusinessLogicLayer.EntityList;
using BusinessLogicLayerEntityBase.Entity;
using DatabaseAccessLayer;


namespace BusinessLogicLayer.EntityManager
{
    
    public class TitleManager
    {
        static DBManager manager = new();


        public static TitleList SelectAllTitles()
        {
            try
            {
                return DataTableToTitleList(manager.ExecuteDataTable("selectTitles"));
            }
            catch
            {
                return new TitleList();
            }
        }

        public static bool UpdateTitleByTitleID(string TitleId, Title obj)
        {
            try
            {
                //currently updating only these attributes
                Dictionary<string, object> ParamDic = new() { 
                    ["@title_id"] = obj.title_id,
                    ["@title"] = obj.title,
                    ["@type"] = obj.type,
                    ["@pub_id"] = obj.pub_id,
                    ["@price"] = obj.price

                };

                return
                manager.ExecuteNonQuery("UpdateTitleByTitleId", ParamDic) > 0;

            }
            catch
            {

            }
            return false;
        }
        public static bool DeleteTitleByTitleID(string TitleId)
        {
            try
            {

                Dictionary<string, object> ParamDic = new() { ["@title_id"] = TitleId};

                return
                manager.ExecuteNonQuery("DeleteTitleByTitleId", ParamDic) > 0;

            }
            catch
            {

            }
            return false;
        }
        public static bool AddNewTitle(Title obj)
        {
            try
            {

                //currently updating only these attributes
                Dictionary<string, object> ParamDic = new()
                {
                    ["@title_id"] = obj.title_id,
                    ["@title"] = obj.title ?? "Nan",
                    ["@type"] = obj.type ?? "Nan",
                    ["@pub_id"] = obj.pub_id,
                    ["@price"] = obj.price,
                    ["@advance"] = obj.advance,
                    ["@royalty"] = obj.royalty,
                    ["@ytd_sales"] = obj.ytd_sales,
                    ["@notes"] = obj.notes??"Nan",
                   

                };

                return
                manager.ExecuteNonQuery("AddNewTitle", ParamDic) > 0;

            }
            catch
            {

            }
            return false;
        }
        internal static TitleList DataTableToTitleList(DataTable Dt)
        {
            TitleList PrdLst = new();
            try
            {
                foreach (DataRow row in Dt.Rows)
                    PrdLst.Add(DataRowToTitle(row));
            }
            catch
            {

            }
            return PrdLst;
        }

        internal static Title DataRowToTitle (DataRow Dr)
        {
            Title Titles = new();
            try
            {

                Titles.title_id = Dr["title_id"]?.ToString() ?? "NA";
                Titles.title = Dr["title"]?.ToString() ?? "NA";
                Titles.type = Dr["type"]?.ToString() ?? "NA";
                Titles.pub_id = Dr["pub_id"]?.ToString() ?? "NA";
                Titles.notes = Dr["notes"]?.ToString() ?? "NA";

                if (float.TryParse(Dr["price"]?.ToString() ?? "-1", out float TempF))
                    Titles.price = TempF;
                if (float.TryParse(Dr["advance"]?.ToString() ?? "-1", out  TempF))
                    Titles.advance = TempF;

                if (int.TryParse(Dr["royalty"]?.ToString() ?? "-1", out int TempInt))
                    Titles.royalty = TempInt;
                if (int.TryParse(Dr["ytd_sales"]?.ToString() ?? "-1", out TempInt))
                    Titles.ytd_sales = TempInt;

               

                if (DateTime.TryParse(Dr["pubdate"]?.ToString() ?? "1000", out DateTime dat))
                    Titles.pubdate = dat;

                Titles .State= EntityState.UnChanged;

            }
            catch
            {

            }
            return Titles;
        }

    }
}
