using System;
using Arquitetura.Repository;
using Arquitetura.Service;

namespace Arquitetura
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunoService alunoService = new AlunoService(new AlunoRepository());

            var alunos = alunoService.Lista();

            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Aluno: {aluno.Nome} ::: Matrícula: {aluno.Matricula} ::: Idade: {aluno.Idade}");
            }

            SalaService salaService = new SalaService();
            MateriaService materiaService = new MateriaService();
        }
    }
}
