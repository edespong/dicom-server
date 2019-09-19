﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace Microsoft.Health.Dicom.Web.IdentityProvider
{
    public class DevelopmentIdentityProviderConfiguration
    {
        public const string Audience = "dicom-api";

        public bool Enabled { get; set; }

        public IList<DevelopmentIdentityProviderApplicationConfiguration> ClientApplications { get; } = new List<DevelopmentIdentityProviderApplicationConfiguration>();

        public IList<DevelopmentIdentityProviderUserConfiguration> Users { get; } = new List<DevelopmentIdentityProviderUserConfiguration>();
    }
}
