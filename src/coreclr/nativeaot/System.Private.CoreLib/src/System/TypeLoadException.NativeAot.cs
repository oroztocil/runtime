// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System
{
    public partial class TypeLoadException
    {
        private void SetMessageField()
        {
            _message ??= SR.Arg_TypeLoadException;
        }
    }
}
