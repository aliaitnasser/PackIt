using Shared.Abstractions.Exceptions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions;

public class PackingItemNotFoundException: PackItException
{
    public string ItemName { get; }     
    public PackingItemNotFoundException(string itemName) : base($"Packing item {itemName} not found.") 
        => ItemName = itemName;
}
