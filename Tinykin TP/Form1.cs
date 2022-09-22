using Newtonsoft.Json;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace Tinykin_TP {
	public partial class Form1 : Form {
		[DllImport("user32.dll")]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, uint vlc);
		[DllImport("user32.dll")]
		private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		Mem mem = new Mem();
		Vector3? currentPosition = null;
		bool processIsOpen = false;

		bool isEditingItem = false;
		TPPositionEntry? currentEditingItem = null;
		int currentEditingIndex = -1;

		List<TPPositionEntry> tpPositionEntryList = new List<TPPositionEntry>();
		BindingSource bs = new BindingSource();
		ContextMenuStrip listboxContextMenu;

		string saveDir = Path.Combine(Environment.CurrentDirectory, "savedpositions.json");

		protected override void WndProc(ref Message msg) {
			if (msg.Msg == 0x0312) {
				int id = msg.WParam.ToInt32();

				if (id < 10)
					ActivateHotkey(id);
				else if (id >= 10)
					SetHotkey(id);
			}

			base.WndProc(ref msg);
		}

		private void SetHotkey(int id) {
			var idAdjusted = id - 10;
			var levelEntryCount = tpPositionEntryList.FindAll(i => i.Level == cbLevelSelect.Text).Count;
			var newTpEntry = new TPPositionEntry(currentPosition, $"Position {levelEntryCount}", idAdjusted, cbLevelSelect.Text);

			SaveNewPosition(newTpEntry);
			UpdateListBox();
		}

		private void ActivateHotkey(int id) {
			Debug.WriteLine($"Hotkey activated: {id}");

			if (tpPositionEntryList.Count <= 0)
				return;

			var tpEntry = tpPositionEntryList.FirstOrDefault(i => i.Level == cbLevelSelect.Text && i.HotKey == id);

			if (tpEntry != null)
				TeleportPlayer(tpEntry);
		}

		private void TeleportPlayer(TPPositionEntry tpEntry) {
			Debug.WriteLine($"X pos: {tpEntry.Position.X}");
			Debug.WriteLine($"Y pos: {tpEntry.Position.Y}");
			Debug.WriteLine($"Z pos: {tpEntry.Position.Z}");
			//("0.00", System.Globalization.CultureInfo.InvariantCulture)
			if (mem.WriteMemory(MemoryAddresses.X, "float", tpEntry.Position.X.ToString("##########.##########", System.Globalization.CultureInfo.InvariantCulture))) {
				Debug.WriteLine("X Write successful!");
			}

			if (mem.WriteMemory(MemoryAddresses.Y, "float", tpEntry.Position.Y.ToString("##########.##########", System.Globalization.CultureInfo.InvariantCulture))) {
				Debug.WriteLine("Y Write successful!");
			}

			if (mem.WriteMemory(MemoryAddresses.Z, "float", tpEntry.Position.Z.ToString("##########.##########", System.Globalization.CultureInfo.InvariantCulture))) {
				Debug.WriteLine("Z Write successful!");
			}
		}

		public Form1() {
			InitializeComponent();
		}

		private void ConnectToGame() {
			var pid = mem.GetProcIdFromName("Tinykin");

			Debug.WriteLine("pid: " + pid.ToString());

			if (pid > 0) {
				mem.OpenProcess(pid);
				processIsOpen = true;
				positionReadClock.Start();
				Debug.WriteLine("Process opened!");
			}
		}

		private void positionReadClock_Tick(object sender, EventArgs e) {
			if (processIsOpen)
				UpdatePositions();
		}

		private void UpdatePositions() {
			currentPosition = ReadPositions();

			if (isEditingItem) {
				lbHudX.ForeColor = Color.DarkGray;
				lbHudY.ForeColor = Color.DarkGray;
				lbHudZ.ForeColor = Color.DarkGray;

				lbHudX.Text = $"X: {currentEditingItem.Position.X}";
				lbHudY.Text = $"Y: {currentEditingItem.Position.Y}";
				lbHudZ.Text = $"Z: {currentEditingItem.Position.Z}";
			}
			else {
				lbHudX.ForeColor = Color.Crimson;
				lbHudY.ForeColor = Color.SeaGreen;
				lbHudZ.ForeColor = Color.DodgerBlue;

				lbHudX.Text = "X: " + Convert.ToString(currentPosition.X);
				lbHudY.Text = "Y: " + Convert.ToString(currentPosition.Y);
				lbHudZ.Text = "Z: " + Convert.ToString(currentPosition.Z);
			}
		}

		private Vector3 ReadPositions() {
			var x = mem.ReadFloat(MemoryAddresses.X, round: false);
			var y = mem.ReadFloat(MemoryAddresses.Y, round: false);
			var z = mem.ReadFloat(MemoryAddresses.Z, round: false);

			return new Vector3(x, y, z);
		}

		private void UpdateListBox() {
			var newEntryList = tpPositionEntryList.FindAll(i => i.Level == cbLevelSelect.Text);
			bs.DataSource = newEntryList;
			lstbPositions.DataSource = bs;
			bs.ResetBindings(false);
			lstbPositions.DisplayMember = "DisplayDescription";

			SavePositionsToFile();
		}

		private void Form1_Load(object sender, EventArgs e) {
			if (LoadPositionsFromFile()) {
				UpdateListBox();
			}

			bs.DataSource = tpPositionEntryList;
			cbLevelSelect.SelectedIndex = 0;

			listboxContextMenu = new ContextMenuStrip();
			listboxContextMenu.Opening += new CancelEventHandler(listboxContextMenu_Opening);
			lstbPositions.ContextMenuStrip = listboxContextMenu;
			
			InitHotkeys();
			connectToProcessClock.Start();
		}

		private void InitHotkeys() {
			RegisterHotKey(this.Handle, 0, 0x0000, '0');
			RegisterHotKey(this.Handle, 1, 0x0000, '1');
			RegisterHotKey(this.Handle, 2, 0x0000, '2');
			RegisterHotKey(this.Handle, 3, 0x0000, '3');
			RegisterHotKey(this.Handle, 4, 0x0000, '4');
			RegisterHotKey(this.Handle, 5, 0x0000, '5');
			RegisterHotKey(this.Handle, 6, 0x0000, '6');
			RegisterHotKey(this.Handle, 7, 0x0000, '7');
			RegisterHotKey(this.Handle, 8, 0x0000, '8');
			RegisterHotKey(this.Handle, 9, 0x0000, '9');

			RegisterHotKey(this.Handle, 10, 0x0002, '0');
			RegisterHotKey(this.Handle, 11, 0x0002, '1');
			RegisterHotKey(this.Handle, 12, 0x0002, '2');
			RegisterHotKey(this.Handle, 13, 0x0002, '3');
			RegisterHotKey(this.Handle, 14, 0x0002, '4');
			RegisterHotKey(this.Handle, 15, 0x0002, '5');
			RegisterHotKey(this.Handle, 16, 0x0002, '6');
			RegisterHotKey(this.Handle, 17, 0x0002, '7');
			RegisterHotKey(this.Handle, 18, 0x0002, '8');
			RegisterHotKey(this.Handle, 19, 0x0002, '9');
		}

		private void listboxContextMenu_Opening(object? sender, CancelEventArgs e) {
			if (lstbPositions.SelectedItem == null)
				return;

			listboxContextMenu.Items.Clear();
			listboxContextMenu.Items.Add(text: string.Format("Delete {0}", ((TPPositionEntry)(lstbPositions.SelectedItem)).Description), image: null, onClick: lstbItemDeleteOnClick);
			listboxContextMenu.Items.Add(text: string.Format("Edit {0}", ((TPPositionEntry)(lstbPositions.SelectedItem)).Description), image: null, onClick: lstbItemEditOnClick);
		}

		private void lstbItemEditOnClick(object? sender, EventArgs e) {
			btnCancelEdit.Visible = true;
			btnSave.Text = "Update Position";

			var item = (TPPositionEntry)lstbPositions.SelectedItem;
			var itemIndex = tpPositionEntryList.FindIndex(i => i == item && cbLevelSelect.Text == i.Level);

			tbDescription.Text = item.Description;
			numHotkey.Value = item.HotKey;

			currentEditingItem = item;
			currentEditingIndex = itemIndex;

			isEditingItem = true;
		}

		private void lstbItemDeleteOnClick(object? sender, EventArgs e) {
			var item = (TPPositionEntry)lstbPositions.SelectedItem;
			tpPositionEntryList.Remove(item);

			UpdateListBox();
		}

		//btnSave
		private void button1_Click(object sender, EventArgs e) {
			if (isEditingItem) {
				SaveNewPosition(updateExisting: true);

				isEditingItem = false;
				currentEditingIndex = -1;
				currentEditingItem = null;
			}
			else
				SaveNewPosition();

			UpdateListBox();
		}

		private void SaveNewPosition(TPPositionEntry? tpEntry = null, bool updateExisting = false) {
			if (tpEntry != null) {
				tpPositionEntryList.Add(tpEntry);
				return;
			}

			var pos = currentPosition;
			var hotkey = (int)numHotkey.Value;
			var level = cbLevelSelect.Text;
			var desc = tbDescription.Text;

			if (updateExisting) {
				var prevPos = currentEditingItem.Position;

				tpPositionEntryList[currentEditingIndex] = new TPPositionEntry(prevPos, desc, hotkey, level);
				btnCancelEdit.Visible = false;
				btnSave.Text = "Save Position";
			}
			else
				tpPositionEntryList.Add(new TPPositionEntry(pos, desc, hotkey, level));

			if (numHotkey.Value < 9)
				numHotkey.Value++;

			tbDescription.Text = $"Position {numHotkey.Value}";
		}

		private void SavePositionsToFile() {
			using (StreamWriter file = File.CreateText(saveDir)) {
				JsonSerializer serializer = new JsonSerializer();
				serializer.Serialize(file, tpPositionEntryList);
			}
		}

		private bool LoadPositionsFromFile() {
			if (!File.Exists(saveDir))
				return false;

			string json = File.ReadAllText(saveDir);
			tpPositionEntryList = JsonConvert.DeserializeObject<List<TPPositionEntry>>(json);

			if (tpPositionEntryList != null && tpPositionEntryList.Count > 0)
				return true;
			else
				return false;
		}

		private void cbLevelSelect_SelectedIndexChanged(object sender, EventArgs e) {
			listboxContextMenu?.Items.Clear();
			UpdateListBox();
		}

		private void lstbPositions_MouseDown(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) {
				//select the item under the mouse pointer
				lstbPositions.SelectedIndex = lstbPositions.IndexFromPoint(e.Location);
				if (lstbPositions.SelectedIndex != -1) {
					listboxContextMenu.Show();
				}
			}
		}

		private void connectToProcessClock_Tick(object sender, EventArgs e) {
			if (processIsOpen) {
				connectToProcessClock.Stop();
				return;
			}

			ConnectToGame();
		}

		private void btnCancelEdit_Click(object sender, EventArgs e) {
			isEditingItem = false;
			currentEditingIndex = -1;
			currentEditingItem = null;
			btnCancelEdit.Visible = false;
			btnSave.Text = "Save Position";
			tbDescription.Text = $"Position {numHotkey.Value}";
		}

		private void chbFreezeX_CheckedChanged(object sender, EventArgs e) {
			if (processIsOpen) {
				if (chbFreezeX.Checked)
					mem.FreezeValue(MemoryAddresses.X, "float", currentPosition?.X.ToString("##########.##########", System.Globalization.CultureInfo.InvariantCulture));
				else
					mem.UnfreezeValue(MemoryAddresses.X);
			}
		}

		private void chbFreezeY_CheckedChanged(object sender, EventArgs e) {
			if (processIsOpen) {
				if (chbFreezeY.Checked)
					mem.FreezeValue(MemoryAddresses.Y, "float", currentPosition?.Y.ToString("##########.##########", System.Globalization.CultureInfo.InvariantCulture));
				else
					mem.UnfreezeValue(MemoryAddresses.Y);
			}
		}

		private void chbFreezeZ_CheckedChanged(object sender, EventArgs e) {
			if (processIsOpen) {
				if (chbFreezeZ.Checked)
					mem.FreezeValue(MemoryAddresses.Z, "float", currentPosition?.Z.ToString("##########.##########", System.Globalization.CultureInfo.InvariantCulture));
				else
					mem.UnfreezeValue(MemoryAddresses.Z);
			}
		}
	}
}