using eAgenda.Controladores.CompromissoModule;
using eAgenda.Controladores.ContatoModule;
using eAgenda.Controladores.Shared;
using eAgenda.Dominio.ContatoModule;
using eAgenda.Dominio.CompromissoModule;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace eAgenda.Tests.CompromissoModule
{
    [TestClass]
    public class ControladorCompromissoTest
    {
        ControladorCompromisso controladorCompromisso = null;
        ControladorContato controladorContato = null;

        public ControladorCompromissoTest()
        {
            controladorCompromisso = new ControladorCompromisso();
            controladorContato = new ControladorContato();
            Db.Update("DELETE FROM [TBCOMPROMISSO]");
            Db.Update("DELETE FROM [TBCONTATO]");
        }

        [TestMethod]
        public void DeveInserir_Compromisso()
        {
            //arrange
            DateTime dataCompromisso;
            TimeSpan dataInicio, dataTermino;
            Contato novoContato;
            Input(out dataCompromisso, out dataInicio, out dataTermino, out novoContato);
            var compromisso = new Compromisso("Assunto", "Local", "Link", dataCompromisso, dataInicio, dataTermino, novoContato);

            //action
            controladorCompromisso.InserirNovo(compromisso);

            //assert
            var compromissoEncontrado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            compromissoEncontrado.Should().Be(compromisso);
        }
        [TestMethod]
        public void DeveInserir_CompromissoSemContato()
        {
            //arrange
            DateTime dataCompromisso = new DateTime(2021, 12, 12);
            TimeSpan dataInicio = new TimeSpan(12, 12, 12);
            TimeSpan dataTermino = new TimeSpan(12, 12, 13);

            var compromisso = new Compromisso("Assunto", "Local", "Link", dataCompromisso, dataInicio, dataTermino, null);

            //action
            controladorCompromisso.InserirNovo(compromisso);

            //assert
            var compromissoEncontrado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            compromissoEncontrado.Should().Be(compromisso);
        }
        [TestMethod]
        public void DeveAtualizar_Compromisso()
        {
            //arrange
            DateTime dataCompromisso;
            TimeSpan dataInicio, dataTermino;
            Contato novoContato;
            Input(out dataCompromisso, out dataInicio, out dataTermino, out novoContato);

            var compromisso = new Compromisso("Assunto", "Local", "Link", dataCompromisso, dataInicio, dataTermino, novoContato);
            controladorCompromisso.InserirNovo(compromisso);

            var novoCompromisso = new Compromisso("Assunto", "LocalEditado", "Link", dataCompromisso, dataInicio, dataTermino, novoContato);

            //action
            controladorCompromisso.Editar(compromisso.Id, novoCompromisso);

            //assert
            Compromisso compromissoAtualizado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            compromissoAtualizado.Should().Be(novoCompromisso);
        }
        [TestMethod]
        public void DeveExcluir_Compromisso()
        {
            //arrange            
            DateTime dataCompromisso;
            TimeSpan dataInicio, dataTermino;
            Contato novoContato;
            Input(out dataCompromisso, out dataInicio, out dataTermino, out novoContato);

            var compromisso = new Compromisso("Assunto", "Local", "Link", dataCompromisso, dataInicio, dataTermino, null);
            controladorCompromisso.InserirNovo(compromisso);

            //action
            
            controladorCompromisso.Excluir(compromisso.Id);

            //assert
            Compromisso contatoEncontrado = controladorCompromisso.SelecionarPorId(compromisso.Id);
            contatoEncontrado.Should().BeNull();
        }
        [TestMethod]
        public void DeveSelecionar_Compromisso_PorId()
        {
            //arrange
            DateTime dataCompromisso;
            TimeSpan dataInicio, dataTermino;
            Contato novoContato;
            Input(out dataCompromisso, out dataInicio, out dataTermino, out novoContato);

            var compromisso = new Compromisso("Assunto", "Local", "Link", dataCompromisso, dataInicio, dataTermino, null);
            controladorCompromisso.InserirNovo(compromisso);

            //action
            Compromisso compromissoEncontrado = controladorCompromisso.SelecionarPorId(compromisso.Id);

            //assert
            compromissoEncontrado.Should().NotBeNull();
        }
        [TestMethod]
        public void DeveSelecionar_TodosCompromissos()
        {
            //arrange
            DateTime dataCompromisso;
            TimeSpan dataInicio, dataTermino;
            Contato novoContato;
            Input(out dataCompromisso, out dataInicio, out dataTermino, out novoContato);

            var compromisso = new Compromisso("Assunto Compromisso", "Local", "Link", dataCompromisso, dataInicio, dataTermino, null);
            controladorCompromisso.InserirNovo(compromisso);

            var compromisso1 = new Compromisso("Assunto Compromisso um", "Local", "Link", dataCompromisso, dataInicio, dataTermino, null);
            controladorCompromisso.InserirNovo(compromisso1);

            var compromisso2 = new Compromisso("Assunto Compromisso dois", "Local", "Link", dataCompromisso, dataInicio, dataTermino, null);
            controladorCompromisso.InserirNovo(compromisso2);
            //action
            var compromissos = controladorCompromisso.SelecionarTodos();

            //assert
            compromissos.Should().HaveCount(3);
            compromissos[0].Assunto.Should().Be("Assunto Compromisso");
            compromissos[1].Assunto.Should().Be("Assunto Compromisso um");
            compromissos[2].Assunto.Should().Be("Assunto Compromisso dois");
        }

        private void Input(out DateTime dataCompromisso, out TimeSpan dataInicio, out TimeSpan dataTermino, out Contato novoContato)
        {
            dataCompromisso = new DateTime(2021, 12, 12);
            dataInicio = new TimeSpan(12, 12, 12);
            dataTermino = new TimeSpan(12, 12, 13);
            novoContato = new Contato("José Pedro", "jose.pedro@gmail.com", "321654987", "JP Ltda", "Dev");
            controladorContato.InserirNovo(novoContato);
        }
    }
}
