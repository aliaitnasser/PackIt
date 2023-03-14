using Shared.Abstractions.Exceptions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions;

public class InvalidLocalizationException: PackItException
{
	public InvalidLocalizationException() : base("Localization has to be a city and a country") {}
}
