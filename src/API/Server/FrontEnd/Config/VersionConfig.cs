﻿using CodeProject.AI.API.Common;

namespace CodeProject.AI.API.Server.Frontend
{
    /// <summary>
    /// Version instance config values.
    /// </summary>
    public class VersionConfig
    {
        internal static string VersionCfgFilename = "version.json";
        internal static string VersionCfgSection  = "versionSection";

        /// <summary>
        /// Gets or sets the version info
        /// </summary>
        public VersionInfo? VersionInfo { get; set; }
    }
}
