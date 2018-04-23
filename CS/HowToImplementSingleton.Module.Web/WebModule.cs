using System;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace HowToImplementSingleton.Module.Web {
	[ToolboxItemFilter("Xaf.Platform.Web")]
	public sealed partial class HowToImplementSingletonAspNetModule : ModuleBase {
		public HowToImplementSingletonAspNetModule() {
			InitializeComponent();
		}
	}
}
