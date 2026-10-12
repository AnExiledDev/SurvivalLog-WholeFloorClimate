namespace WholeFloorClimate.Core;

/// <summary>Which zones share the house's device heat with Indoor. Cold storage has no switch: it never joins.</summary>
public sealed record PoolSettings(bool IndoorAndSunroom, bool Terrace, bool Basement)
{
    /// <summary>The design: Indoor and Sunroom share, Terrace and Basement keep the game's rules.</summary>
    public static PoolSettings Default { get; } = new(IndoorAndSunroom: true, Terrace: false, Basement: false);
}
