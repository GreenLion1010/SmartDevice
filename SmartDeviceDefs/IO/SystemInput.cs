using System;

namespace SmartDeviceDefs
{
	public class SystemInput
	{
		private bool _IsActive = false;

		public SystemInput ()
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

