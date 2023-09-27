namespace ManipulandoLINQ;

public class ManipulandoLinq
{
    public static void Main(string[] args)
    {
        var students = new List<Student>
        {
            new Student(1, "Julio", "102030", 100),
            new Student(2, "Julio", "112030", 80),
            new Student(3, "Paulo", "122030", 65),
            new Student(4, "Jose", "132030", 35),
            new Student(5, "Felipe", "142030", 55),
            new Student(6, "Alice", "152030", 50),
            new Student(7, "Bianka", "162030", 97)
        };

        var any = students.Any();
        var any100 = students.Any(s => s.Notas == 100);

        var single = students.Single(s => s.Id == 7);
        var singleDefault = students.SingleOrDefault(s => s.Notas == 54);

        var first = students.First(s => s.Nome == "Julio");

        //Menor para o maior
        var ordenarNota = students.OrderBy(s => s.Notas);
        
        //Maior para o menor
        var ordenarDescrescente = students.OrderByDescending(s => s.Notas);

        var aprovadosPorNota = students.Where(s => s.Notas >= 60);

        var selectNotas = students.OrderByDescending(s => s.Notas).Select(s => new { Student = s, Nota = s.Notas }).ToList();
        var telefone = students.SelectMany(s => s.Telefone);

        var somarNotas = students.Sum(s => s.Notas);

        var notaMinima = students.Min(s => s.Notas);
        var NotaMax = students.Max(s => s.Notas);
    }
}