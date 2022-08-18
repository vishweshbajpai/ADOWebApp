using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace ADOWebApplication.DataRepo
{
    public static class ExtnWorks
    {
        public static List<T> GenListFromDataTable<T>(this T data, DataTable dt) where T : new()
        {
            List<T> MizzaDataList = new List<T>();

            foreach (DataRow dr in dt.Rows)
            {
                var rec = CreateItemFromRow<T>(dr);
                MizzaDataList.Add(rec);
            }

            return MizzaDataList;
        }
        // function that set the given object from the given data row
        public static T CreateItemFromRow<T>(DataRow row) where T : new()
        {

            T item = new T();

            SetItemFromRow(item, row);

            return item;
        }

        public static void SetItemFromRow<T>(T item, DataRow row) where T : new()
        {
            //foreach (var prop in item.GetType().GetProperties())
            //{
            //    if (prop != null && prop.GetValue(item, null) != DBNull.Value)
            //    {
            //        prop.SetValue(item, prop.GetValue(item, null), null);
            //    }
            //}
            foreach (DataColumn c in row.Table.Columns)
            {
                PropertyInfo p = item.GetType().GetProperty(c.ColumnName);

                if (p != null && row[c] != DBNull.Value)
                {
                    p.SetValue(item, row[c], null);
                }
            }
        }
        #region For Insert
        public static MySqlCommand AttachParameters<T>(this T obj, MySqlCommand com)
        {
            foreach (var prop in obj.GetType().GetProperties())
            {
                com.Parameters.AddWithValue($"@{prop.Name}", prop.GetValue(obj, null));
            }
            return com;
        }
        #endregion
    }
}
