﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Domain.Entities
{
    public class Feature
    {
        public int FeatureId { get; set; }
        public string Name{ get; set; }
        public List<CarFeature> CarFeatures { get; set; }
    }
}
