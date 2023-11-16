
using RequestService.Models;

namespace RequestService.Data
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

            else if (!appDbContext.Requests.Any())
            {
                appDbContext.Requests.AddRange(
                    new UserRequest() { Description = "Bla bla bla", Number = "123", IsActive = true }
                );
            }
            
            appDbContext.SaveChanges();
        }
    }
}