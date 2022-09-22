using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinykin_TP {
	internal class TPPositionEntry {
		public Vector3 Position { get; set; }
		public string Description { get; set; }
		public string DisplayDescription { get; set; }
		public int HotKey { get; set; }
		public string Level { get; set; }

		public TPPositionEntry(Vector3 position, string description, int hotkey, string level) {
			Position = position;
			HotKey = hotkey;
			Level = level;
			Description = description;
			DisplayDescription = $"{description} (Key: {hotkey})";
		}
	}
}
