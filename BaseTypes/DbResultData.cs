using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BaseTypes
{
    public class DbResultData<T> : DbResultBase
    {
        public DbResultData() : base()
        { }
        public DbResultData(DbResultBase baseObj, T data = default) : base(baseObj)
        {
            Data = data;
        }
        public DbResultData(SqlTransaction dbTran) : base(dbTran)
        { }
        public DbResultData(Exception exp, SqlTransaction dbTran) : base(exp, dbTran)
        { }
        private T _data;
        public T Data { get => _data; set { _data = value; } }
    }
}
