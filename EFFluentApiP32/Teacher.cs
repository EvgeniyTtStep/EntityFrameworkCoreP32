namespace EFFluentApiP32;

public class Teacher
{
    public int Id { get; set; }
    public string Name { get; set; }
    public HashSet<Subject?> Subjects { get; set; } = new();
    public HashSet<Student?> Students { get; set; } = new();
}