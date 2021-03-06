﻿using Noobot.Core.Configuration;
using Noobot.Toolbox.Pipeline.Middleware;

namespace Noobot.Examples.Web.Configuration
{
    public class ExampleConfiguration : ConfigurationBase
    {
        public ExampleConfiguration()
        {
            UseMiddleware<WelcomeMiddleware>();
            UseMiddleware<JokeMiddleware>();
            UseMiddleware<CalculatorMiddleware>();
            UseMiddleware<FlickrMiddleware>();

            UsePlugin<Toolbox.Plugins.StoragePlugin>();
        }
    }
}