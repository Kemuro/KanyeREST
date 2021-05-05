using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeREST
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int i = 0; i < 20; i++)
            {
                if(i % 2 == 0)
                {
                    QuoteGenerator.KanyeQuote();
                }
                else
                {
                    QuoteGenerator.RonQuote();
                }
            }
        }
    }
}
