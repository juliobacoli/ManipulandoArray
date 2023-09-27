namespace ManipulandoLINQ;

public class ManipulandoLinq
{
    public static void Main(string[] args)
    {
        var students = new List<Student>
        {
            new Student(1, "Julio", "102030", 100),
            new Student(2, "Joao", "112030", 200),
            new Student(3, "Paulo", "122030", 300),
            new Student(4, "Jose", "132030", 400),
            new Student(5, "Felipe", "142030", 500),
            new Student(6, "Alice", "152030", 600),
            new Student(7, "Bianka", "162030", 700)
        };
    }
}