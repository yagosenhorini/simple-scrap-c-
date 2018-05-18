using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StateTax;
using System.IO;

namespace StateTaxTests
{
    public class ParserHTMLTests
    {
        [Fact]
        public async Task ParserHTML_whenHTMLIsAvailable_returnOk()
        {
            ScrapParser scrapParser = new ScrapParser();
            var doc = File.ReadAllText(@"Files\HTML.txt");
            var ret = await scrapParser.ParseHTML(doc);
            var tabela = "table";
            Assert.Contains(tabela, doc);
            //var ret = scrapParser.ParseHTML(html).Result;
            //Se o método for async, usar o await, senão o metodo será void e o retorno deverá ter Result;

        }
    }
}
