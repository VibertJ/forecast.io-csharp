﻿using Forecast.io.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ForecastIO
{
    [DataContractAttribute, Serializable]
    public class ForecastIOReponse
    {
        [DataMember]
        public float latitude { get; set; }
        [DataMember]
        public float longitude { get; set; }
        [DataMember]
        public string timezone { get; set; }
        [DataMember]
        public Int64 offset { get; set; }
        [DataMember]
        public Currently currently { get; set; }
        [DataMember]
        public Minutely minutely { get; set; }
        [DataMember]
        public Hourly hourly { get; set; }
        [DataMember]
        public Daily daily { get; set; }
        [DataMember]
        public List<Alert> alerts { get; set; }
        [DataMember]
        public Flags flags { get; set; }

        [DataContract, Serializable]
        public class Currently
        {
            [DataMember]
            [JsonConverter(typeof(UnixDateTimeConverter))]
            public DateTime time { get; set; }
            [DataMember]
            public string summary { get; set; }
            [DataMember]
            public string icon { get; set; }
            [DataMember]
            public float precipIntensity { get; set; }
            [DataMember]
            public float precipProbability { get; set; }
            [DataMember]
            public float temperature { get; set; }
            [DataMember]
            public float dewPoint { get; set; }
            [DataMember]
            public float windSpeed { get; set; }
            [DataMember]
            public float windBearing { get; set; }
            [DataMember]
            public float cloudCover { get; set; }
            [DataMember]
            public float humidity { get; set; }
            [DataMember]
            public float pressure { get; set; }
            [DataMember]
            public float visibility { get; set; }
            [DataMember]
            public float ozone { get; set; }
        }

        [DataContract, Serializable]
        public class MinuteForecast
        {
            [DataMember]
            [JsonConverter(typeof(UnixDateTimeConverter))]
            public DateTime time { get; set; }
            [DataMember]
            public float precipIntensity { get; set; }
        }

        [DataContract, Serializable]
        public class Minutely
        {
            [DataMember]
            public string summary { get; set; }
            [DataMember]
            public string icon { get; set; }
            [DataMember]
            public List<MinuteForecast> data { get; set; }
        }

        [DataContract, Serializable]
        public class HourForecast
        {
            [DataMember]
            [JsonConverter(typeof(UnixDateTimeConverter))]
            public DateTime time { get; set; }
            [DataMember]
            public string summary { get; set; }
            [DataMember]
            public string icon { get; set; }
            [DataMember]
            public float precipIntensity { get; set; }
            [DataMember]
            public float temperature { get; set; }
            [DataMember]
            public float dewPoint { get; set; }
            [DataMember]
            public float windSpeed { get; set; }
            [DataMember]
            public float windBearing { get; set; }
            [DataMember]
            public float cloudCover { get; set; }
            [DataMember]
            public float humidity { get; set; }
            [DataMember]
            public float pressure { get; set; }
            [DataMember]
            public float visibility { get; set; }
            [DataMember]
            public float ozone { get; set; }
        }

        [DataContract, Serializable]
        public class Hourly
        {
            [DataMember]
            public string summary { get; set; }
            [DataMember]
            public string icon { get; set; }
            [DataMember]
            public List<HourForecast> data { get; set; }
        }

        [DataContract, Serializable]
        public class DailyForecast
        {
            [DataMember]
            [JsonConverter(typeof(UnixDateTimeConverter))]
            public DateTime time { get; set; }
            [DataMember]
            public string summary { get; set; }
            [DataMember]
            public string icon { get; set; }
            [DataMember]
            [JsonConverter(typeof(UnixDateTimeConverter))]
            public DateTime sunriseTime { get; set; }
            [DataMember]
            [JsonConverter(typeof(UnixDateTimeConverter))]
            public DateTime sunsetTime { get; set; }
            [DataMember]
            public float precipIntensity { get; set; }
            [DataMember]
            public float precipIntensityMax { get; set; }
            [DataMember]
            public float precipProbability { get; set; }
            [DataMember]
            public float temperatureMin { get; set; }
            [DataMember]
            [JsonConverter(typeof(UnixDateTimeConverter))]
            public DateTime temperatureMinTime { get; set; }
            [DataMember]
            public float temperatureMax { get; set; }
            [DataMember]
            [JsonConverter(typeof(UnixDateTimeConverter))]
            public DateTime temperatureMaxTime { get; set; }
            [DataMember]
            public float dewPoint64 { get; set; }
            [DataMember]
            public float windSpeed { get; set; }
            [DataMember]
            public float windBearing { get; set; }
            [DataMember]
            public float cloudCover { get; set; }
            [DataMember]
            public float humidity { get; set; }
            [DataMember]
            public float pressure { get; set; }
            [DataMember]
            public float visibility { get; set; }
            [DataMember]
            public float ozone { get; set; }
        }

        [DataContract, Serializable]
        public class Daily
        {
            [DataMember]
            public string summary { get; set; }
            [DataMember]
            public string icon { get; set; }
            [DataMember]
            public List<DailyForecast> data { get; set; }
        }

        [DataContract, Serializable]
        public class Alert
        {
            [DataMember]
            public string title { get; set; }
            [DataMember]
            [JsonConverter(typeof(UnixDateTimeConverter))]
            public DateTime expires { get; set; }
            [DataMember]
            public string uri { get; set; }
        }

        [DataContract, Serializable]
        public class Flags
        {
            [DataMember]
            public List<string> sources { get; set; }
            [DataMember]
            public List<string> isd_stations { get; set; }
            [DataMember]
            public List<string> lamp_stations { get; set; }
            [DataMember]
            public List<string> metar_stations { get; set; }
            [DataMember]
            public List<string> darksky_stations { get; set; }
            [DataMember]
            public string units { get; set; }
        }
    }
}
