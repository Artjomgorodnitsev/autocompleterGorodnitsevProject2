﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace autocompleterGorodnitsevProject.Models
{
    public class Nimed
    {
        public int Id { get; set; }

        public string Sugu { get; set; }

        public string Emakeelnenimi { get; set; }

        public string Voorkeelnenimi { get; set; }
    }
}