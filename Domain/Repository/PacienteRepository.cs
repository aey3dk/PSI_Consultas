using Domain.Entity;
using Domain.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Domain.Repository
{
    public class PacienteRepository
    {
        private Conexao Conexao;
        public PacienteRepository()
        {
            try
            {
                Conexao = new Conexao();
                Conexao.Database.CreateIfNotExists();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao se conectar com a base de dados: " + e.Message + e.InnerException ?? " - " + e.InnerException.Message);
            }
        }

        public void Salvar(Paciente p)
        {
            try
            {
                Conexao.Paciente.Add(p);
                Conexao.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao salvar paciente: " + e.Message + e.InnerException ?? " - " + e.InnerException.Message);
            }
        }

        public void Editar(Paciente p)
        {
            try
            {
                Conexao.Entry(p).State = EntityState.Modified;
                Conexao.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao atualizar paciente: " + e.Message + e.InnerException ?? " - " + e.InnerException.Message);
            }
        }

        public void Remover(Paciente p)
        {
            try
            {
                if (Conexao.Entry(p).State == EntityState.Detached)
                    Conexao.Paciente.Attach(p);
                Conexao.Paciente.Remove(p);
                Conexao.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao remover paciente: " + e.Message + e.InnerException ?? " - " + e.InnerException.Message);
            }
        }

        public List<Paciente> ListarTodos()
        {
            try
            {
                return Conexao.Paciente.ToList();
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao listar todos os pacientes: " + e.Message + e.InnerException ?? " - " + e.InnerException.Message);
            }
        }

        public Paciente ObterPeloCodigo(Int64 codigo)
        {
            try
            {
                return Conexao.Paciente.Find(codigo);
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao obter paciente: " + e.Message + e.InnerException ?? " - " + e.InnerException.Message);
            }
        }

        private void Dispose()
        {
            Conexao.Dispose();
        }
    }
}
