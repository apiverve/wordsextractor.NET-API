using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("partofspeech")]
    public string partofspeech { get; set; }

    [JsonProperty("result")]
    public string[] result { get; set; }

    [JsonProperty("count")]
    public int count { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
