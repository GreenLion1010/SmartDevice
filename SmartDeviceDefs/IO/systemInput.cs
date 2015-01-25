using System;

namespace SmartDeviceDefs.IO
{
	public class systemInput
	{
		private bool _IsActive = false;

		public systemInput ()
		{
		}

		public bool IsActive {
			get {
				return _IsActive;
			}
			set {
				_IsActive = value;
			}
		}
	}
}

