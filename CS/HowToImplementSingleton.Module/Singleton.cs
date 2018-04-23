using System;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.Xpo;

namespace HowToImplementSingleton.Module {
    public class Singleton : BaseObject {
        internal Singleton(Session session) : base(session) { }
        public static Singleton GetInstance(IObjectSpace objectSpace) {
			Singleton result = objectSpace.FindObject<Singleton>(null);
			if(result == null) {
				result = new Singleton(((XPObjectSpace)objectSpace).Session);
				result.Name = "My Singleton";
				result.Description = "Sample Description";
				result.Save();
			}
			return result;
		}
		private string name;
		public string Name {
			get { return name; }
			set {
				SetPropertyValue("Name", ref name, value);
			}
		}
		private string description;
		public string Description {
			get { return description; }
			set {
				SetPropertyValue("Description", ref description, value);
			}
		}
		protected override void OnDeleting() {
			throw new UserFriendlyException("This object cannot be deleted.");
		}
	}
}
