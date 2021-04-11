using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQuery
{
    class LINQToDataSet
    {
        static void Main(string[] args)
        {
            DataSet ds = new DataSet();

            DataTable dt = new DataTable();
            DataColumn Id = new DataColumn("Id");
            DataColumn Name = new DataColumn("Name");

            dt.Columns.Add(Id);
            dt.Columns.Add(Name);

            DataRow row1 = dt.NewRow();
            row1["Id"] = 1;
            row1["Name"] = "scott";
            DataRow row2 = dt.NewRow();
            row2["Id"] = 2;
            row2["Name"] = "ben";
            DataRow row3 = dt.NewRow(); ;
            row3["Id"] = 1;
            row3["Name"] = "nick";

            dt.Rows.Add(row1);
            dt.Rows.Add(row2);
            dt.Rows.Add(row3);

            ds.Tables.Add(dt);


            DataTable dtable = ds.Tables[0];
            var table = dtable.AsEnumerable();

            var query = from d in table
                        select d;

            foreach (var item in query)
            {
                DataRow r = (DataRow)item;
                Console.WriteLine("{0, -2}{1}", r["Id"].ToString(), r["Name"].ToString());
            }
            Console.ReadLine();
        }
    }


}
