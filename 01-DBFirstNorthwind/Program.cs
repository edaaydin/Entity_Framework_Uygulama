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
1 - Entity'leri yazar�m 
2 - Entity'ler aras�ndaki ili�kileri kurar�m.
3 - Microsoft.EntityFramework; Nuget PAckage Manager'dan bu doysa y�klenir
4- AppDbContext isminde bir s�n�f olu�turup. DbContext s�n�f�ndan miras al�yorum.
5- AppDbContext s�n�f�nda Ovveride OnConfiguring metodunu ovveride ediyoruz ve i�ine 

 optionsBuilder.UseSqlServer
("Server=.;Database=CodeFirst1;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");

6 - UseSqlServer metodunu kullanabilmek i�in NPM'den Microsoft.EntityFrameworkCore.SqlServer indiriyoruz.
7- PMC (Package Manager Console) a�. Default Project benim migration yapmak istedi�im proje ile ayn� olacak 
8- PMC:Nuget / Install - Package Microsoft.EntityFrameworkCore.Tools - Version 8.0.10
9 - CTRL + Shift + B ile solution i�indeki Error'ler varsa d�zeltilecek.
10- PMC: PM > "add-migration ilk" yaz�yoruz;
11 - PM > update - database
NuGet\Install - Package Microsoft.EntityFrameworkCore - Version 8.0.10
NuGet\Install-Package Microsoft.EntityFrameworkCore.SQLServer -Version 8.0.10
NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.10
 */
