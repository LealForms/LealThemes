using System.Reflection;

namespace LealThemes;

/// <summary>
/// Represents a controller to apply a theme to controls.
/// </summary>
public class ThemeController
{
	/// <summary>
	/// Initialize a new instance of <see cref="ThemeController"/>.
	/// </summary>
	/// <param name="theme">
	/// The theme to apply.
	/// </param>
	public ThemeController(Theme theme)
	{
		Theme = theme;
	}

	/// <summary>
	/// The theme to apply.
	/// </summary>
	public Theme Theme { get; private set; }

	/// <summary>
	/// Set new theme.
	/// </summary>
	/// <param name="theme">
	/// The new theme to apply.
	/// </param>
	/// <returns>
	/// The current instance of <see cref="ThemeController"/>.
	/// </returns>
	public ThemeController SetTheme(Theme theme)
	{
		Theme = theme;
		return this;
	}

	/// <summary>
	/// Apply the theme to the controls.
	/// </summary>
	/// <param name="controlRules">
	/// The control rules to apply the theme.
	/// </param>
	/// <returns>
	/// The current instance of <see cref="ThemeController"/>.
	/// </returns>
	/// <exception cref="ArgumentNullException">
	/// Thrown when the property not found in the control.
	/// </exception>
	/// <exception cref="ArgumentException">
	///  Thrown when the target not found in the theme.
	/// </exception>
	public ThemeController Apply(Dictionary<Control, List<RuleStyle>> controlRules)
	{
		foreach (var rule in controlRules)
		{
			var type = rule.Key.GetType();

			foreach (var ruleStyles in rule.Value)
			{
				var property = type.GetProperty(ruleStyles.PropertyName, BindingFlags.Instance | BindingFlags.Public)
					?? throw new ArgumentNullException($"Property {ruleStyles.PropertyName} not found in {type.Name}");

				property.SetValue(rule.Key, GetValueByTarget(ruleStyles.Target));
			}
		}

		return this;
	}
	
	private object GetValueByTarget(ThemeTarget target)
		=> Theme.Targets.TryGetValue(target, out var color) ? color : throw new ArgumentException($"Target {target} not found in theme");
}