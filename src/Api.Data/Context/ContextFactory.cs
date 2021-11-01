using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
  public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
  {
    public MyContext CreateDbContext(string[] args)
    {
        //Usado para criar migrações
        var connectionString = "Server=localhost;Port=3306;Database=dbAPI;Uid=root;Pwd=123Aa321";
        var optionBuilder = new DbContextOptionsBuilder<MyContext>();
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 26));
        optionBuilder.UseMySql(connectionString, serverVersion);
        return new MyContext(optionBuilder.Options);
    }
  }
}
