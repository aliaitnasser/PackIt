using Domain.Consts;

using Shared.Abstractions.Commands;

namespace Application.Commands;

public record CreateItemListWithItems(Guid Id, string Name, LocalizationWriteModel Localization, ushort Days, Gender Gender)
	: ICommand;

public record LocalizationWriteModel(string City, string Country);
