﻿using Domain.Exceptions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects;

public record Localization(string City, string Country)
{
	public static Localization Create(string value)
	{
		var splitLocalisation = value.Split(',');

		if (splitLocalisation.Length != 2) throw new InvalidLocalizationException();

		return new Localization(splitLocalisation.First(), splitLocalisation.Last());
	}

	public override string ToString() => $"{City} {Country}";
}
