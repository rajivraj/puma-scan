/* 
 * Copyright(c) 2016 - 2018 Puma Security, LLC (https://www.pumascan.com)
 * 
 * Project Leader: Eric Johnson (eric.johnson@pumascan.com)
 * Lead Developer: Eric Mead (eric.mead@pumascan.com)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. 
 */

namespace Puma.Security.Parser
{
    public class Instance
    {
        public string Category { get; set; }

        public string Path { get; set; }

        public int ColumnNumber{ get; set; }

        public int LineNumber { get; set; }

        public string Message { get; set; }

        public string Project { get; set; }
    }
}