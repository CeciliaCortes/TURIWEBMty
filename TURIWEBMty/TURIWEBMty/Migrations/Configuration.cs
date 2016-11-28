namespace TURIWEBMty.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TURIWEBMty.Content.TuriContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TURIWEBMty.Content.TuriContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.login.AddOrUpdate(p => p.Nombre,
        new Models.logio

        {
            Nombre = "Debra Garcia",
            Correo = "debra@example.com",
            Contraseña = "123456789"
        },
         new Models.logio
         {
             Nombre = "Thorsten Weinrich",
             Contraseña = "Redmond",
             Correo = "thorsten@example.com"
         },
         new Models.logio
         {
             Nombre = "Yuhong Li",
             Contraseña = "WA",
             Correo = "yuhong@example.com"
         }
         );
        }
    }
}
