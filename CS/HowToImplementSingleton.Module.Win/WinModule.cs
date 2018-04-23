using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace HowToImplementSingleton.Module.Win {
	[ToolboxItemFilter("Xaf.Platform.Win")]
	public sealed partial class HowToImplementSingletonWindowsFormsModule : ModuleBase {
		public HowToImplementSingletonWindowsFormsModule() {
			InitializeComponent();
		}
	}
}
