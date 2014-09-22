using Domain.Entity;
using Domain.Persistence;
using System;

namespace Domain.Repository
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
            new PacienteRepository().Salvar(new Paciente
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
            new CobrancaRepository().Salvar(new Cobranca
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
            new ConsultaRepository().Salvar(new Consulta
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
            new ConvencioRepository().Salvar(new Convencio
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
            new ConvencioRepository().Salvar(new Convencio
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
            new EnderecoRepository().Salvar(new Endereco
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
            new EspecialidadeRepository().Salvar(new Especialidade
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
            new PessoaRepository().Salvar(new Pessoa
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
            new PessoaFisicaRepository().Salvar(new PessoaFisica
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
            new PessoaJuridicaRepository().Salvar(new PessoaJuridica
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
            new ReservaRepository().Salvar(new Reserva
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
            new SalaRepository().Salvar(new Sala
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
            new TelefoneRepository().Salvar(new Telefone
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
