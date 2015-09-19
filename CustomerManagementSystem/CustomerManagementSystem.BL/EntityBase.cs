using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem.BL
{
	public enum EntityStateOption
	{
		Active, 
		Deleted
	}
	
	//an abstract class is intended only to be used as a base class
	//it cannot be instantiated, so you can't use the new keyword to create one
	public abstract class EntityBase
	{
		public bool IsNew { get; private set; }

		public bool HasChanges { get; set; }

		public bool EntityStateOption { get; set; }

		public bool IsValid
		{
			get { return Validate(); }
		}

		//virtual means the method can be overridable 
		//abstract means the method MUST be overwritten 
		public abstract bool Validate();
	}
}
