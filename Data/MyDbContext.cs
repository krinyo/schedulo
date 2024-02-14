using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using schedulo.Models;

namespace schedulo.Data
{
    public class MyDbContext : DbContext
    {
        private readonly IConfiguration Configuration;
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<Status> Statuses { get; set; }

        public MyDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
        public void Initialize()
        {
            try
            {
                if (Database.EnsureCreated())
                {
                    Console.WriteLine("Db already created!");
                }
                else
                {
                    Console.WriteLine("Db not created!");
                }

                // ��������, ���� �� ��� ������� � ���� ������
                if (!Statuses.Any())
                {
                    // ���� ���, �� ��������� ��������� �������
                    Statuses.Add(new Status { StatusName = "�����", Order = 0});
                    Statuses.Add(new Status { StatusName = "�����������", Order = 1});

                    // ��������� ���������
                    SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while creating the database: {ex}");
            }
        }
    }
}