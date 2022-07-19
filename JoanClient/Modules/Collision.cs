using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VRC.SDKBase;

namespace ForbiddenClient.Modules
{
	internal class CollisionUwU : MonoBehaviour
	{
		public CollisionUwU(IntPtr ptr) : base(ptr) { }

		private void OnCollisionEnter(Collision col)
		{
			Utils.ConsoleLog(Utils.ConsoleLogType.Msg, "Collided");
		}

	}
}
