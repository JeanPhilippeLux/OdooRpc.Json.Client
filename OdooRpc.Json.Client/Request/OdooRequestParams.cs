using Newtonsoft.Json;

namespace OdooRpc.Json.Client.Request
{
    public class OdooRequestParams
    {
        [JsonProperty("service")]
        public string Service { get; }

        [JsonProperty("method")]
        public string Method { get; }

        [JsonProperty("args")]
        public object[] Args { get; }

        [JsonIgnore]
        [JsonProperty("kwargs")]
        public object[] Kwargs { get; }


        [JsonIgnore]
        public string Url { get; }

        public OdooRequestParams(string url, string service, string method, params object[] paramethers)
        {
            Url = url;
            Service = service;
            Method = method;
            Args = PrepareParams(paramethers);
        }

        public OdooRequestParams(string url, string service, string method, object[] kwargsParameters, params object[] paramethers) : this(url, service, method, paramethers)
        {
            Kwargs = PrepareParams(kwargsParameters);
            Args = Args.Concat(Kwargs).ToArray();
        }



        protected object[] PrepareParams(object[] paramethers)
        {
            var list = paramethers.ToList();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] == null) list.RemoveAt(i);
                else break;
            }
            return list.ToArray();
        }
    }
}
