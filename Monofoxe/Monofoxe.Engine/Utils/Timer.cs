﻿
namespace Monofoxe.Engine.Utils
{
	/// <summary>
	/// Counts seconds. Has to be updated manually.
	/// </summary>
	public class Timer
	{
		/// <summary>
		/// Tells how much time has passed in seconds.
		/// </summary>
		public virtual double Counter {get; protected set;} = 0;
		
		/// <summary>
		/// Timer won't update if it's disabled.
		/// </summary>
		public bool Enabled = true;

		public TimeKeeper TimeKeeper = TimeKeeper.Global;

		public Timer() {}
		public Timer(TimeKeeper timeKeeper) => 
			TimeKeeper = timeKeeper;
		
		
		/// <summary>
		/// Resets timer.
		/// </summary>
		public virtual void Reset()
		{
			Enabled = false;
			Counter = 0;
		}



		/// <summary>
		/// Updates timer.
		/// </summary>
		public virtual void Update()
		{
			if (Enabled)
			{
				Counter += TimeKeeper.Time();
			}
		}

	}
}
