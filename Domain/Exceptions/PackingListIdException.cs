using Shared.Abstractions.Exceptions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions;

public class PackingListIdException: PackItException
{
	public PackingListIdException() : base("Packing list ID can not be empty.") {}
}
