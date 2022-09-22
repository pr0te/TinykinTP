/*
 *  Hacked together in a hurry by pr0te
 *  22-09-22
 */

global using Memory;

namespace Tinykin_TP {
	internal static class Program {
		[STAThread]
		static void Main() {
			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}
	}
}