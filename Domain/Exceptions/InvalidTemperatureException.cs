using Shared.Abstractions.Exceptions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions;

public class InvalidTemperatureException: PackItException
{
	public double Temperature { get; }

	public InvalidTemperatureException(double temperature) : base($"Invalid value '{temperature}' for temperature")
	{
		Temperature = temperature;
	}
}
