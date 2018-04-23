using DevExpress.ExpressApp.DC;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

namespace HowToImplementSingleton.Module {
	public partial class ShowSingletonController : ViewController {
		public ShowSingletonController() {
			InitializeComponent();
			RegisterActions(components);
		}
		private void popupWindowShowAction1_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e) {
			IObjectSpace objectSpace = Application.CreateObjectSpace();
			e.View = Application.CreateDetailView(objectSpace, Singleton.GetInstance(((ObjectSpace)objectSpace).Session));
		}
	}
}
