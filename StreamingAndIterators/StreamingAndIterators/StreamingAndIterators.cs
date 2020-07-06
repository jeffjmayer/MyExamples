using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace StreamingAndIterators
{
    class StreamingAndIterators
    {
        static void Main(string[] args)
        {
            //deferred execution and streaming

            var products = GetProducts(File.OpenText(@"..\..\Products.txt"), line =>
                {
                    var fields = line.Split(',');
                    return new Products
                    {
                        ProductId = int.Parse(fields[0]),
                        ItaProductId = fields[1],
                        ShortDesc = fields[2],
                        LongDesc = fields[3],
                        ProductCost = double.Parse(fields[4]),
                        IsActive = bool.Parse(fields[5])
                    };
                });
            
            var active = products.Where((p => p.IsActive));

            foreach (var product in active)
            {
                Console.WriteLine(product);
            }
            Console.ReadLine();
        }

        private static IEnumerable<Products> GetProducts(TextReader reader, Func<string, Products> lineParser )
        {
            using (reader)
            {
                string line;
                while ((line = reader.ReadLine()) != null )
                {
                    yield return lineParser(line);
                }
            }
        }
    }
}
