using Microsoft.Extensions.DependencyInjection;

using Shared.Abstractions.Commands;
using Shared.Commands;

using System.Reflection;

namespace Shared;

public static class Extentions
{
	public static IServiceCollection AddCommands(this IServiceCollection services)
	{
		var assembly = Assembly.GetCallingAssembly();

		services.AddSingleton<ICommandDispatcher, InMemoryCommandDispatcher>();

		services.Scan(s => s.FromAssemblies(assembly)
			.AddClasses(c => c.AssignableTo(typeof(ICommandHandler<>)))
			.AsImplementedInterfaces()
			.WithScopedLifetime());

		return services;
	}
}
