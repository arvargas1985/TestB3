namespace TestB3.WebApi.Tests.Controllers
{
    using System;
    using System.Web.Http;
    using System.Web.Http.Results;
    using System.Web.Mvc;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestB3.WebApi;
    using TestB3.WebApi.Controllers;
    using TestB3.WebApi.Models;

    [TestClass]
    public class QuotesCDBsControllerTest
    {
        private readonly IQuoteCDBRepository _quoteCDBRepository = null;

        /// <summary>
        /// Você obtém um desses por método de teste.
        /// </summary>
        public QuotesCDBsControllerTest()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<IQuoteCDBRepository, QuoteCDBRepository>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            this._quoteCDBRepository = serviceProvider.GetService<IQuoteCDBRepository>();
        }

        [TestInitialize]
        public void Initialize()
        {
            //this._pedidoOperacao = new Pedido.Operacao();
            //this._pedidoOperacaoAtacado = new Pedido.Operacao.Atacado();
        }

        [TestCleanup]
        public void Cleanup()
        {
            //this._quoteCDBRepository.Dispose();
            //this._quoteCDBRepository = null;
        }

        [TestMethod]
        [DataRow(2, 18000, 18174.96, 4089.37, 14085.59)]
        [DataRow(7, 20000, 21195.11, 4239.02, 16956.09)]
        [DataRow(13, 28000, 31446.30, 5503.10, 25943.20)]
        [DataRow(25, 36000, 45407.28, 7719.24, 37688.04)]
        [DataRow(100, 100000, 260552.30, 44293.89, 216258.41)]
        public void PostCDB_ShouldEqualExpected(int quantityMonths, double value, double bruteResultExpected, double taxesExpected, double liquidResultExpected)
        {
            // Arrange
            QuotesCDBsController controller = new QuotesCDBsController(this._quoteCDBRepository);

            // Act
            var model = new QuoteCDB
            {
                QuantityMonths = quantityMonths,
                Value = Convert.ToDecimal(
                    value),
            };

            IHttpActionResult httpActionResult = controller.PostCDB(model);

            var contentResult = httpActionResult as OkNegotiatedContentResult<QuoteCDB>;

            var modelActual = contentResult.Content;

            // Assert
            Assert.IsInstanceOfType(httpActionResult, typeof(OkNegotiatedContentResult<QuoteCDB>));

            Assert.IsNotNull(modelActual);

            Assert.AreEqual(
                Convert.ToDecimal(
                    bruteResultExpected),
                modelActual.BruteResult);

            Assert.AreEqual(
                Convert.ToDecimal(
                    taxesExpected),
                modelActual.Taxes);

            Assert.AreEqual(
                Convert.ToDecimal(
                    liquidResultExpected),
                modelActual.LiquidResult);
        }

        [TestMethod]
        public void PostCDB_ShouldThrowException()
        {
            // Arrange
            QuotesCDBsController controller = new QuotesCDBsController(this._quoteCDBRepository);

            controller.ModelState.AddModelError("null", "null");

            // Act
            var model = new QuoteCDB
            {
                QuantityMonths = 1,
                Value = 0m,
            };

            // Assert
            // Act
            var response = controller.PostCDB(model);

            // Assert
            Assert.IsInstanceOfType(response, typeof(InvalidModelStateResult));
        }
    }
}