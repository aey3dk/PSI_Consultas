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
                Valor = (Decimal)(i + i * 10 + i * 100 + i * 0.1 + i * 0.01),
                StatusCobranca = (StatusCobrancaEnum)i
            });
        }

        private void PopularConsulta(Int32 i)
        {
            var ind = i.ToString();
            new ConsultaRepository().Inserir(new Consulta
            {
                DataHora = Convert.ToDateTime(ind + "/01/2014"),
                Observacao = "Observação " + i + " gerado automaticamente.",
                StatusConsulta = (StatusConsultaEnum)i
            });
        }

        private void PopularConvencio(Int32 i)
        {
            var ind = i.ToString();
            new ConvenioRepository().Inserir(new Convenio
            {
                Nome = "Convenio " + i + " gerado automaticamente.",
                NumeroCartao = Convert.ToInt64(String.Concat(ind, ind, ind, ind, ind, ind, ind, ind, ind, ind, ind, ind, ind, ind, ind, ind)),
                Tipoplano = (TipoPlanoSaudeEnum)i
            });
        }
        
        private void PopularDocumento(Int32 i)
        {
            var ind = i.ToString();
            new DocumentoRepository().Inserir(new Documento
            {
                Codigo = i + 10,
                Descricao = "Documento " + i + " gerado automaticamente.",
            });
        }

        private void PopularEndereco(Int32 i)
        {
            var ind = i.ToString();
            new EnderecoRepository().Inserir(new Endereco
            {
                Cep = Convert.ToInt64(String.Concat(ind, ind, ind, ind, ind, ind, ind, ind)),
                Logradoro = "Logradoro " + i + " gerado automaticamente.",
                Numero = Convert.ToInt64(String.Concat(ind, ind, ind, ind, ind)),
                Complemento = "Complemento " + i + " gerado automaticamente.",
                Bairro = "Bairro " + i + " gerado automaticamente.",
                Cidade = "Cidade " + i + " gerado automaticamente.",
                UF = "RJ",
                Tipo = (TipoEnderecoEnum)i
            });
        }

        private void PopularEspecialidade(Int32 i)
        {
            var ind = i.ToString();
            new EspecialidadeRepository().Inserir(new Especialidade
            {
                Codigo = i + 10,
                Nome = "Especialidade " + i + " gerado automaticamente.",
                Descricao = "Descricao " + i + " gerado automaticamente."
            });
        }

        private void PopularPessoa(Int32 i)
        {
            var ind = i.ToString();
            new PessoaRepository().Inserir(new Pessoa
            {
                Nome = "Pessoa " + i + " gerado automaticamente.",
                Email = "email " + i + "geradoAutomaticamente@psi.com"
            });
        }

        private void PopularPessoaFisica(Int32 i)
        {
            var ind = i.ToString();
            new PessoaFisicaRepository().Inserir(new PessoaFisica
            {
                Rg = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                CPF = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                Naturalidade = (TipoFisicaEnum)i,
                Nacionalidade = (TipoFisicaEnum)i,
                DataNascimento = Convert.ToDateTime(ind + "/01/2014"),
                EstadoCivil = (TipoFisicaEnum)i,
            });
        }

        private void PopularPessoaJuridica(Int32 i)
        {
            var ind = i.ToString();
            new PessoaJuridicaRepository().Inserir(new PessoaJuridica
            {
                CNPJ = String.Concat(ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "/", ind, ind, ind, "-", ind, ind),
                InscricaoEstadual = String.Concat(ind, ind, ind, ind, ind, ind, ind, ind, ind),
                InscricaoMunicipal = String.Concat(ind, ind, ind, ind, ind, ind, ind, ind, ind, ind),
            });
        }

        private void PopularReserva(Int32 i)
        {
            var ind = i.ToString();
            new ReservaRepository().Inserir(new Reserva
            {
                DataNascimento = Convert.ToDateTime(ind + "/01/2014"),
            });
        }

        private void PopularSala(Int32 i)
        {
            var ind = i.ToString();
            new SalaRepository().Inserir(new Sala
            {
                Numero = Convert.ToInt64(String.Concat(ind, ind, ind, ind, ind, ind, ind, ind, ind, ind)),
                Tipo = (TipoSalaEnum)i,
            });
        }

        private void PopularTelefone(Int32 i)
        {
            var ind = i.ToString();
            new TelefoneRepository().Inserir(new Telefone
            {
                Numero = String.Concat(ind, " ", ind, ind, ind, ind, "-", ind, ind, ind, ind),
                DDI = String.Concat(ind, ind, ind),
                DDD = String.Concat(ind, ind, ind),
                TipoTelefone = (TipoTelefoneEnum)i,
            });
        }
    }
}
