using Arquitetura.Domain;
using Arquitetura.Interface;
using Arquitetura.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura.Service
{    
    class AlunoService
    {
        public IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }
        public List<Aluno> Lista()
        {            
            var alunos = _alunoRepository.Lista();

            foreach (var aluno in alunos)
            {
                aluno.Idade = CalcularIdade(aluno.DataNascimento);
            }

            return alunos;
        }
        
        private int CalcularIdade(DateTime dataNacimento)
        {
            int idade = 0;
            idade = DateTime.Now.Year - dataNacimento.Year;
            if (DateTime.Now.DayOfYear < dataNacimento.DayOfYear)
                idade = idade - 1;

            return idade;
        }
    }
}
