namespace HowToImplementSingleton.Module {
	partial class ShowSingletonController {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.popupWindowShowAction1 = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);
			// 
			// popupWindowShowAction1
			// 
			this.popupWindowShowAction1.AcceptButtonCaption = null;
			this.popupWindowShowAction1.CancelButtonCaption = null;
			this.popupWindowShowAction1.Caption = "Show Singleton";
			this.popupWindowShowAction1.Id = "566d5031-9ce4-4d6c-9841-843a2c59a548";
			this.popupWindowShowAction1.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.popupWindowShowAction1_CustomizePopupWindowParams);

		}

		#endregion

		private DevExpress.ExpressApp.Actions.PopupWindowShowAction popupWindowShowAction1;

	}
}
