namespace _01_DBFirstNorthwind
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
/*
1 - Entity'leri yazarým 
2 - Entity'ler arasýndaki iliþkileri kurarým.
3 - Microsoft.EntityFramework; Nuget PAckage Manager'dan bu doysa yüklenir
4- AppDbContext isminde bir sýnýf oluþturup. DbContext sýnýfýndan miras alýyorum.
5- AppDbContext sýnýfýnda Ovveride OnConfiguring metodunu ovveride ediyoruz ve içine 

 optionsBuilder.UseSqlServer
("Server=.;Database=CodeFirst1;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");

6 - UseSqlServer metodunu kullanabilmek için NPM'den Microsoft.EntityFrameworkCore.SqlServer indiriyoruz.
7- PMC (Package Manager Console) aç. Default Project benim migration yapmak istediðim proje ile ayný olacak 
8- PMC:Nuget / Install - Package Microsoft.EntityFrameworkCore.Tools - Version 8.0.10
9 - CTRL + Shift + B ile solution içindeki Error'ler varsa düzeltilecek.
10- PMC: PM > "add-migration ilk" yazýyoruz;
11 - PM > update - database
NuGet\Install - Package Microsoft.EntityFrameworkCore - Version 8.0.10
NuGet\Install-Package Microsoft.EntityFrameworkCore.SQLServer -Version 8.0.10
NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.10
 */
