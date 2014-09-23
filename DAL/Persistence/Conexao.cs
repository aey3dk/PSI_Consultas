﻿using Domain.Entity;
using System.Configuration;
using System.Data.Entity;

namespace DAL.Persistence
{
    public class Conexao : DbContext
    {
        public Conexao() : base(ConfigurationManager.ConnectionStrings["Local"].ConnectionString) { }

        public DbSet<Cobranca>       Cobranca       { get; set; }
        public DbSet<Convenio>       Convenio       { get; set; }
        public DbSet<Documento>      Documento      { get; set; }
        public DbSet<Endereco>       Endereco       { get; set; }
        public DbSet<Especialidade>  Especialidade  { get; set; }
        public DbSet<Paciente>       Paciente       { get; set; }
        public DbSet<Pessoa>         Pessoa         { get; set; }
        public DbSet<PessoaFisica>   PessoaFisica   { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }
        public DbSet<Reserva>        Reserva        { get; set; }
        public DbSet<Sala>           Sala           { get; set; }
        public DbSet<Telefone>       Telefone       { get; set; }
    }
}












