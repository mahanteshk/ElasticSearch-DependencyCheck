using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestFullFrameworkExample
{
    public class ElasticSearchLogic
    {
        public async Task Search1()
        {
            try
            {
                var _settings = new ConnectionSettings(new Uri("http://testlogstashelasticendpoint.com:80/"));

                var client = new ElasticClient(_settings);

                var bnfResult = await client.SearchAsync<dynamic>(s => s
                                        .Index("test_index")
                                        .Query(q => q.Raw("{\"bool\":{\"must\":[{\"term\":{\"testid\":\"oformstg\"}}]}}")));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
