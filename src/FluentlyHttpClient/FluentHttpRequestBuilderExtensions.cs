using System;
using System.Net.Http;

namespace FluentlyHttpClient
{
	/// <summary>
	/// Fluent Http Request builder extensions.
	/// </summary>
	public static class FluentHttpRequestBuilderExtensions
	{
		private static readonly HttpMethod HttpMethodPatch = new HttpMethod("Patch");
		#region HttpMethods

		/// <summary>
		/// Set request method as <c>Get</c>.
		/// </summary>
		/// <returns>Returns request builder for chaining.</returns>
		public static FluentHttpRequestBuilder AsGet(this FluentHttpRequestBuilder builder) => builder.WithMethod(HttpMethod.Get);

		/// <summary>
		/// Set request method as <c>Post</c>.
		/// </summary>
		/// <returns>Returns request builder for chaining.</returns>
		public static FluentHttpRequestBuilder AsPost(this FluentHttpRequestBuilder builder) => builder.WithMethod(HttpMethod.Post);

		/// <summary>
		/// Set request method as <c>Put</c>.
		/// </summary>
		/// <returns>Returns request builder for chaining.</returns>
		public static FluentHttpRequestBuilder AsPut(this FluentHttpRequestBuilder builder) => builder.WithMethod(HttpMethod.Put);

		/// <summary>
		/// Set request method as <c>Delete</c>.
		/// </summary>
		/// <returns>Returns request builder for chaining.</returns>
		public static FluentHttpRequestBuilder AsDelete(this FluentHttpRequestBuilder builder) => builder.WithMethod(HttpMethod.Delete);

		/// <summary>
		/// Set request method as <c>Options</c>.
		/// </summary>
		/// <returns>Returns request builder for chaining.</returns>
		public static FluentHttpRequestBuilder AsOptions(this FluentHttpRequestBuilder builder) => builder.WithMethod(HttpMethod.Options);

		/// <summary>
		/// Set request method as <c>Head</c>.
		/// </summary>
		/// <returns>Returns request builder for chaining.</returns>
		public static FluentHttpRequestBuilder AsHead(this FluentHttpRequestBuilder builder) => builder.WithMethod(HttpMethod.Head);

		/// <summary>
		/// Set request method as <c>Trace</c>.
		/// </summary>
		/// <returns>Returns request builder for chaining.</returns>
		public static FluentHttpRequestBuilder AsTrace(this FluentHttpRequestBuilder builder) => builder.WithMethod(HttpMethod.Trace);

		/// <summary>
		/// Set request method as <c>Patch</c>.
		/// </summary>
		/// <returns>Returns request builder for chaining.</returns>
		public static FluentHttpRequestBuilder AsPatch(this FluentHttpRequestBuilder builder) => builder.WithMethod(HttpMethodPatch);

		#endregion

		/// <summary>
		/// Add bearer authentication.
		/// </summary>
		/// <param name="builder">builder instance.</param>
		/// <param name="token">Auth token to add.</param>
		/// <returns>Returns request builder for chaining.</returns>
		public static FluentHttpRequestBuilder WithBearerAuthentication(this FluentHttpRequestBuilder builder, string token)
		{
			if (string.IsNullOrEmpty(token)) throw new ArgumentNullException(nameof(token));
			builder.WithHeader("Authorization", $"Bearer {token}");
			return builder;
		}

	}
}