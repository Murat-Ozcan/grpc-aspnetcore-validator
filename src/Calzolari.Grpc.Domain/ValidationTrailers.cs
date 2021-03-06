﻿using System;

namespace Calzolari.Grpc.Domain
{
    [Serializable]
    public class ValidationTrailers
    {
        public string PropertyName { get; set; }

        public string ErrorMessage { get; set; }

        public string AttemptedValue { get; set; }
    }
}