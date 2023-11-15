
using DormitoryService.Models;

namespace DormitoryService.Data
{
    public static class DbPrepare
    {
        public static void PrepareData(IApplicationBuilder applicationBuilder)
        {
            using (var services = applicationBuilder.ApplicationServices.CreateScope())
            {
                SeedData(services.ServiceProvider.GetService<AppDbContext>());
            }
        }

        private static void SeedData(AppDbContext? appDbContext)
        {
            if (appDbContext is null) throw new NotImplementedException(nameof(appDbContext));

            else if (!appDbContext.Dormitories.Any())
            {
                appDbContext.Dormitories.AddRange(
                    new Dormitory() {Name = "First", Address = "Zhodino, ul.Derevianko, d.4"},
                    new Dormitory() {Name = "Second", Address = "Minsk, ul.Bagushevicha, d.23"},
                    new Dormitory() {Name = "Thisrd", Address = "Brest, ul.Warshawskaja, d.14"}
                );
            }
            
            appDbContext.SaveChanges();
        }
    }
}