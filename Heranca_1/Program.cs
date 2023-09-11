using Heranca_1.Classes;
using Heranca_1.ClassesAnimais;

public class Program
{
    static void Main(string[] args)
    {
        Aluno aluno = new Aluno();
        aluno.CPF = "000";
        aluno.Nome = "Pedro";

        Funcionario funcionario = new Funcionario();
        funcionario.CPF = "000";
        funcionario.Nome = "Elias";

        Cachorro cachorro = new Cachorro();
        cachorro.Raca = "Labrador";

        Gato gato = new Gato();
        gato.Raca = "SRD";
        gato.Barulho();


    }
}      