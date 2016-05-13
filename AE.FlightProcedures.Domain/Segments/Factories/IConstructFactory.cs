﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AE.FlightProcedures.Domain.Segments.Factories
{
    internal interface IConstructFactory
    {
        Construct CreateEsaConstruct(Radius radius, Location location);
    }
}