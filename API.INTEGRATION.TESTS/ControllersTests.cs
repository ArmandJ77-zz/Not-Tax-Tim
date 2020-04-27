using API;
using Microsoft.AspNetCore.Mvc.Testing;
using NotTaxTim.Api.Integrtions.Tests.Infrastructure;
using NotTaxTim.Logic.Calculations.Commands;
using NotTaxTim.Logic.Calculations.Responses;
using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;

namespace NotTaxTim.Api.Integrtions.Tests
{
    [TestFixture]
    public class ControllersTests
    {
        private WebApplicationFactory<Startup> _factory;
        private HttpClient _client;
        private string PathBuilder(string extension) => $"api/{extension}";

        [OneTimeSetUp]
        public void Setup()
        {
            _factory = new WebApplicationFactory<Startup>();
            _client = _factory.CreateClient();
        }

        [Test]
        public async Task Given_FlatValue_Less_Than_200000_Expect_Five_Percent_Tax()
        {
            // ARRANGE
            const string code = "A100";
            decimal annualIncome = 10000;
            var command = new CalculationsCreateCommand { AnnualIncome = annualIncome, PostalCode = code };

            // ACT
            var response = await _client.PostAsJsonAsync(PathBuilder("calculations"), command);

            var result = response.Content.Deserialize<CalculationsCreateResponse>().Result;

            // ASSERT
            StringAssert.AreEqualIgnoringCase(code, result.PostalCode);
            Assert.That(result.AnnualIncome, Is.EqualTo(annualIncome));
            Assert.That(result.TotalTax, Is.EqualTo(500));
        }

        [Test]
        public async Task Given_FlatValue_More_Than_200000_Expect_Tenthousand_Tax()
        {
            // ARRANGE
            const string code = "A100";
            decimal annualIncome = 250000;
            var command = new CalculationsCreateCommand { AnnualIncome = annualIncome, PostalCode = code };

            // ACT
            var response = await _client.PostAsJsonAsync(PathBuilder("calculations"), command);

            var result = response.Content.Deserialize<CalculationsCreateResponse>().Result;

            // ASSERT
            StringAssert.AreEqualIgnoringCase(code, result.PostalCode);
            Assert.That(result.AnnualIncome, Is.EqualTo(annualIncome));
            Assert.That(result.TotalTax, Is.EqualTo(10000));
        }

        [Test]
        public async Task Given_FlatRate_Expect_Seventeen_Point_Five_Percent_Tax()
        {
            // ARRANGE
            const string code = "7000";
            decimal annualIncome = 10000;
            var command = new CalculationsCreateCommand { AnnualIncome = annualIncome, PostalCode = code };

            // ACT
            var response = await _client.PostAsJsonAsync(PathBuilder("calculations"), command);

            var result = response.Content.Deserialize<CalculationsCreateResponse>().Result;

            // ASSERT
            StringAssert.AreEqualIgnoringCase(code, result.PostalCode);
            Assert.That(result.AnnualIncome, Is.EqualTo(annualIncome));
            Assert.That(result.TotalTax, Is.EqualTo(1750));
        }

        [TestCase(4175,"1000",417.50)]
        [TestCase(16975,"7441",2128.60)]
        [TestCase(41125,"1000",7721)]
        [TestCase(85225,"7441",27322.72)]
        [TestCase(186475,"1000",79448.92)]
        [TestCase(572951,"7441",267597.5)]
        public async Task Given_Progressive_Bracket_Expect_Sum_Of_Tax(decimal annualIncome,string code, decimal totalTax)
        {
            // ARRANGE
            var command = new CalculationsCreateCommand { AnnualIncome = annualIncome, PostalCode = code };

            // ACT
            var response = await _client.PostAsJsonAsync(PathBuilder("calculations"), command);

            var result = response.Content.Deserialize<CalculationsCreateResponse>().Result;

            // ASSERT
            StringAssert.AreEqualIgnoringCase(code, result.PostalCode);
            Assert.That(result.AnnualIncome, Is.EqualTo(annualIncome));
            Assert.That(result.TotalTax, Is.EqualTo(totalTax));
        }
    }
}
