using Domain.Exceptions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects;

public record PackingListName
{
	public string Value { get; }

	public PackingListName(string value)
	{
		if (string.IsNullOrEmpty(value)) throw new EmptyPackingListNameException();
		Value = value;
	}

	// Implicit conversion from string to PackingListName
	public static implicit operator string(PackingListName name) => name.Value;
	// Implicit conversion from PackingListName to string
	public static implicit operator PackingListName(string name) => new(name);
}
