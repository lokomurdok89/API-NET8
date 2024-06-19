

    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Users.Any()) return;

            var users = new List<User>
            {
                new User
                {
                    Nombre = "Nombre 1",
                    FechaNacimiento = DateTime.UtcNow.AddMonths(-2),
                    Correo="Correo@correo.cl",
                    Rut="111111-1"
                },
                new User
                {
                    Nombre = "Nombre 2",
                    FechaNacimiento = DateTime.UtcNow.AddMonths(-7),
                    Correo="Correo@correo.cl",
                    Rut="1121233-1"
                },
                new User
                {
                    Nombre = "Nombre 3",
                    FechaNacimiento = DateTime.UtcNow.AddMonths(-100),
                    Correo="Correo@correo.cl",
                    Rut="3333333-1"
                },
                new User
                {
                    Nombre = "Nombre 4",
                    FechaNacimiento = DateTime.UtcNow.AddMonths(-1000),
                    Correo="Correo@correo.cl",
                    Rut="4444444-1"
                },
                new User
                {
                    Nombre = "Nombre 5",
                    FechaNacimiento = DateTime.UtcNow.AddMonths(-200),
                    Correo="Correo@correo.cl",
                    Rut="1155111-1"
                }

            };

            await context.Users.AddRangeAsync(users);
            await context.SaveChangesAsync();
        }

    }
