using Domain.ValueObjects;

namespace Domain.Policies;

public record PolicyData(TravelDays Days, Consts.Gender Gender, ValueObjects.Temperature Temperature, Localization Localization);
