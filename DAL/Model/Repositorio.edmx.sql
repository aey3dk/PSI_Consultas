
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/24/2014 17:35:56
-- Generated from EDMX file: C:\Users\ccabral\Pessoais\ProjetoFinal\PSI_Consultas\DAL\Model\Repositorio.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PSI];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ConvenioPaciente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Paciente] DROP CONSTRAINT [FK_ConvenioPaciente];
GO
IF OBJECT_ID(N'[dbo].[FK_PessoaDocumento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Documento] DROP CONSTRAINT [FK_PessoaDocumento];
GO
IF OBJECT_ID(N'[dbo].[FK_PessoaEndereco]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Endereco] DROP CONSTRAINT [FK_PessoaEndereco];
GO
IF OBJECT_ID(N'[dbo].[FK_PessoaTelefone]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Telefone] DROP CONSTRAINT [FK_PessoaTelefone];
GO
IF OBJECT_ID(N'[dbo].[FK_ConvenioTelefone]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Telefone] DROP CONSTRAINT [FK_ConvenioTelefone];
GO
IF OBJECT_ID(N'[dbo].[FK_ConsultaCobranca]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cobranca] DROP CONSTRAINT [FK_ConsultaCobranca];
GO
IF OBJECT_ID(N'[dbo].[FK_ReservaCobranca]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cobranca] DROP CONSTRAINT [FK_ReservaCobranca];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfissionalEspecialidade_Profissional]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfissionalEspecialidade] DROP CONSTRAINT [FK_ProfissionalEspecialidade_Profissional];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfissionalEspecialidade_Especialidade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProfissionalEspecialidade] DROP CONSTRAINT [FK_ProfissionalEspecialidade_Especialidade];
GO
IF OBJECT_ID(N'[dbo].[FK_PacienteConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consulta] DROP CONSTRAINT [FK_PacienteConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfissionalConsulta]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Consulta] DROP CONSTRAINT [FK_ProfissionalConsulta];
GO
IF OBJECT_ID(N'[dbo].[FK_ProfissionalReserva]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reserva] DROP CONSTRAINT [FK_ProfissionalReserva];
GO
IF OBJECT_ID(N'[dbo].[FK_SalaReserva]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reserva] DROP CONSTRAINT [FK_SalaReserva];
GO
IF OBJECT_ID(N'[dbo].[FK_Paciente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Paciente] DROP CONSTRAINT [FK_Paciente_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Profissional_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Profissional] DROP CONSTRAINT [FK_Profissional_inherits_Pessoa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Pessoa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa];
GO
IF OBJECT_ID(N'[dbo].[Convenio]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Convenio];
GO
IF OBJECT_ID(N'[dbo].[Documento]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Documento];
GO
IF OBJECT_ID(N'[dbo].[Telefone]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Telefone];
GO
IF OBJECT_ID(N'[dbo].[Endereco]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Endereco];
GO
IF OBJECT_ID(N'[dbo].[Sala]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sala];
GO
IF OBJECT_ID(N'[dbo].[Reserva]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reserva];
GO
IF OBJECT_ID(N'[dbo].[Cobranca]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cobranca];
GO
IF OBJECT_ID(N'[dbo].[Consulta]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Consulta];
GO
IF OBJECT_ID(N'[dbo].[Especialidade]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Especialidade];
GO
IF OBJECT_ID(N'[dbo].[Pessoa_Paciente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa_Paciente];
GO
IF OBJECT_ID(N'[dbo].[Pessoa_Profissional]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa_Profissional];
GO
IF OBJECT_ID(N'[dbo].[ProfissionalEspecialidade]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProfissionalEspecialidade];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Pessoa'
CREATE TABLE [dbo].[Pessoa] (
    [Id] int  NOT NULL,
    [Nome] nvarchar(60)  NULL,
    [Email] nvarchar(60)  NULL,
    [Nascimento] datetime  NULL,
    [Senha] nvarchar(max)  NULL,
    [RG] nvarchar(max)  NULL,
    [CPF] nvarchar(max)  NULL,
    [Naturalidade] nvarchar(max)  NULL,
    [Nacionalidade] nvarchar(max)  NULL,
    [Sexo] int  NULL,
    [EstadoCivil] int  NULL
);
GO

-- Creating table 'Convenio'
CREATE TABLE [dbo].[Convenio] (
    [Id] int  NOT NULL,
    [Nome] nvarchar(60)  NULL,
    [Email] nvarchar(60)  NULL,
    [NumeroCartao] bigint  NULL,
    [TipoPlanoSaude] int  NULL
);
GO

-- Creating table 'Documento'
CREATE TABLE [dbo].[Documento] (
    [Id] int  NOT NULL,
    [Descricao] nvarchar(60)  NULL,
    [PessoaId] int  NULL
);
GO

-- Creating table 'Telefone'
CREATE TABLE [dbo].[Telefone] (
    [Id] int  NOT NULL,
    [DDI] smallint  NULL,
    [DDD] smallint  NULL,
    [Numero] int  NULL,
    [Ramal] int  NULL,
    [Tipo] int  NULL,
    [PessoaId] int  NULL,
    [ConvenioId] int  NULL
);
GO

-- Creating table 'Endereco'
CREATE TABLE [dbo].[Endereco] (
    [Id] int  NOT NULL,
    [CEP] nvarchar(max)  NULL,
    [Logradouro] nvarchar(max)  NULL,
    [Numero] int  NULL,
    [Complemento] nvarchar(max)  NULL,
    [Bairro] nvarchar(max)  NULL,
    [Cidade] nvarchar(max)  NULL,
    [UF] nvarchar(2)  NULL,
    [Pais] nvarchar(max)  NULL,
    [TipoMoradia] int  NULL,
    [Pessoa_Id] int  NULL
);
GO

-- Creating table 'Sala'
CREATE TABLE [dbo].[Sala] (
    [Id] int  NOT NULL,
    [Numero] int  NULL,
    [Status] int  NULL
);
GO

-- Creating table 'Reserva'
CREATE TABLE [dbo].[Reserva] (
    [Id] int  NOT NULL,
    [DataHora] datetime  NULL,
    [ProfissionalId] int  NULL,
    [SalaId] int  NULL
);
GO

-- Creating table 'Cobranca'
CREATE TABLE [dbo].[Cobranca] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Valor] decimal(18,0)  NULL,
    [Status] int  NULL,
    [Consulta_Id] int  NULL,
    [Reserva_Id] int  NULL
);
GO

-- Creating table 'Consulta'
CREATE TABLE [dbo].[Consulta] (
    [Id] int  NOT NULL,
    [DataHora] datetime  NULL,
    [Status] int  NULL,
    [Observacao] nvarchar(max)  NULL,
    [PacienteId] int  NULL,
    [ProfissionalId] int  NULL,
    [Paciente_Id] int  NULL
);
GO

-- Creating table 'Especialidade'
CREATE TABLE [dbo].[Especialidade] (
    [Id] int  NOT NULL,
    [Nome] nvarchar(max)  NULL,
    [Descricao] nvarchar(max)  NULL
);
GO

-- Creating table 'Pessoa_Paciente'
CREATE TABLE [dbo].[Pessoa_Paciente] (
    [Id] int  NOT NULL,
    [Convenio_Id] int  NULL
);
GO

-- Creating table 'Pessoa_Profissional'
CREATE TABLE [dbo].[Pessoa_Profissional] (
    [NumeroConselho] int  NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'ProfissionalEspecialidade'
CREATE TABLE [dbo].[ProfissionalEspecialidade] (
    [Profissional_Id] int  NOT NULL,
    [Especialidade_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Pessoa'
ALTER TABLE [dbo].[Pessoa]
ADD CONSTRAINT [PK_Pessoa]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Convenio'
ALTER TABLE [dbo].[Convenio]
ADD CONSTRAINT [PK_Convenio]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Documento'
ALTER TABLE [dbo].[Documento]
ADD CONSTRAINT [PK_Documento]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Telefone'
ALTER TABLE [dbo].[Telefone]
ADD CONSTRAINT [PK_Telefone]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Endereco'
ALTER TABLE [dbo].[Endereco]
ADD CONSTRAINT [PK_Endereco]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sala'
ALTER TABLE [dbo].[Sala]
ADD CONSTRAINT [PK_Sala]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Reserva'
ALTER TABLE [dbo].[Reserva]
ADD CONSTRAINT [PK_Reserva]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cobranca'
ALTER TABLE [dbo].[Cobranca]
ADD CONSTRAINT [PK_Cobranca]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [PK_Consulta]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Especialidade'
ALTER TABLE [dbo].[Especialidade]
ADD CONSTRAINT [PK_Especialidade]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoa_Paciente'
ALTER TABLE [dbo].[Pessoa_Paciente]
ADD CONSTRAINT [PK_Pessoa_Paciente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoa_Profissional'
ALTER TABLE [dbo].[Pessoa_Profissional]
ADD CONSTRAINT [PK_Pessoa_Profissional]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Profissional_Id], [Especialidade_Id] in table 'ProfissionalEspecialidade'
ALTER TABLE [dbo].[ProfissionalEspecialidade]
ADD CONSTRAINT [PK_ProfissionalEspecialidade]
    PRIMARY KEY CLUSTERED ([Profissional_Id], [Especialidade_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Convenio_Id] in table 'Pessoa_Paciente'
ALTER TABLE [dbo].[Pessoa_Paciente]
ADD CONSTRAINT [FK_ConvenioPaciente]
    FOREIGN KEY ([Convenio_Id])
    REFERENCES [dbo].[Convenio]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConvenioPaciente'
CREATE INDEX [IX_FK_ConvenioPaciente]
ON [dbo].[Pessoa_Paciente]
    ([Convenio_Id]);
GO

-- Creating foreign key on [PessoaId] in table 'Documento'
ALTER TABLE [dbo].[Documento]
ADD CONSTRAINT [FK_PessoaDocumento]
    FOREIGN KEY ([PessoaId])
    REFERENCES [dbo].[Pessoa]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PessoaDocumento'
CREATE INDEX [IX_FK_PessoaDocumento]
ON [dbo].[Documento]
    ([PessoaId]);
GO

-- Creating foreign key on [Pessoa_Id] in table 'Endereco'
ALTER TABLE [dbo].[Endereco]
ADD CONSTRAINT [FK_PessoaEndereco]
    FOREIGN KEY ([Pessoa_Id])
    REFERENCES [dbo].[Pessoa]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PessoaEndereco'
CREATE INDEX [IX_FK_PessoaEndereco]
ON [dbo].[Endereco]
    ([Pessoa_Id]);
GO

-- Creating foreign key on [PessoaId] in table 'Telefone'
ALTER TABLE [dbo].[Telefone]
ADD CONSTRAINT [FK_PessoaTelefone]
    FOREIGN KEY ([PessoaId])
    REFERENCES [dbo].[Pessoa]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PessoaTelefone'
CREATE INDEX [IX_FK_PessoaTelefone]
ON [dbo].[Telefone]
    ([PessoaId]);
GO

-- Creating foreign key on [ConvenioId] in table 'Telefone'
ALTER TABLE [dbo].[Telefone]
ADD CONSTRAINT [FK_ConvenioTelefone]
    FOREIGN KEY ([ConvenioId])
    REFERENCES [dbo].[Convenio]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConvenioTelefone'
CREATE INDEX [IX_FK_ConvenioTelefone]
ON [dbo].[Telefone]
    ([ConvenioId]);
GO

-- Creating foreign key on [Consulta_Id] in table 'Cobranca'
ALTER TABLE [dbo].[Cobranca]
ADD CONSTRAINT [FK_ConsultaCobranca]
    FOREIGN KEY ([Consulta_Id])
    REFERENCES [dbo].[Consulta]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ConsultaCobranca'
CREATE INDEX [IX_FK_ConsultaCobranca]
ON [dbo].[Cobranca]
    ([Consulta_Id]);
GO

-- Creating foreign key on [Reserva_Id] in table 'Cobranca'
ALTER TABLE [dbo].[Cobranca]
ADD CONSTRAINT [FK_ReservaCobranca]
    FOREIGN KEY ([Reserva_Id])
    REFERENCES [dbo].[Reserva]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReservaCobranca'
CREATE INDEX [IX_FK_ReservaCobranca]
ON [dbo].[Cobranca]
    ([Reserva_Id]);
GO

-- Creating foreign key on [Profissional_Id] in table 'ProfissionalEspecialidade'
ALTER TABLE [dbo].[ProfissionalEspecialidade]
ADD CONSTRAINT [FK_ProfissionalEspecialidade_Profissional]
    FOREIGN KEY ([Profissional_Id])
    REFERENCES [dbo].[Pessoa_Profissional]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Especialidade_Id] in table 'ProfissionalEspecialidade'
ALTER TABLE [dbo].[ProfissionalEspecialidade]
ADD CONSTRAINT [FK_ProfissionalEspecialidade_Especialidade]
    FOREIGN KEY ([Especialidade_Id])
    REFERENCES [dbo].[Especialidade]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfissionalEspecialidade_Especialidade'
CREATE INDEX [IX_FK_ProfissionalEspecialidade_Especialidade]
ON [dbo].[ProfissionalEspecialidade]
    ([Especialidade_Id]);
GO

-- Creating foreign key on [Paciente_Id] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_PacienteConsulta]
    FOREIGN KEY ([Paciente_Id])
    REFERENCES [dbo].[Pessoa_Paciente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PacienteConsulta'
CREATE INDEX [IX_FK_PacienteConsulta]
ON [dbo].[Consulta]
    ([Paciente_Id]);
GO

-- Creating foreign key on [ProfissionalId] in table 'Consulta'
ALTER TABLE [dbo].[Consulta]
ADD CONSTRAINT [FK_ProfissionalConsulta]
    FOREIGN KEY ([ProfissionalId])
    REFERENCES [dbo].[Pessoa_Profissional]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfissionalConsulta'
CREATE INDEX [IX_FK_ProfissionalConsulta]
ON [dbo].[Consulta]
    ([ProfissionalId]);
GO

-- Creating foreign key on [ProfissionalId] in table 'Reserva'
ALTER TABLE [dbo].[Reserva]
ADD CONSTRAINT [FK_ProfissionalReserva]
    FOREIGN KEY ([ProfissionalId])
    REFERENCES [dbo].[Pessoa_Profissional]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProfissionalReserva'
CREATE INDEX [IX_FK_ProfissionalReserva]
ON [dbo].[Reserva]
    ([ProfissionalId]);
GO

-- Creating foreign key on [SalaId] in table 'Reserva'
ALTER TABLE [dbo].[Reserva]
ADD CONSTRAINT [FK_SalaReserva]
    FOREIGN KEY ([SalaId])
    REFERENCES [dbo].[Sala]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SalaReserva'
CREATE INDEX [IX_FK_SalaReserva]
ON [dbo].[Reserva]
    ([SalaId]);
GO

-- Creating foreign key on [Id] in table 'Pessoa_Paciente'
ALTER TABLE [dbo].[Pessoa_Paciente]
ADD CONSTRAINT [FK_Paciente_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Pessoa]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Pessoa_Profissional'
ALTER TABLE [dbo].[Pessoa_Profissional]
ADD CONSTRAINT [FK_Profissional_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Pessoa]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------