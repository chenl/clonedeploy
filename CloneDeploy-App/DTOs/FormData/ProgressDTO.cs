﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloneDeploy_App.DTOs.FormData
{
    public class ProgressDTO
    {
        public string computerId { get; set; }
        public string progress { get; set; }
        public string progressType { get; set; }
    }
}