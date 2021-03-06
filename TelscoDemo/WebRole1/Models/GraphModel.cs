﻿using Microsoft.Azure.Insights.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebRole1.Models
{
    public static class RandomExtensions
    {
        public static double NextDouble(this Random RandGenerator, double MinValue, double MaxValue)
        {
            return Math.Round(RandGenerator.NextDouble() * (MaxValue - MinValue) + MinValue, 2);
        }
    }

    public class GraphModel
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }

        [JsonProperty(PropertyName = "telemetryvolume")]
        public MetricListResponse telemetryvolume { get; set; }

        [JsonProperty(PropertyName = "noofincidents")]
        public long noofincidents { get; set; }

        [JsonProperty(PropertyName = "activeincidentsovertime")]
        public long activeincidentsovertime { get; set; }

        [JsonProperty(PropertyName = "maxtimetomitigateincidents")]
        public long maxtimetomitigateincidents { get; set; }

        [JsonProperty(PropertyName = "percentageoftimethesystemviolated")]
        public long percentageoftimethesystemviolated { get; set; }

        [JsonProperty(PropertyName = "activeusers")]
        public double activeusers { get; set; }

        [JsonProperty(PropertyName = "traficrequest")]
        public double traficrequest { get; set; }
        
    }
}