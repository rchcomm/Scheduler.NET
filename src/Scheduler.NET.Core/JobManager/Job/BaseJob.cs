﻿using Jil;
using System.ComponentModel.DataAnnotations;

namespace Scheduler.NET.Core.JobManager.Job
{
	public abstract class BaseJob : IJob
	{
		[Required]
		[StringLength(100)]
		public virtual string Name { get; set; }

		[Required]
		[StringLength(20)]
		public virtual string Cron { get; set; }

		[StringLength(500)]
		public virtual string Data { get; set; }

		public override string ToString()
		{
			return JSON.Serialize(this);
		}
	}
}
