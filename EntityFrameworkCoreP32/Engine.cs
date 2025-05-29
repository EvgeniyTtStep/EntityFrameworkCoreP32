namespace EntityFrameworkCoreP32;

public class Engine
{
    public int Id { get; set; }
    public string Name { get; set; }
    List<Toyota> Toyotas { get; set; }
}