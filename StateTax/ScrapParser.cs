using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StateTax
{
    public class ScrapParser
    {
        public async Task<string> ParseHTML(string parser)
        {
            var indexInicio = parser.IndexOf("<table ");
            var indexFim = parser.IndexOf("</table>");
            var indexResult = indexFim - indexInicio;
            return parser.Substring(indexInicio, indexResult);
        }
    }
}
