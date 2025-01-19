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
		};
		Controls.Add(labelText); // Add the label to the form
		
		// Create a new theme
		var theme = new Theme() 
		{
			BackgroundColor = Color.FromArgb(0, 0, 0),
			ForegroundColor = Color.FromArgb(255, 255, 255),
			TitleFont = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0)
		};
		
		// Define the rules to apply the theme
		var rules = new Dictionary<Control, List<RuleStyle>>()
		{
			{ this, 
			[
				new() { PropertyName = nameof(BackColor), Target = Target.BackgroundColor },
			]},
			{ labelText, 
			[
				new() { PropertyName = nameof(labelText.ForeColor), Target = Target.ForegroundColor },
				new() { PropertyName = nameof(labelText.Font), Target = Target.TitleFont },
			]}
		};
		
		var themeController = new ThemeController(theme);
		themeController.Apply(rules);
	}
}