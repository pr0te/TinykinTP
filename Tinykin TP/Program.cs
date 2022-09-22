global using Memory;

namespace Tinykin_TP {
	internal static class Program {
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}
	}
}