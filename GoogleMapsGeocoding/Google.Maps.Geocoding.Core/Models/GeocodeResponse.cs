﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Xml.Serialization;

using Newtonsoft.Json;

namespace GoogleMapsGeocoding.Common
{
#if !PORTABLE
    [Serializable]
#endif
    [XmlRoot(ElementName = "GeocodeResponse", IsNullable = false)]
    public class GeocodeResponse
    {
        [JsonProperty("results")]
        [XmlElement("result")]
        public Result[] Results { get; set; }

        [JsonProperty("status")]
        [XmlElement("status")]
        public string Status { get; set; }
    }
}