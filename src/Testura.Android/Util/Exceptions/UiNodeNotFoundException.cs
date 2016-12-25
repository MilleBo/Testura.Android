﻿using System;

namespace Testura.Android.Util.Exceptions
{
    public class UiNodeNotFoundException : Exception
    {
        public UiNodeNotFoundException()
            : base("Could not find node.")
        {
        }

        public UiNodeNotFoundException(string message)
            : base(message)
        {
        }

        public UiNodeNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
