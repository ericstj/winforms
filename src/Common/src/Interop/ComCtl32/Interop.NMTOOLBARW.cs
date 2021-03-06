﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

internal static partial class Interop
{
    internal static partial class ComCtl32
    {
        public unsafe struct NMTOOLBARW
        {
            public User32.NMHDR hdr;
            public int iItem;
            public TBBUTTON tbButton;
            public int cchText;
            public char* pszText;
            public RECT rcButton;
        }
    }
}
