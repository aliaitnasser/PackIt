using Shared.Abstractions.Exceptions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions;

public class InvalidTravelDaysException: PackItException
{
	public ushort Days { get; }
	public InvalidTravelDaysException(ushort days) : base($"Invald '{days}' value for travel days.")
	{
		Days = days;
	}
}
