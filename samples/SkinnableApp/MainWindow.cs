
using System;
using MonoMac.Foundation;
using MonoMac.AppKit;

namespace SkinnableApp {
	
	public partial class MainWindow : NSWindow {
		// Called when created from unmanaged code
		public MainWindow (IntPtr handle) : base(handle) {}

		// Called when created directly from a XIB file
		[Export("initWithCoder:")]
		public MainWindow (NSCoder coder) : base(coder) {}
	}
}

