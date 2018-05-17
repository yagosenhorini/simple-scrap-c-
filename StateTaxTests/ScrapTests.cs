using System;
using Xunit;
using StateTax;
using System.Threading.Tasks;

namespace StateTaxTests
{
    public class ScrapTests
    {
        [Fact]
        public async Task ScrapGet_whenGetIsValid_Return200()
        {
            //arrange
            var scrap = new Scrap();
            //act
            var resposta = await scrap.PreScrap();
            //assert
            Assert.Equal(200, resposta);
            Console.WriteLine(resposta);
        }
        [Fact]
        public async Task ScrapGet_whenGetIsNotValid_Return400()
        {
            //arrange
            var scrap = new Scrap();
            scrap.UrlGet = "http://www.xablau.org";
            //act
            var resposta = await scrap.PreScrap();
            //assert
            Assert.NotNull(resposta);
            Assert.Equal(400, resposta);
        }
        [Fact]
        public async Task ScrapPost_whenPostIsValid_Return200()
        {
            //arrange
            var scrap = new Scrap();
            var respostaPost = "09044235000150";

            //act
            var resp = await scrap.ScrapPost(respostaPost);

            //assert
            Assert.NotNull(resp);
            //Assert.Equal(resp, respostaPost);
        }

        [Fact]
        public async Task ScrapPost_whenPostIsInvalid_return400()
        {
            //arrange
            var scrap = new Scrap();
            var respostaPost = "11111111111111";

            //act
            var resp = await scrap.ScrapPost(respostaPost);
            
            //assert
            Assert.NotNull(resp);
            //Assert.Equal(resp,respostaPost);
        }
    }
}
