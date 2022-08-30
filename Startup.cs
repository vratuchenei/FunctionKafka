using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionKafkaConsumer;

public class Startup : FunctionsStartup
{
    //IsEncrypted

    public override void Configure(IFunctionsHostBuilder builder)
    {
        var teste = Environment.GetEnvironmentVariable("IsEncrypted");


        throw new NotImplementedException();
    }
}
