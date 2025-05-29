using EntityFrameworkCoreP32;

class Program
{
    public static void Main(string[] args)
    {
        CarContext context = new CarContext();
        context.Database.EnsureCreated();//created data base
        
        //CREATE 
        context.Engines.Add(new Engine(){Name = "Gaz 1.6"});
        context.Engines.Add(new Engine(){Name = "Gaz 2.5"});
        context.SaveChanges();
        
        
        context.Toyotas.Add(new Toyota() { Name = "Prius", ReleaseDate = DateTime.Now, Engine = context.Engines.Find(1) });
        context.Toyotas.Add(new Toyota() { Name = "Supraaa", Engine = context.Engines.Find(2) });
        context.Toyotas.Add(new Toyota() { Name = "Selica" });
        context.Toyotas.Add(new Toyota() { Name = "Land Cruiser 200" });
        
        context.SaveChanges();
        
        context.Toyotas.Update(new Toyota() { Name = context.Toyotas.Find(4).Name = "Land Cruiser 777" });
        
       // context.Remove(context.Toyotas);
        
        context.SaveChanges();

        //READ
        foreach (var toyota in context.Toyotas)
        {
            Console.WriteLine( "Id: " + toyota.Id + "\n Name: "+  toyota.Name);
        }

    }    
}