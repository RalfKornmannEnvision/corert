// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Advapi32
    {
        [DllImport(Interop.Libraries.Advapi32, EntryPoint = "GetWindowsAccountDomainSid", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern int GetWindowsAccountDomainSid(byte[] sid, byte[] resultSid, ref uint resultSidLength);
    }
}
