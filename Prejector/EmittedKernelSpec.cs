﻿using System.Collections.Generic;

namespace PreJector
{
    public sealed class EmittedKernelSpec
    {
        public string KernelClassName { get; set; }
        public string PrivateFieldType { get; set; }
        public bool IsDebug { get; set; }
        public string PrivateFieldName { get; set; }
        public string ReturnType { get; set; }
        public IList<string> Namespaces { get; set; }
    }
}