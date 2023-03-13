using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Fhir.R4.Model
{
    partial class Resource
    {
        public virtual string resourceType => GetType().Name;
    }
}
