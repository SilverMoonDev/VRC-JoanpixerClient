using System;

namespace JoanButtonAPI.Misc
{
    internal class PriorityAttribute : Attribute
	{
		public readonly int priority;

		public PriorityAttribute(int priority)
		{
			this.priority = priority;
		}
	}
}
