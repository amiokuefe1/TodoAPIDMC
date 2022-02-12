
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace TodoAPIDMC.Models // this is model directory associated with our DB
{
    public class TodoContext : DbContext // creating our DB class derived from DbContext (Inheritance)
    {
        public TodoContext(DbContextOptions<TodoContext> options) // creating the provision of accepting options in the constructor of our DB Instance
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!; // instantiating the available model class in our model directory as field in our DB Class
    }
}