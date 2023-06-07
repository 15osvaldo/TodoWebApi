using Microsoft.EntityFrameworkCore;
namespace TodoApi
{
    public class TodoDb : DbContext
    {
        // Se define el contrexto de la base de datos 
        // siendo la clase principal que cordina la funcionalidad de 
        // Entity Framework para los modelos de datos
        public TodoDb(DbContextOptions options) 
            : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}
