﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using static Interop;

namespace System.Windows.Forms;

public partial class PictureBox
{
    internal class PictureBoxAccessibleObject : ControlAccessibleObject
    {
        public PictureBoxAccessibleObject(PictureBox owner) : base(owner)
        {
        }

        internal override object? GetPropertyValue(UiaCore.UIA propertyID)
            => propertyID switch
            {
                UiaCore.UIA.ControlTypePropertyId when this.GetOwnerAccessibleRole() == AccessibleRole.Default
                    // If we don't set a default role for the accessible object
                    // it will be retrieved from Windows.
                    // And we don't have a 100% guarantee it will be correct, hence set it ourselves.
                    => UiaCore.UIA.PaneControlTypeId,
                UiaCore.UIA.IsKeyboardFocusablePropertyId => true,
                _ => base.GetPropertyValue(propertyID)
            };
    }
}
