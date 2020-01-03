﻿// Copyright (c) Brice Lambson
// The Brice Lambson licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.  Code forked from Brice Lambson's https://github.com/bricelam/ImageResizer/

namespace System
{
    static class TimeSpanExtensions
    {
        public static TimeSpan Multiply(this TimeSpan timeSpan, double scalar)
            => new TimeSpan((long)(timeSpan.Ticks * scalar));
    }
}