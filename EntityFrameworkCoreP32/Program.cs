using EntityFrameworkCoreP32;

class Program
{
    public static void Main(string[] args)
    {
        CarContext context = new CarContext();
        context.Database.EnsureCreated();//created data base
        
        //CREATE 
        context.Toyotas.Add(new Toyota() { Name = "Prius" });
        context.Toyotas.Add(new Toyota() { Name = "Supraaa" });
        context.Toyotas.Add(new Toyota() { Name = "Selica" });
        context.Toyotas.Add(new Toyota() { Name = "Land Cruiser 200" });
        
        context.SaveChanges();

        //READ
        foreach (var toyota in context.Toyotas)
        {
            Console.WriteLine( "Id: " + toyota.Id + "\n Name: "+  toyota.Name);
        }

    }    
}