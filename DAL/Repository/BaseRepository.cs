using DAL.Persistence;
using Domain.Entity;
using System;

namespace DAL.Repository
{
    public class BaseRepository
    {
        public void RecriarBaseDados()
        {
            try
            {
                using (Conexao con = new Conexao())
                {
                    if (con.Database.Exists())
                    {
                        con.Database.Delete();
                        con.Database.Create();
                        con.Dispose();
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + e.InnerException ?? " - " + e.InnerException.Message);
            }
        }

        public void PopularBaseDados()
        {
            try
            {
                for (Int32 i = 1; i <= 9; i++)
                {
                    PopularPaciente(i);
                    PopularCobranca(i);
                    PopularConsulta(i);
                    PopularConvencio(i);
                    PopularDocumento(i);
                    PopularEndereco(i);
                    PopularEspecialidade(i);
                    PopularPessoa(i);
                    PopularPessoaFisica(i);
                    PopularPessoaJuridica(i);
                    PopularReserva(i);
                    PopularSala(i);
                    PopularTelefone(i);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + e.InnerException ?? " - " + e.InnerException.Message);
            }
        }

        private void PopularPaciente(Int32 i)
        {
            var ind = i.ToString();
            new PacienteRepository().Inserir(new Paciente
            {
                Codigo = i + 10,
                Nome = "Paciente " + i + " gerado automaticamente.",
                DataNascimento = Convert.ToDateTime(ind + "/01/2014"),
                CPF = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                Email = "paciente" + i + "@gmail.com"
            });
        }

        private void PopularCobranca(Int32 i)
        {
            var ind = i.ToString();
            new CobrancaRepository().Inserir(new Cobranca
            {
                Codigo = i + 10,
                Nome = "Paciente " + i + " gerado automaticamente.",
                DataNascimento = Convert.ToDateTime(ind + "/01/2014"),
                CPF = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                Email = "paciente" + i + "@gmail.com"
            });
        }

        private void PopularConsulta(Int32 i)
        {
            var ind = i.ToString();
            new ConsultaRepository().Inserir(new Consulta
            {
                Codigo = i + 10,
                Nome = "Paciente " + i + " gerado automaticamente.",
                DataNascimento = Convert.ToDateTime(ind + "/01/2014"),
                CPF = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                Email = "paciente" + i + "@gmail.com"
            });
        }

        private void PopularConvencio(Int32 i)
        {
            var ind = i.ToString();
            new ConvenioRepository().Inserir(new Convenio
            {
                Codigo = i + 10,
                Nome = "Paciente " + i + " gerado automaticamente.",
                DataNascimento = Convert.ToDateTime(ind + "/01/2014"),
                CPF = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                Email = "paciente" + i + "@gmail.com"
            });
        }

        private void PopularDocumento(Int32 i)
        {
            var ind = i.ToString();
            new DocumentoRepository().Inserir(new Documento
            {
                Codigo = i + 10,
                Nome = "Paciente " + i + " gerado automaticamente.",
                DataNascimento = Convert.ToDateTime(ind + "/01/2014"),
                CPF = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                Email = "paciente" + i + "@gmail.com"
            });
        }

        private void PopularEndereco(Int32 i)
        {
            var ind = i.ToString();
            new EnderecoRepository().Inserir(new Endereco
            {
                Codigo = i + 10,
                Nome = "Paciente " + i + " gerado automaticamente.",
                DataNascimento = Convert.ToDateTime(ind + "/01/2014"),
                CPF = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                Email = "paciente" + i + "@gmail.com"
            });
        }

        private void PopularEspecialidade(Int32 i)
        {
            var ind = i.ToString();
            new EspecialidadeRepository().Inserir(new Especialidade
            {
                Codigo = i + 10,
                Nome = "Paciente " + i + " gerado automaticamente.",
                DataNascimento = Convert.ToDateTime(ind + "/01/2014"),
                CPF = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                Email = "paciente" + i + "@gmail.com"
            });
        }

        private void PopularPessoa(Int32 i)
        {
            var ind = i.ToString();
            new PessoaRepository().Inserir(new Pessoa
            {
                Codigo = i + 10,
                Nome = "Paciente " + i + " gerado automaticamente.",
                DataNascimento = Convert.ToDateTime(ind + "/01/2014"),
                CPF = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                Email = "paciente" + i + "@gmail.com"
            });
        }

        private void PopularPessoaFisica(Int32 i)
        {
            var ind = i.ToString();
            new PessoaFisicaRepository().Inserir(new PessoaFisica
            {
                Codigo = i + 10,
                Nome = "Paciente " + i + " gerado automaticamente.",
                DataNascimento = Convert.ToDateTime(ind + "/01/2014"),
                CPF = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                Email = "paciente" + i + "@gmail.com"
            });
        }

        private void PopularPessoaJuridica(Int32 i)
        {
            var ind = i.ToString();
            new PessoaJuridicaRepository().Inserir(new PessoaJuridica
            {
                Codigo = i + 10,
                Nome = "Paciente " + i + " gerado automaticamente.",
                DataNascimento = Convert.ToDateTime(ind + "/01/2014"),
                CPF = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                Email = "paciente" + i + "@gmail.com"
            });
        }

        private void PopularReserva(Int32 i)
        {
            var ind = i.ToString();
            new ReservaRepository().Inserir(new Reserva
            {
                Codigo = i + 10,
                Nome = "Paciente " + i + " gerado automaticamente.",
                DataNascimento = Convert.ToDateTime(ind + "/01/2014"),
                CPF = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                Email = "paciente" + i + "@gmail.com"
            });
        }

        private void PopularSala(Int32 i)
        {
            var ind = i.ToString();
            new SalaRepository().Inserir(new Sala
            {
                Codigo = i + 10,
                Nome = "Paciente " + i + " gerado automaticamente.",
                DataNascimento = Convert.ToDateTime(ind + "/01/2014"),
                CPF = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                Email = "paciente" + i + "@gmail.com"
            });
        }

        private void PopularTelefone(Int32 i)
        {
            var ind = i.ToString();
            new TelefoneRepository().Inserir(new Telefone
            {
                Codigo = i + 10,
                Nome = "Paciente " + i + " gerado automaticamente.",
                DataNascimento = Convert.ToDateTime(ind + "/01/2014"),
                CPF = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                Email = "paciente" + i + "@gmail.com"
            });
        }
    }
}
