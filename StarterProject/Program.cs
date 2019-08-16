using NestFullFrameworkExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {

            ElasticSearchLogic elasticSearchLogic = new ElasticSearchLogic();
            elasticSearchLogic.Search1();
        }
    }
}
