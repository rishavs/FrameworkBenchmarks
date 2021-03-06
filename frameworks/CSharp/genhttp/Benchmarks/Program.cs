﻿using GenHTTP.Core;
using GenHTTP.Modules.Core;
using GenHTTP.Modules.Webservices;

using Benchmarks.Tests;
using GenHTTP.Modules.Scriban;

namespace Benchmarks
{

    public static class Program
    {

        public static int Main(string[] args)
        {
            var tests = Layout.Create()
                              .Add("plaintext", Content.From("Hello, World!"))
                              .Add("fortunes", new FortuneHandlerBuilder())
                              .Add<JsonResource>("json")
                              .Add<DbResource>("db")
                              .Add<QueryResource>("queries")
                              .Add<UpdateResource>("updates");

            return Host.Create()
                       .Handler(tests)
                       .Run();
        }

    }

}
