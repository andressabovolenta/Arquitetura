using Arquitetura.Domain;
using System;
using System.Collections.Generic;
using Arquitetura.Interface;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura.Repository
{
    class AlunoRepository : IAlunoRepository
    {
        public List<Aluno> Lista()
        {
            List<Aluno> alunos = new List<Aluno>();

            Aluno aluno = new Aluno();
            aluno.Id = 1;
            aluno.Nome = "Andressa Bovolenta";
            aluno.DataNascimento = new DateTime(1991, 01, 21);
            aluno.Matricula = "7583491";
            alunos.Add(aluno);

            aluno = new Aluno();
            aluno.Id = 2;
            aluno.Nome = "Thiago Gomes";
            aluno.DataNascimento = new DateTime(1985, 06, 23);
            aluno.Matricula = "1234567";
            alunos.Add(aluno);

            aluno = new Aluno();
            aluno.Id = 3;
            aluno.Nome = "Marcia Bovolenta";
            aluno.DataNascimento = new DateTime(1971, 03, 11);
            aluno.Matricula = "9876543";
            alunos.Add(aluno);

            aluno = new Aluno();
            aluno.Id = 4;
            aluno.Nome = "João Luiz Bovolenta";
            aluno.DataNascimento = new DateTime(1958, 09, 28);
            aluno.Matricula = "1029384";
            alunos.Add(aluno);

            return alunos;
        }
    }
}
