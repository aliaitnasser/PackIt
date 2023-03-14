using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Abstractions.Domain;

public abstract class AggregateRoot<T>
{
	public T Id { get; protected set; }
	public int Version { get; protected set; }

	private bool isIncremented;
	protected void IncrementVersion()
	{
		if(isIncremented) return;
		Version++;
		isIncremented = true;
	}
}
