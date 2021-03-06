// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Net
{
    internal static class GlobalSSPI
    {
        internal static readonly SSPIAuthType SSPIAuth = new SSPIAuthType();
        internal static readonly SSPISecureChannelType SSPISecureChannel = new SSPISecureChannelType();
    }
}
