using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using PTMKTestTask.DAL.Context;

namespace PTMKTestTask.Data
{
    public static class DbInitializer
    {
        public static async Task InitializeAsync(PTMKTestTaskDB db)
        {
            await db.Database.EnsureDeletedAsync();
            if (!(db.Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists())
            {
                await db.Database.MigrateAsync();
            }

        }
    }
}
