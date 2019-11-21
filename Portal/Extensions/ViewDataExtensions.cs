using Humanizer.Bytes;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Portal.Core;
using System;
using System.Diagnostics;

namespace Portal
{
    public static class ViewDataExtensions
    {
        private const string DATE_TIME_NOW = "DateTimeNow";
        private const string KEY = "Key";
        private const string SUM = "Sum";
        private const string VIRTUAL_MACHINES = "VirtualMachines";
        private const string REQUESTS_COUNTER = "RequestsCounter";
        private const string GC_ZERO = "gc0";
        private const string GC_ONE = "gc1";
        private const string GC_TWO = "gc2";
        private const string CURRENT_MEMORY = "currentMemory";
        private const string PRIVATE_BYTES = "privateBytes";
        private static ViewDataDictionary Set(this ViewDataDictionary viewData, string key, object value)
        {
            viewData[key] = value;
            return viewData;
        }

        public static ViewDataDictionary SetResult(this ViewDataDictionary viewData, string result, HashKey hash)
            => viewData.Set(DATE_TIME_NOW, result)
                    .Set(KEY, hash.Value)
                    .Set(SUM, hash.OddNumbersSum);

        public static ViewDataDictionary Dump(this ViewDataDictionary viewData, int requests) 
            => viewData.Set(VIRTUAL_MACHINES, Program.NUMBER_OF_VIRTUAL_MACHINES)
                    .Set(REQUESTS_COUNTER, requests)
                    .Set(GC_ZERO, GC.CollectionCount(0))
                    .Set(GC_ONE, GC.CollectionCount(1))
                    .Set(GC_TWO, GC.CollectionCount(2))
                    .Set(CURRENT_MEMORY, ByteSize.FromBytes(GC.GetTotalMemory(false)).ToString())
                    .Set(PRIVATE_BYTES, ByteSize.FromBytes(Process.GetCurrentProcess().WorkingSet64));
    }
}
