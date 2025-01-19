namespace LealThemes;

/// <summary>
/// Represents a rule style to apply a theme.
/// </summary>
public readonly struct RuleStyle
{
	/// <summary>
	/// The property name to apply the target value.
	/// </summary>
	public readonly string PropertyName { get; init; }
	
	/// <summary>
	/// The target to apply the value.
	/// </summary>
	public readonly Target Target { get; init; }
}