﻿using SQLite;
namespace Finsculpt.Models
{
    [Table("Funds")]
    public class Fund
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public decimal Amount { get; set; }
    }
}
