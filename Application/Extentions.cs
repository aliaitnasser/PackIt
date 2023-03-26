using Domain.Factories;
using Domain.Policies;

using Microsoft.Extensions.DependencyInjection;

using Shared;

namespace Application;

public static class Extentions
{
	public static IServiceCollection AddApplication(this IServiceCollection services)
	{
		services.AddCommands();

		services.AddSingleton<IPackingListFactory, PackingListFactory>();

		services.Scan(b => b.FromAssemblies(typeof(IPackingItemsPolicy).Assembly)
		.AddClasses(c => c.AssignableTo<IPackingItemsPolicy>())
		.AsImplementedInterfaces()
		.WithSingletonLifetime());

		return services;
	}
}
