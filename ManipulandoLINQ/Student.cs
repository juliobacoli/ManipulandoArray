using System.Diagnostics.CodeAnalysis;

namespace ManipulandoLINQ;

public class Student
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Matricula { get; set; }
    public int Notas { get; set; }

    public Student(int id, string nome, string matricula, int notas)
    {
        Id = id;
        Nome = nome;
        Matricula = matricula;
        Notas = notas;
    }
}