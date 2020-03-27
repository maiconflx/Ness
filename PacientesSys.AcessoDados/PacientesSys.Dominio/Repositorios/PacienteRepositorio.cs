using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PacientesSys.AcessoDados;
using PacientesSys.AcessoDados.Interface;

namespace PacientesSys.Dominio.Repositorios
{
    public class PacienteRepositorio : Contexto, IRepositorio<Paciente>
    {
        public Paciente BuscarId(int id)
        {
   
            throw new NotImplementedException();
        }

        public string inserir(Paciente entidade)
        {
            try
            {
                LimparParametro();
                AdicionarParametros("@nome", entidade.Nome);
                AdicionarParametros("@CPF", entidade.CPF);
                AdicionarParametros("@Datas", entidade.Datas);
                AdicionarParametros("@Pescricao", entidade.Pescricao);
                string retorno = ExecutarCommando(System.Data.CommandType.StoredProcedure, "uspClienteIn").ToString();
                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        private void AdicionarParametros(string v)
        {
            throw new NotImplementedException();
        }

        public string Alterar(Paciente entidade)
        {
            return null;
        }
        public string Deletar(Paciente entidade)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Paciente> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public string Salvar(Paciente entidade)
        {
            throw new NotImplementedException();
        }

        string IRepositorio<Paciente>.Salvar(Paciente entidade)
        {
            throw new NotImplementedException();
        }

        string IRepositorio<Paciente>.Deletar(Paciente entidade)
        {
            throw new NotImplementedException();
        }

        Paciente IRepositorio<Paciente>.BuscarId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Paciente> ListarDatas(string datas)
        {
            try
            {
                LimparParametro();
                AdicionarParametros("@Datas", datas);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        IEnumerable<Paciente> IRepositorio<Paciente>.Listardatas(string datas)
        {
            throw new NotImplementedException();
        }
    }
}
