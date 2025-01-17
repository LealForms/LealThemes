namespace LealThemes.Sample;

public sealed class MainForm : Form
{
	public MainForm()
	{
		InitializeComponent();
	}

	private void InitializeComponent()
	{
		var labelText = new Label()
		{
			Text = "Hello, World!",
			Dock = DockStyle.Fill,
			AutoSize = false,
			TextAlign = ContentAlignment.MiddleCenter,
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
		};
		Controls.Add(labelText); // Add the label to the form
		
		// Create a new theme
		var theme = new Theme() 
		{
			BackgroundColor = Color.FromArgb(0, 0, 0),
			ForegroundColor = Color.FromArgb(255, 255, 255),
		};
		
		// Define the rules to apply the theme
		var rules = new Dictionary<Control, List<RuleStyle>>()
		{
			{ this, [
				new() { PropertyName = nameof(BackColor), Target = ThemeTarget.BackgroundColor },
				new() { PropertyName = nameof(ForeColor), Target = ThemeTarget.ForegroundColor },
			]},
			{ labelText, [
				new() { PropertyName = nameof(BackColor), Target = ThemeTarget.BackgroundColor },
				new() { PropertyName = nameof(ForeColor), Target = ThemeTarget.ForegroundColor },
			]}
		};
		
		var themeController = new ThemeController(theme);
		themeController.Apply(rules);
	}
}