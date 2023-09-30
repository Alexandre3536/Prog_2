using Microsoft.EntityFrameworkCore;
using PSIUWeb.Models;

namespace PSIUWeb.Data
{
    public static class SeedData
    {
        public static void EnsurePopuled(IApplicationBuilder app)
        {
            AppDbContext context =
                app.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<AppDbContext>();
            if (context.Database.GetAppliedMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Pacients.Any())
            {
                context.Pacients.AddRange(

                    new Pacient
                    {
                        Name = "Alexandre",
                        BirthDate = new DateTime(1991, 9, 8),
                        Race = Race.Branco,
                        Height = 170,
                        Weight = 67

                    },
                     new Pacient
                     {
                         Name = "Maria",
                         BirthDate = new DateTime(1990, 9, 18),
                         Race = Race.Pardo,
                         Height = 165,
                         Weight = 58

                     }


                    );

                if (!context.Psicos.Any())
                {
                    context.Psicos.AddRange(

                        new Psico
                        {
                            Name = "Alexandre",
                            CRP = "5269968"
                        }
                    );

                    context.SaveChanges();
                }
            }

        }
    }
}
