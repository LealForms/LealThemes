﻿namespace LealThemes.Sample;

public static class Program
{
	[STAThread]
	public static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new MainForm());
	}
}