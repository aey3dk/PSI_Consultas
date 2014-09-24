using DAL.Model;
using DAL.Persistence;
using System;

namespace DAL.Repository
{
    public class BaseRepository
    {
        public void RecriarBaseDados()
        {
            try
            {
                RepositorioContainer Repositorio = new RepositorioContainer();
                if (Repositorio.Database.Exists())
                {
                    Repositorio.Database.Delete();
                    Repositorio.Database.Create();
                    Repositorio.Dispose();
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
                    PopularCobranca(i);
                    PopularConsulta(i);
                    PopularConvenio(i);
                    PopularDocumento(i);
                    PopularEndereco(i);
                    PopularEspecialidade(i);
                    if ((i % 2).Equals(0))
                        PopularPaciente(i);
                    else
                        PopularProfissional(i);
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

        private void PopularCobranca(Int32 i)
        {
            var ind = i.ToString();
            new CobrancaRepository().Inserir(new Cobranca
            {
                Id = Convert.ToInt32(String.Concat(ind, ind, ind)),
                Valor = (Decimal)(i + i * 10 + i * 100 + i * 0.1 + i * 0.01),
                Status = (StatusCobrancaEnum)i
            });
        }

        private void PopularConsulta(Int32 i)
        {
            var ind = i.ToString();
            new ConsultaRepository().Inserir(new Consulta
            {
                Id = Convert.ToInt32(String.Concat(ind, ind, ind)),
                DataHora = Convert.ToDateTime(ind + "/01/2014"),
                Observacao = "Observação " + i + " gerado automaticamente.",
                Status = (StatusConsultaEnum)i
            });
        }

        private void PopularConvenio(Int32 i)
        {
            var ind = i.ToString();
            new ConvenioRepository().Inserir(new Convenio
            {
                Id = Convert.ToInt32(String.Concat(ind, ind, ind)),
                Nome = "Convenio " + i + " gerado automaticamente.",
                Email = "convenio " + i + "@gmail.com.",
                NumeroCartao = Convert.ToInt64(String.Concat(ind, ind, ind, ind, ind, ind, ind, ind, ind, ind, ind, ind, ind, ind, ind, ind)),
                TipoPlanoSaude = (TipoPlanoSaudeEnum)i
            });
        }

        private void PopularDocumento(Int32 i)
        {
            var ind = i.ToString();
            new DocumentoRepository().Inserir(new Documento
            {
                Id = Convert.ToInt32(String.Concat(ind, ind, ind)),
                Descricao = "Documento " + i + " gerado automaticamente.",
            });
        }

        private void PopularEndereco(Int32 i)
        {
            var ind = i.ToString();
            new EnderecoRepository().Inserir(new Endereco
            {
                Id = Convert.ToInt32(String.Concat(ind, ind, ind)),
                CEP = String.Concat(ind, ind, ind, ind, ind, ind, ind, ind),
                Logradouro = "Logradoro " + i + " gerado automaticamente.",
                Numero = Convert.ToInt32(String.Concat(ind, ind, ind, ind, ind)),
                Complemento = "Complemento " + i + " gerado automaticamente.",
                Bairro = "Bairro " + i + " gerado automaticamente.",
                Pais = "Pais " + i + " gerado automaticamente.",
                Cidade = "Cidade " + i + " gerado automaticamente.",
                UF = "RJ",
                TipoMoradia = (TipoMoradiaEnum)i
            });
        }

        private void PopularEspecialidade(Int32 i)
        {
            var ind = i.ToString();
            new EspecialidadeRepository().Inserir(new Especialidade
            {
                Id = Convert.ToInt32(String.Concat(ind, ind, ind)),
                Nome = "Especialidade " + i + " gerado automaticamente.",
                Descricao = "Descricao " + i + " gerado automaticamente."
            });
        }

        private void PopularPaciente(Int32 i)
        {
            var ind = i.ToString();
            new PacienteRepository().Inserir(new Paciente
            {
                Id = Convert.ToInt32(String.Concat(ind, ind, ind)),
                Nome = "Paciente " + i + " gerado automaticamente.",
                Email = "paciente" + i + "@gmail.com",
                Nascimento = Convert.ToDateTime(ind + "/01/2014"),
                CPF = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                RG = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                Naturalidade = "Naturalidade " + i + " gerado automaticamente.",
                Nacionalidade = "Nacionalidade " + i + " gerado automaticamente.",
                EstadoCivil = (EstadoCivilEnum)i,
                Sexo = (SexoEnum)i,
            });
        }

        private void PopularProfissional(Int32 i)
        {
            var ind = i.ToString();
            new ProfissionalRepository().Inserir(new Profissional
            {
                Id = Convert.ToInt32(String.Concat(ind, ind, ind)),
                Nome = "Profissional " + i + " gerado automaticamente.",
                Email = "profissional" + i + "@gmail.com",
                CPF = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                RG = String.Concat(ind, ind, ind, ".", ind, ind, ind, ".", ind, ind, ind, "-", ind, ind),
                Naturalidade = "Naturalidade " + i + " gerado automaticamente.",
                Nacionalidade = "Nacionalidade " + i + " gerado automaticamente.",
                EstadoCivil = (DAL.Model.EstadoCivilEnum)i,
                Sexo = (DAL.Model.SexoEnum)i,
                NumeroConselho = Convert.ToInt32(String.Concat(ind, ind, ind, ind, ind, ind, ind, ind, ind)),
            });
        }

        private void PopularReserva(Int32 i)
        {
            var ind = i.ToString();
            new ReservaRepository().Inserir(new Reserva
            {
                Id = Convert.ToInt32(String.Concat(ind, ind, ind)),
                DataHora = Convert.ToDateTime(ind + "/01/2014"),
            });
        }

        private void PopularSala(Int32 i)
        {
            var ind = i.ToString();
            new SalaRepository().Inserir(new Sala
            {
                Id = Convert.ToInt32(String.Concat(ind, ind, ind)),
                Numero = Convert.ToInt32(String.Concat(ind, ind, ind, ind, ind)),
                Status = (StatusSalaEnum)i,
            });
        }

        private void PopularTelefone(Int32 i)
        {
            var ind = i.ToString();
            new TelefoneRepository().Inserir(new Telefone
            {
                Id = Convert.ToInt32(String.Concat(ind, ind, ind)),
                DDI = Convert.ToInt16(String.Concat(ind, ind, ind)),
                DDD = Convert.ToInt16(String.Concat(ind, ind, ind)),
                Numero = Convert.ToInt32(String.Concat(ind, ind, ind, ind, ind, ind, ind, ind, ind)),
                Ramal = Convert.ToInt32(String.Concat(ind, ind, ind, ind, ind, ind)),
                Tipo = (TipoTelefoneEnum)i,
            });
        }
    }
}
