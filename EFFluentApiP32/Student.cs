using EntityFrameworkCoreP32;

namespace EFFluentApiP32;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public HashSet<Teacher?> Teachers { get; set; }
}