// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Extensions;

    /// <summary>
    /// The result returned from a AttachedDatabaseConfigurations check name availability request.
    /// </summary>
    public partial class AttachedDatabaseConfigurationsCheckNameRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IAttachedDatabaseConfigurationsCheckNameRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IAttachedDatabaseConfigurationsCheckNameRequestInternal
    {

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Kusto.Models.Api20221229.IAttachedDatabaseConfigurationsCheckNameRequestInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Attached database resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type= @"Microsoft.Kusto/Clusters/attachedDatabaseConfigurations";

        /// <summary>
        /// The type of resource, for instance Microsoft.Kusto/Clusters/attachedDatabaseConfigurations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Origin(Microsoft.Azure.PowerShell.Cmdlets.Kusto.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>
        /// Creates an new <see cref="AttachedDatabaseConfigurationsCheckNameRequest" /> instance.
        /// </summary>
        public AttachedDatabaseConfigurationsCheckNameRequest()
        {

        }
    }
    /// The result returned from a AttachedDatabaseConfigurations check name availability request.
    public partial interface IAttachedDatabaseConfigurationsCheckNameRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.IJsonSerializable
    {
        /// <summary>Attached database resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Attached database resource name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// The type of resource, for instance Microsoft.Kusto/Clusters/attachedDatabaseConfigurations.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Kusto.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"The type of resource, for instance Microsoft.Kusto/Clusters/attachedDatabaseConfigurations.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// The result returned from a AttachedDatabaseConfigurations check name availability request.
    internal partial interface IAttachedDatabaseConfigurationsCheckNameRequestInternal

    {
        /// <summary>Attached database resource name.</summary>
        string Name { get; set; }
        /// <summary>
        /// The type of resource, for instance Microsoft.Kusto/Clusters/attachedDatabaseConfigurations.
        /// </summary>
        string Type { get; set; }

    }
}