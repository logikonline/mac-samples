// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Rulers {
	
	
	// Should subclass MonoMac.AppKit.NSResponder
	[Foundation.Register("AppDelegate")]
	public partial class AppDelegate {
	}
	
	// Should subclass MonoMac.Foundation.NSObject
	[Foundation.Register("FirstResponder")]
	public partial class FirstResponder {
		
		#pragma warning disable 0169
		[Foundation.Export("lockSelectedItem:")]
		partial void lockSelectedItem (Foundation.NSObject sender);

		[Foundation.Export("nestle:")]
		partial void nestle (Foundation.NSObject sender);

		[Foundation.Export("zoomIn:")]
		partial void zoomIn (Foundation.NSObject sender);

		[Foundation.Export("zoomOut:")]
		partial void zoomOut (Foundation.NSObject sender);
}
}
