﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Core
{
    /// <summary>
    /// Represents a connection string info
    /// </summary>
    public interface INopConnectionStringInfo
    {
        /// <summary>
        /// DatabaseName
        /// </summary>
        string DatabaseName { get; set; }

        /// <summary>
        /// Server name or IP address
        /// </summary>
        string ServerName { get; set; }

        /// <summary>
        /// Integrated security
        /// </summary>
        bool IntegratedSecurity { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        string Username { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        string Password { get; set; }
    }
}
