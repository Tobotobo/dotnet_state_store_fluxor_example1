﻿using Fluxor;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace dotnet_state_store_fluxor_example1
{
	class Program
	{
		static void Main(string[] args)
		{
			var services = new ServiceCollection();
			services.AddScoped<App>();
			services.AddFluxor(o => o
				.ScanAssemblies(typeof(Program).Assembly));

			IServiceProvider serviceProvider = services.BuildServiceProvider();

			var app = serviceProvider.GetRequiredService<App>();
			app.Run();
		}
	}
}
