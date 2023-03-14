using Shared.Abstractions.Exceptions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions;

public class EmptyPackingItemNameException: PackItException
{
	public EmptyPackingItemNameException() : base("Paking item name can not be empty.") {}
}
