﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonGenerator
{
    public class JsonModel
    {
        public Dictionary<string, string> meta { get; }
        public List<Ship> data { get; }

        public JsonModel(string version, List<Ship> ships)
        {
            meta = new Dictionary<string, string>
            {
                { "wowsversion", version }
            };

            data = ships;
        }
    }
}
