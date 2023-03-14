using Shared.Abstractions.Exceptions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions;

public class PackingItemQuantityZeroException: PackItException
{
	public PackingItemQuantityZeroException() : base("Packing item quantity can not be 0.") { }
}
