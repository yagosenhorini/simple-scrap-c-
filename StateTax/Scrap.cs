using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StateTax
{
    public class Scrap
    {
        public const string UrlBase = "http://www.sefaz.go.gov.br";
        public string UrlPost = UrlBase + "/ccn/001lstResultado.asp";
        public string UrlGet = UrlBase + "/ccn";

        public async Task<int> PreScrap()
        {
            
           var retorno = await HttpWebResponse.GetAsync(UrlGet);
            if (retorno.Contains("Cadastro de Contribuinte Nacional"))
            {
                return 200;
            }
            return 400;
        }

        public async Task<string> ScrapPost(string cnpj)
        {
            var data = $"tipoDocumento=cnpj&numrDocumento={cnpj}&btnSubmit=";
            var content = "application/x-www-form-urlencoded";
            var retorno = await HttpWebResponse.PostAsync(UrlPost, data, content);

            return retorno;
        }
    }
}
