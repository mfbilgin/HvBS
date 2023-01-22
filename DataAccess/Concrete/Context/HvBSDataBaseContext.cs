﻿using System;
using System.IO;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.Context
{
    public class HvBSDataBaseContext : DbContext
    {
        private readonly string _filePath = @"C:\HvBS\connectionString.txt";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            FileStream fileStream = new FileStream(_filePath, FileMode.Open,FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream);
            string connectionString = streamReader.ReadLine();
            if (connectionString == null)
                throw new NullReferenceException("Veri tabanı bağlantısı bulunamadı.");
            optionsBuilder.UseSqlServer(connectionString);
            streamReader.Close();
            fileStream.Close();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<Record> Records { get; set; }
        public DbSet<PartStatus> PartStatuses { get; set; }
    }
}