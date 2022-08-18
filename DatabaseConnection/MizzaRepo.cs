using ADOWebApplication.DataRepo;
using System;
using System.Collections.Generic;
using System.Data;

namespace ADOWebApplication.ADORepositories
{
    public class MizzaRepo<T> where T : new()
    {
        T _modelObj;
        public MizzaRepo()
        {
            _modelObj = new T();
        }

        public List<T> GetRecords(string procedureName, string dbName, int id = -1)
        {
            try
            {
                DbConnectMySql dbConnect = new DbConnectMySql(dbName);

                DataTable dt = dbConnect.DataRetrieve(procedureName, id);
                
                return _modelObj.GenListFromDataTable(dt);

                #region non-generic logic of GenListFromDataTable
                //Bind EmpModel generic list using dataRow
                //foreach (DataRow dr in dt.Rows)
                //{
                //    MizzaSizeList.Add(
                //                    new MizzaSize
                //                    {
                //                        MizzaSizeID = Convert.ToString(dr["MizzaSizeID"]),
                //                        MizzaSizeName = Convert.ToString(dr["MizzaSizeName"]),
                //                    }
                //                );
                //}

                //return MizzaSizeList;
                #endregion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public bool InsertRecords(T inputModelObj, string procedureName, string dbName)
        {
            try
            {
                DbConnectMySql dbConnect = new DbConnectMySql(dbName);
                
                return dbConnect.DataInsert(inputModelObj, procedureName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public bool UpdateRecords(T inputModelObj, string procedureName, string dbName, int id)
        {
            try
            {
                DbConnectMySql dbConnect = new DbConnectMySql(dbName);

                return dbConnect.DataUpdate(inputModelObj, procedureName, id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public bool RemoveRecords(string procedureName, string dbName, int id)
        {
            try
            {
                DbConnectMySql dbConnect = new DbConnectMySql(dbName);

                return dbConnect.DataRemove(procedureName, id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}