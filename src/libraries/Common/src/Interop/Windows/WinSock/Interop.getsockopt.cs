// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using System.Net.Sockets;

internal static partial class Interop
{
    internal static partial class Winsock
    {
        [GeneratedDllImport(Interop.Libraries.Ws2_32, SetLastError = true)]
        internal static unsafe partial SocketError getsockopt(
            SafeSocketHandle socketHandle,
            SocketOptionLevel optionLevel,
            SocketOptionName optionName,
            byte* optionValue,
            ref int optionLength);

        [GeneratedDllImport(Interop.Libraries.Ws2_32, SetLastError = true)]
        internal static partial SocketError getsockopt(
            SafeSocketHandle socketHandle,
            SocketOptionLevel optionLevel,
            SocketOptionName optionName,
            out Linger optionValue,
            ref int optionLength);

        [GeneratedDllImport(Interop.Libraries.Ws2_32, SetLastError = true)]
        internal static partial SocketError getsockopt(
            SafeSocketHandle socketHandle,
            SocketOptionLevel optionLevel,
            SocketOptionName optionName,
            out IPMulticastRequest optionValue,
            ref int optionLength);

        [GeneratedDllImport(Interop.Libraries.Ws2_32, SetLastError = true)]
        internal static partial SocketError getsockopt(
            SafeSocketHandle socketHandle,
            SocketOptionLevel optionLevel,
            SocketOptionName optionName,
            out IPv6MulticastRequest optionValue,
            ref int optionLength);
    }
}
