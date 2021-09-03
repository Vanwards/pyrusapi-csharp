﻿using Newtonsoft.Json;

namespace PyrusApiClient
{
	public class Sms
	{
		[JsonProperty("phone_number")]
		public string PhoneNumber { get; set; }

		[JsonProperty("error_code")]
		public SendSmsError ErrorCode { get; set; }

		[JsonProperty("status")]
		public SendSmsStatus Status { get; set; }

		[JsonProperty("error_message")]
		public string ErrorMessage { get; set; }
	}
}
