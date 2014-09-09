using Domain.Entity;
using Domain.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Repository
{
    public class PacienteRepository
    {
        public void Salvar(Paciente p)
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    con.Paciente.Add(p);
                    con.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao salvar paciente" + e.Message + " - " + e.InnerException ?? e.InnerException.Message);
            }
        }
        public void Remover(Paciente p)
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    con.Paciente.Remove(p);
                    con.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao remover paciente" + e.Message + " - " + e.InnerException ?? e.InnerException.Message);
            }
        }

        public List<Paciente> ListarTodos()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    return con.Paciente.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao listar todos os pacientes" + e.Message);
            }
        }
    }
}
