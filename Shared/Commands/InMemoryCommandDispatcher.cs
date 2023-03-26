using Microsoft.Extensions.DependencyInjection;

using Shared.Abstractions.Commands;

namespace Shared.Commands;

internal sealed class InMemoryCommandDispatcher: ICommandDispatcher
{
	private readonly IServiceProvider _serviceProvider;

	public InMemoryCommandDispatcher(IServiceProvider serviceProvider)
    {
		_serviceProvider = serviceProvider;
	}

    async Task ICommandDispatcher.DispatchAsync<TCommand>(TCommand command)
	{
		using var scope = _serviceProvider.CreateScope();

		var handler = scope.ServiceProvider.GetRequiredService<ICommandHandler<TCommand>>();

		await handler.HandleAsync(command);
	}
}
