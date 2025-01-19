using System.Text.Json.Serialization;

namespace LealThemes;

/// <summary>
/// This class is used to store the colors and fonts of the theme.
/// You can create a new instance of this class and set the colors and fonts to create a new theme.
/// Or you can inherit this class to customize by yourself.
/// </summary>
public class Theme
{
	private Dictionary<Target, object>? _targets;

	/// <summary>
	/// Gets the dictionary of theme targets and their corresponding values.
	/// </summary>
	/// <value>
	/// A dictionary where the key is a <see cref="Target"/> enumeration value and the value is an object representing the theme setting for that target.
	/// </value>
	[JsonIgnore]
	public virtual Dictionary<Target, object> Targets => _targets ??= new()
	{
		{ Target.TitleFont, TitleFont },
		{ Target.NormalFont, NormalFont },
		{ Target.SecondaryFont, SecondaryFont },
		{ Target.AuxiliaryFont, AuxiliaryFont },
		{ Target.AuxiliaryFont1, AuxiliaryFont1 },
		{ Target.AuxiliaryFont2, AuxiliaryFont2 },
		{ Target.AuxiliaryFont3, AuxiliaryFont3 },
		{ Target.AuxiliaryFont4, AuxiliaryFont4 },

		{ Target.BackgroundColor, BackgroundColor },
		{ Target.SecondaryBackgroundColor, SecondaryBackgroundColor },
		{ Target.ForegroundColor, ForegroundColor },
		{ Target.SecondaryForegroundColor, SecondaryForegroundColor },
		{ Target.HighlightColor, HighlightColor },
		{ Target.AuxiliaryColor, AuxiliaryColor },
		{ Target.AuxiliaryColor1, AuxiliaryColor1 },
		{ Target.AuxiliaryColor2, AuxiliaryColor2 },
		{ Target.AuxiliaryColor3, AuxiliaryColor3 },
		{ Target.AuxiliaryColor4, AuxiliaryColor4 },
		{ Target.AuxiliaryColor5, AuxiliaryColor5 },
		{ Target.AuxiliaryColor6, AuxiliaryColor6 },
		{ Target.AuxiliaryColor7, AuxiliaryColor7 },
		{ Target.AuxiliaryColor8, AuxiliaryColor8 },
		{ Target.AuxiliaryColor9, AuxiliaryColor9 }
	};

	#region Fonts
	public Font TitleFont { get; set; } = new("Arial", 16, FontStyle.Regular);
	public Font NormalFont { get; set; } = new("Arial", 12, FontStyle.Regular);
	public Font SecondaryFont { get; set; } = new("Arial", 12, FontStyle.Regular);
	public Font AuxiliaryFont { get; set; } = new("Arial", 12, FontStyle.Regular);
	public Font AuxiliaryFont1 { get; set; } = new("Arial", 12, FontStyle.Regular);
	public Font AuxiliaryFont2 { get; set; } = new("Arial", 12, FontStyle.Regular);
	public Font AuxiliaryFont3 { get; set; } = new("Arial", 12, FontStyle.Regular);
	public Font AuxiliaryFont4 { get; set; } = new("Arial", 12, FontStyle.Regular);
	#endregion

	#region Colors
	public Color BackgroundColor { get; set; }
	public Color SecondaryBackgroundColor { get; set; }
	public Color ForegroundColor { get; set; }
	public Color SecondaryForegroundColor { get; set; }
	public Color HighlightColor { get; set; }
	public Color AuxiliaryColor { get; set; }
	public Color AuxiliaryColor1 { get; set; }
	public Color AuxiliaryColor2 { get; set; }
	public Color AuxiliaryColor3 { get; set; }
	public Color AuxiliaryColor4 { get; set; }
	public Color AuxiliaryColor5 { get; set; }
	public Color AuxiliaryColor6 { get; set; }
	public Color AuxiliaryColor7 { get; set; }
	public Color AuxiliaryColor8 { get; set; }
	public Color AuxiliaryColor9 { get; set; }
	#endregion
}