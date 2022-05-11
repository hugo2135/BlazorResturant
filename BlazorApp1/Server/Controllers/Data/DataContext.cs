namespace BlazorApp1.Server.Controllers.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resturant>().HasData(
                new Resturant
                {
                    Id = 1,
                    Name = "PP1",
                    Style = "Soso",
                    Price = 69,
                    Address = "Just near hear",
                    Rating = 3.5
                },
                new Resturant
                {
                    Id = 2,
                    Name = "PP0",
                    Style = "Delicious",
                    Price = 1600,
                    Address = "Maybe near hear",
                    Rating = 4.5,
                    ImageURL = "https://i.pinimg.com/564x/10/c9/c0/10c9c02224ae9c08ba781bae2a856675.jpg"
                },
                new Resturant
                {
                    Id = 3,
                    Name = "PP2",
                    Style = "Yup",
                    Price = 200,
                    Address = "Too far",
                    Rating = 2.2
                }
            );
        }
        public DbSet<Resturant> Resturants { get; set; }
    }
}
