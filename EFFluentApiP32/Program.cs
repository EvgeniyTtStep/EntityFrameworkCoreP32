using EFFluentApiP32;

class Program
{
    public static void Main(string[] args)
    {
        SchoolContext context = new SchoolContext();
        context.Database.EnsureCreated();

        context.Teachers.Add(new Teacher(){Name = "Jack"});
        
        context.SaveChanges();
        
        
    }
}