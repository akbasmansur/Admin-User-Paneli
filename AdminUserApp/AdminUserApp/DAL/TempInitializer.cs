using AdminUserApp.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace AdminUserApp.DAL
{
    public class TempInitializer : CreateDatabaseIfNotExists<TempContext>
    {
        protected override void Seed(TempContext context)
        {
            var rolAdmin = new Role { RoleName = "Admin" };
            var rolUser = new Role { RoleName = "User" };

            context.roller.Add(rolAdmin);
            context.roller.Add(rolUser);

            List<User> userlar = new List<User>
            {
                new User { UserName = "Mansur", FullName = "Mansur Akbaş",      Email = "mansurakbas05@gmail.com",  Password = "123456" },
                new User { UserName = "Ekrem",  FullName = "Ekrem Çiçek",       Email = "ekrem@gmail.com",          Password = "12345e" },
                new User { UserName = "Çağrı",  FullName = "Çağrı Çiçek",       Email = "cagri@gmail.com",          Password = "12345ç" },
                new User { UserName = "Cuma",   FullName = "Cuma Çiçek",        Email = "cuma@gmail.com",           Password = "12345c" },
                new User { UserName = "Ahmet",  FullName = "Ahmet Çakallıoğlu", Email = "ahmet@gmail.com",          Password = "12345a" }
            };

            userlar.ForEach(user => context.kullar.Add(user));
            context.SaveChanges();
        }
    }
}