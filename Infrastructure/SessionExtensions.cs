using Newtonsoft.Json;

namespace ShoppingCart.Infrastructure
{
	public static class SessionExtensions
	{
		public static void SetJson<T>(this ISession session ,string key, T val)
		{
			session.SetString(key, JsonConvert.SerializeObject(val));
		} 

		public static T GetJson<T>(this ISession session ,string key)
		{
			var sessionData = session.GetString(key);
			return sessionData == null ? default : JsonConvert.DeserializeObject<T>(sessionData);
		}
	}
}
