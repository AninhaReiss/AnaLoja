using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnaLoja.Data;
using AnaLoja.Data.Entities;

namespace AnaLoja.Tests
{
    [TestClass]
    public class ProdutoTests
    {
        // [metodo]_[condicao]_[resultadoEsperado]
        [TestMethod]
        public void Descricao_ObterValor_DescricaoPreenchida()
        {
            //Arrange
            Produto produto = new Produto();
            produto.Descricao = "HD externo 1TB";
            string resultadoEsperado = "HD externo 1TB";

            //Act
            string resultadoAtual = produto.Descricao;

            //Assert
            Assert.AreEqual(resultadoEsperado, resultadoAtual);
        }


    }
}
