using System;

using DevExpress.Xpo;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace HowToImplementSingleton.Module {
	[DefaultClassOptions]
	public class Singleton : BaseObject {
		protected internal Singleton(Session session) : base(session) {
		}
		public static Singleton GetInstance(Session session) {
			//Get the Singleton's instance if it exists
			Singleton result = session.FindObject<Singleton>(null);
			//Create the Singleton's instance
			if(result == null) {
				result = new Singleton(session);
				result.Name = "My Singleton";
				result.Description = "Empty";
				result.Save();
			}
			return result;
		}
		private string name;
		public string Name {
			get {
				return name;
			}
			set {
				SetPropertyValue("Name", ref name, value);
			}
		}
		private string description;
		public string Description {
			get {
				return description;
			}
			set {
				SetPropertyValue("Description", ref description, value);
			}
		}
		//Prevent the Singleton from being deleted
		protected override void OnDeleting() {
			throw new Exception("Cannot be deleted");
		}
	}
}
