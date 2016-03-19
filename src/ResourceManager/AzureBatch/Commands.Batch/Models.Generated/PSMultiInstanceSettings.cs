﻿// -----------------------------------------------------------------------------
﻿//
﻿// Copyright Microsoft Corporation
﻿// Licensed under the Apache License, Version 2.0 (the "License");
﻿// you may not use this file except in compliance with the License.
﻿// You may obtain a copy of the License at
﻿// http://www.apache.org/licenses/LICENSE-2.0
﻿// Unless required by applicable law or agreed to in writing, software
﻿// distributed under the License is distributed on an "AS IS" BASIS,
﻿// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
﻿// See the License for the specific language governing permissions and
﻿// limitations under the License.
﻿// -----------------------------------------------------------------------------
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Batch.Models
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using Microsoft.Azure.Batch;
    
    
    public class PSMultiInstanceSettings
    {
        
        internal Microsoft.Azure.Batch.MultiInstanceSettings omObject;
        
        private IList<PSResourceFile> commonResourceFiles;
        
        public PSMultiInstanceSettings(int numberOfInstances)
        {
            this.omObject = new Microsoft.Azure.Batch.MultiInstanceSettings(numberOfInstances);
        }
        
        internal PSMultiInstanceSettings(Microsoft.Azure.Batch.MultiInstanceSettings omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }
        
        public IList<PSResourceFile> CommonResourceFiles
        {
            get
            {
                if (((this.commonResourceFiles == null) 
                            && (this.omObject.CommonResourceFiles != null)))
                {
                    List<PSResourceFile> list;
                    list = new List<PSResourceFile>();
                    IEnumerator<Microsoft.Azure.Batch.ResourceFile> enumerator;
                    enumerator = this.omObject.CommonResourceFiles.GetEnumerator();
                    for (
                    ; enumerator.MoveNext(); 
                    )
                    {
                        list.Add(new PSResourceFile(enumerator.Current));
                    }
                    this.commonResourceFiles = list;
                }
                return this.commonResourceFiles;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.CommonResourceFiles = null;
                }
                else
                {
                    this.omObject.CommonResourceFiles = new List<Microsoft.Azure.Batch.ResourceFile>();
                }
                this.commonResourceFiles = value;
            }
        }
        
        public string CoordinationCommandLine
        {
            get
            {
                return this.omObject.CoordinationCommandLine;
            }
            set
            {
                this.omObject.CoordinationCommandLine = value;
            }
        }
        
        public int NumberOfInstances
        {
            get
            {
                return this.omObject.NumberOfInstances;
            }
            set
            {
                this.omObject.NumberOfInstances = value;
            }
        }
    }
}
