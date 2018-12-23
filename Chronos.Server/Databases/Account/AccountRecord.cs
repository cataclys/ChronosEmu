﻿using Chronos.ORM;
using Chronos.ORM.SubSonic.SQLGeneration.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronos.Server.Databases.Account
{
    [TableName("accounts")]
    public class AccountRecord : IAutoGeneratedRecord
    {
        [PrimaryKey("Id")]
        public int Id { get; set; }
        [NullString]
        public string Username { get; set; }
        [Index]
        public byte Authority { get; set; }
        public string Password { get; set; }
        public string HDSN { get; set; }
        public string IP_Key { get; set; }
    }
    public class AccountRecordRelator
    {
        public static string FetchQueryWithUsername = "SELECT * FROM accounts WHERE Username = @0";
    }
}
