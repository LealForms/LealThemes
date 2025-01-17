namespace LealThemes;

/// <summary>
/// This class is used to store the colors of the theme.
/// You can create a new instance of this class and set the colors to create a new theme.
/// Or you can inherit this class to customize the colors of the theme.
/// </summary>
public class Theme
{
	private Dictionary<ThemeTarget, object>? _targets;

	public Dictionary<ThemeTarget, object> Targets
	{
		get => _targets ??= new Dictionary<ThemeTarget, object>
		{
			{ ThemeTarget.BackgroundColor, BackgroundColor },
			{ ThemeTarget.ForegroundColor, ForegroundColor },
			{ ThemeTarget.AccentColor, AccentColor },
			{ ThemeTarget.AccentForegroundColor, AccentForegroundColor },
			{ ThemeTarget.SeparatorColor, SeparatorColor },
			{ ThemeTarget.ButtonBackgroundColor, ButtonBackgroundColor },
			{ ThemeTarget.ButtonForegroundColor, ButtonForegroundColor },
			{ ThemeTarget.ButtonHoverColor, ButtonHoverColor },
			{ ThemeTarget.ButtonPressedColor, ButtonPressedColor },
			{ ThemeTarget.Button2BackgroundColor, Button2BackgroundColor },
			{ ThemeTarget.Button2ForegroundColor, Button2ForegroundColor },
			{ ThemeTarget.Button2HoverColor, Button2HoverColor },
			{ ThemeTarget.Button2PressedColor, Button2PressedColor },
			{ ThemeTarget.TextBoxBackgroundColor, TextBoxBackgroundColor },
			{ ThemeTarget.TextBoxForegroundColor, TextBoxForegroundColor },
			{ ThemeTarget.TextBox2BackgroundColor, TextBox2BackgroundColor },
			{ ThemeTarget.TextBox2ForegroundColor, TextBox2ForegroundColor }
		};
	}

	// Main colors
	public Color BackgroundColor { get; set; }
	public Color ForegroundColor { get; set; }

	// Accent colors
	public Color AccentColor { get; set; }
	public Color AccentForegroundColor { get; set; }

	// Separator colors
	public Color SeparatorColor { get; set; }

	// Buttons colors
	public Color ButtonBackgroundColor { get; set; }
	public Color ButtonForegroundColor { get; set; }
	public Color ButtonHoverColor { get; set; }
	public Color ButtonPressedColor { get; set; }

	// Buttons colors 2
	public Color Button2BackgroundColor { get; set; }
	public Color Button2ForegroundColor { get; set; }
	public Color Button2HoverColor { get; set; }
	public Color Button2PressedColor { get; set; }

	// Textbox colors
	public Color TextBoxBackgroundColor { get; set; }
	public Color TextBoxForegroundColor { get; set; }

	// Textbox colors 2
	public Color TextBox2BackgroundColor { get; set; }
	public Color TextBox2ForegroundColor { get; set; }
}