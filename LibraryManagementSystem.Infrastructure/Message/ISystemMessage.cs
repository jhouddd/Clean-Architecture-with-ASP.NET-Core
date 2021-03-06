﻿using System;

namespace LibraryManagementSystem.Infrastructure.Message
{
	public interface ISystemMessage
	{
		Guid id { get; set; }
		string Title { get; set; }
		string Body { get; set; }
		string MessageType { get; set; }
	}
}
