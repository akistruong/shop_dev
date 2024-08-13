﻿namespace AccountShop.EF.Options
{
    public class DbOptions
    {
        public const string ConnectionStrings = "ConnectionStrings";
        public string MySQL { get; set; } = String.Empty;
        public string SQLServer { get; set; } = String.Empty;
    }
}