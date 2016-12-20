﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIA.Model
{
    public class carRecall
    {
        public string Count { get; set; }
        public string Message { get; set; }
        public List<recallResults> Results { get; set; }
    }

    public class recallResults
    {
        public string Manufacturer { get; set; }
        public string NHTSACampaignNumber { get; set; }
        public string ReportReceiveDate { get; set; }
        public string Component { get; set; }
        public string Summary { get; set; }
        public string Conequence { get; set; }
        public string Remedy { get; set; }
        public string Notes { get; set; }
        public string ModelYear { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
