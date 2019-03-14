﻿using System.Collections.Generic;
using FluentlyHttpClient;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;

namespace FluentHttpClient.Entity
{
	//public class FluentHttpHeadersConverter : ValueConverter<FluentHttpHeaders, string>
	//{
	//	private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings();

	//	public FluentHttpHeadersConverter(ConverterMappingHints hints = default) :
	//		base
	//			(x => JsonConvert.SerializeObject(x, Settings),
	//			x => new FluentHttpHeaders(JsonConvert.DeserializeObject<Dictionary<string, string[]>>(x, Settings))
	//			, hints
	//			)
	//	{ }
	//}

	public static class FluentHttpHeadersConversion
	{
		private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings();

		public static ValueConverter<FluentHttpHeaders, string> Convert = new ValueConverter<FluentHttpHeaders, string>(
			x => JsonConvert.SerializeObject(x),
			x => new FluentHttpHeaders(JsonConvert.DeserializeObject<Dictionary<string, string[]>>(x, Settings)));
	}
}