﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using Newtonsoft.Json;
using System;
using System.Globalization;
using System.Xml.Serialization;

namespace GoogleMapsGeocoding.Common
{
#if !PORTABLE
    [Serializable]
#endif
    public class Bounds
    {
        /// <summary>
        /// Chack if it has valid bounds.
        /// </summary>
        public bool HasBounds
        {
            get
            {
                return (Northeast != null) && (Northeast.Lat != 0) && (Northeast.Lng != 0) &&
                    (Southwest != null) && (Southwest.Lat != 0) && (Southwest.Lng != 0);
            }
        }

        /// <summary>
        /// Northeast coordinate.
        /// </summary>
        [JsonProperty("northeast")]
        [XmlElement("northeast")]
        public Northeast Northeast { get; set; }

        /// <summary>
        /// Southwest coordinate.
        /// </summary>
        [JsonProperty("southwest")]
        [XmlElement("southwest")]
        public Southwest Southwest { get; set; }

        /// <summary>
        /// Returns the bound in query string format.
        /// Example: 34.172684,-118.604794|34.236144,-118.500938
        /// </summary>
        /// <returns>String to use as value in the query string.</returns>
        public string ToQueryString()
        {
            string queryString = string.Empty;

            if (HasBounds)
            {
                queryString = string.Format(
                    "{0},{1}|{2},{3}",
                    Southwest.Lat.ToString(CultureInfo.InvariantCulture),
                    Southwest.Lng.ToString(CultureInfo.InvariantCulture),
                    Northeast.Lat.ToString(CultureInfo.InvariantCulture),
                    Northeast.Lng.ToString(CultureInfo.InvariantCulture)
                    );
            }

            return queryString;
        }
    }
}