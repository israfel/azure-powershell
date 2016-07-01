﻿// -----------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// -----------------------------------------------------------------------------
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


    public class PSVirtualMachineConfiguration
    {

        internal Microsoft.Azure.Batch.VirtualMachineConfiguration omObject;

        private PSImageReference imageReference;

        private PSWindowsConfiguration windowsConfiguration;

        public PSVirtualMachineConfiguration(PSImageReference imageReference, string nodeAgentSkuId, PSWindowsConfiguration windowsConfiguration = default(PSWindowsConfiguration))
        {
            Microsoft.Azure.Batch.WindowsConfiguration windowsConfigurationOmObject = null;
            if ((windowsConfiguration != null))
            {
                windowsConfigurationOmObject = windowsConfiguration.omObject;
            }
            this.omObject = new Microsoft.Azure.Batch.VirtualMachineConfiguration(imageReference.omObject, nodeAgentSkuId, windowsConfigurationOmObject);
        }

        internal PSVirtualMachineConfiguration(Microsoft.Azure.Batch.VirtualMachineConfiguration omObject)
        {
            if ((omObject == null))
            {
                throw new System.ArgumentNullException("omObject");
            }
            this.omObject = omObject;
        }

        public PSImageReference ImageReference
        {
            get
            {
                if (((this.imageReference == null)
                            && (this.omObject.ImageReference != null)))
                {
                    this.imageReference = new PSImageReference(this.omObject.ImageReference);
                }
                return this.imageReference;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.ImageReference = null;
                }
                else
                {
                    this.omObject.ImageReference = value.omObject;
                }
                this.imageReference = value;
            }
        }

        public string NodeAgentSkuId
        {
            get
            {
                return this.omObject.NodeAgentSkuId;
            }
            set
            {
                this.omObject.NodeAgentSkuId = value;
            }
        }

        public PSWindowsConfiguration WindowsConfiguration
        {
            get
            {
                if (((this.windowsConfiguration == null)
                            && (this.omObject.WindowsConfiguration != null)))
                {
                    this.windowsConfiguration = new PSWindowsConfiguration(this.omObject.WindowsConfiguration);
                }
                return this.windowsConfiguration;
            }
            set
            {
                if ((value == null))
                {
                    this.omObject.WindowsConfiguration = null;
                }
                else
                {
                    this.omObject.WindowsConfiguration = value.omObject;
                }
                this.windowsConfiguration = value;
            }
        }
    }
}
