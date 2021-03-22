using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class FuncionarioDB : IFuncionarioDB
    {
        private static List<Funcionario> lst = new List<Funcionario>();

        public List<Funcionario> GetAll()
        {
            return lst;
        }

        public bool Insert(Funcionario funcionario)
        {
            lst.Add(funcionario);
            return true;
        }

        //Segundo momento:

        public Funcionario SelectById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            string teste = "Fim da instancia de uma classe";
        }
    }
}
