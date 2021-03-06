// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Sql.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.Sql.Fluent.SqlFirewallRule.Definition;
    using Microsoft.Azure.Management.Sql.Fluent.SqlFirewallRules.SqlFirewallRulesCreatable;
    using Microsoft.Azure.Management.Sql.Fluent.Models;
    using Microsoft.Rest;

    internal partial class SqlFirewallRulesImpl 
    {
        /// <summary>
        /// Gets the information about a resource from Azure based on the resource id.
        /// </summary>
        /// <param name="resourceGroup">The name of resource group.</param>
        /// <param name="parentName">The name of parent resource.</param>
        /// <param name="name">The name of resource.</param>
        /// <return>A representation of the deferred computation of this call returning the found resource.</return>
        async Task<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule> Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsGettingByParent<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule,Microsoft.Azure.Management.Sql.Fluent.ISqlServer,Microsoft.Azure.Management.Sql.Fluent.ISqlManager>.GetByParentAsync(string resourceGroup, string parentName, string name, CancellationToken cancellationToken)
        {
            return await this.GetByParentAsync(resourceGroup, parentName, name, cancellationToken) as Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule;
        }

        /// <summary>
        /// Gets the information about a resource from Azure based on the resource id.
        /// </summary>
        /// <param name="parentResource">The instance of parent resource.</param>
        /// <param name="name">The name of resource.</param>
        /// <return>A representation of the deferred computation of this call returning the found resource.</return>
        async Task<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule> Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsGettingByParent<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule,Microsoft.Azure.Management.Sql.Fluent.ISqlServer,Microsoft.Azure.Management.Sql.Fluent.ISqlManager>.GetByParentAsync(ISqlServer parentResource, string name, CancellationToken cancellationToken)
        {
            return await this.GetByParentAsync(parentResource, name, cancellationToken) as Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule;
        }

        /// <summary>
        /// Gets the information about a resource from Azure based on the resource id.
        /// </summary>
        /// <param name="resourceGroup">The name of resource group.</param>
        /// <param name="parentName">The name of parent resource.</param>
        /// <param name="name">The name of resource.</param>
        /// <return>An immutable representation of the resource.</return>
        Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsGettingByParent<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule,Microsoft.Azure.Management.Sql.Fluent.ISqlServer,Microsoft.Azure.Management.Sql.Fluent.ISqlManager>.GetByParent(string resourceGroup, string parentName, string name)
        {
            return this.GetByParent(resourceGroup, parentName, name) as Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule;
        }

        /// <summary>
        /// Gets the information about a resource from Azure based on the resource id.
        /// </summary>
        /// <param name="parentResource">The instance of parent resource.</param>
        /// <param name="name">The name of resource.</param>
        /// <return>An immutable representation of the resource.</return>
        Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsGettingByParent<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule,Microsoft.Azure.Management.Sql.Fluent.ISqlServer,Microsoft.Azure.Management.Sql.Fluent.ISqlManager>.GetByParent(ISqlServer parentResource, string name)
        {
            return this.GetByParent(parentResource, name) as Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule;
        }

        /// <summary>
        /// Gets the information about a resource from Azure based on the resource id.
        /// </summary>
        /// <param name="id">The id of the resource.</param>
        /// <return>An immutable representation of the resource.</return>
        async Task<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule> Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsGettingById<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule>.GetByIdAsync(string id, CancellationToken cancellationToken)
        {
            return await this.GetByIdAsync(id, cancellationToken) as Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule;
        }

        /// <summary>
        /// Gets the information about a resource from Azure based on the resource id.
        /// </summary>
        /// <param name="id">The id of the resource.</param>
        /// <return>An immutable representation of the resource.</return>
        Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsGettingById<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule>.GetById(string id)
        {
            return this.GetById(id) as Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule;
        }

        /// <summary>
        /// Deletes a resource from Azure, identifying it by its name and its resource group.
        /// </summary>
        /// <param name="groupName">The group the resource is part of.</param>
        /// <param name="parentName">The name of parent resource.</param>
        /// <param name="name">The name of the resource.</param>
        void Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsDeletingByParent.DeleteByParent(string groupName, string parentName, string name)
        {
 
            this.DeleteByParent(groupName, parentName, name);
        }

        /// <summary>
        /// Asynchronously delete a resource from Azure, identifying it by its name and its resource group.
        /// </summary>
        /// <param name="groupName">The group the resource is part of.</param>
        /// <param name="parentName">The name of parent resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <return>A representation of the deferred computation of this call.</return>
        async Task Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsDeletingByParent.DeleteByParentAsync(string groupName, string parentName, string name, CancellationToken cancellationToken)
        {
 
            await this.DeleteByParentAsync(groupName, parentName, name, cancellationToken);
        }

        /// <summary>
        /// Gets the SQLDatabase based on the resource group name, SQLServer name and FirewallRule name.
        /// </summary>
        /// <param name="resourceGroup">The name of resource group.</param>
        /// <param name="sqlServerName">The name of SQLServer.</param>
        /// <param name="name">The name of SQLDatabase.</param>
        /// <return>An immutable representation of the SQLDatabase.</return>
        Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRules.GetBySqlServer(string resourceGroup, string sqlServerName, string name)
        {
            return this.GetBySqlServer(resourceGroup, sqlServerName, name) as Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule;
        }

        /// <summary>
        /// Gets the SQLDatabase based on the SQLServer instance and FirewallRule name.
        /// </summary>
        /// <param name="sqlServer">The instance of SQLServer.</param>
        /// <param name="name">The name of SQLDatabase.</param>
        /// <return>An immutable representation of the SQLDatabase.</return>
        Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRules.GetBySqlServer(ISqlServer sqlServer, string name)
        {
            return this.GetBySqlServer(sqlServer, name) as Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule;
        }

        /// <summary>
        /// Lists resources of the specified type in the specified resource group and SQLServer.
        /// </summary>
        /// <param name="resourceGroupName">The name of the resource group to list the resources from.</param>
        /// <param name="sqlServerName">The name of SQLServer.</param>
        /// <return>The list of SQLDatabases in a SQLServer.</return>
        System.Collections.Generic.IReadOnlyList<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule> Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRules.ListBySqlServer(string resourceGroupName, string sqlServerName)
        {
            return this.ListBySqlServer(resourceGroupName, sqlServerName) as System.Collections.Generic.IReadOnlyList<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule>;
        }

        /// <summary>
        /// Gets the SQLDatabase based on the SQLServer.
        /// </summary>
        /// <param name="sqlServer">The instance of SQLServer.</param>
        /// <return>The list of SQLDatabases in a SQLServer.</return>
        System.Collections.Generic.IReadOnlyList<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule> Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRules.ListBySqlServer(ISqlServer sqlServer)
        {
            return this.ListBySqlServer(sqlServer) as System.Collections.Generic.IReadOnlyList<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule>;
        }

        /// <summary>
        /// Asynchronously delete a resource from Azure, identifying it by its resource ID.
        /// </summary>
        /// <param name="id">The resource ID of the resource to delete.</param>
        /// <return>A representation of the deferred computation of this call.</return>
        async Task Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsDeletingById.DeleteByIdAsync(string id, CancellationToken cancellationToken)
        {
 
            await this.DeleteByIdAsync(id, cancellationToken);
        }

        SqlFirewallRule.Definition.IBlank SqlFirewallRules.SqlFirewallRulesCreatable.ISqlFirewallRulesCreatable.DefinedWithSqlServer(string resourceGroupName, string sqlServerName, string firewallRuleName)
        {
            return this.DefinedWithSqlServer(resourceGroupName, sqlServerName, firewallRuleName) as SqlFirewallRule.Definition.IBlank;
        }

        /// <summary>
        /// Lists resources of the specified type in the specified resource group.
        /// </summary>
        /// <param name="resourceGroupName">The name of the resource group to list the resources from.</param>
        /// <param name="parentName">The name of parent resource.</param>
        /// <return>The list of resources.</return>
        System.Collections.Generic.IEnumerable<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule> Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsListingByParent<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule,Microsoft.Azure.Management.Sql.Fluent.ISqlServer,Microsoft.Azure.Management.Sql.Fluent.ISqlManager>.ListByParent(string resourceGroupName, string parentName)
        {
            return this.ListByParent(resourceGroupName, parentName) as System.Collections.Generic.IEnumerable<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule>;
        }

        /// <summary>
        /// Gets the information about a resource from Azure based on the resource id.
        /// </summary>
        /// <param name="parentResource">The instance of parent resource.</param>
        /// <return>An immutable representation of the resource.</return>
        System.Collections.Generic.IEnumerable<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule> Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions.ISupportsListingByParent<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule,Microsoft.Azure.Management.Sql.Fluent.ISqlServer,Microsoft.Azure.Management.Sql.Fluent.ISqlManager>.ListByParent(ISqlServer parentResource)
        {
            return this.ListByParent(parentResource) as System.Collections.Generic.IEnumerable<Microsoft.Azure.Management.Sql.Fluent.ISqlFirewallRule>;
        }
    }
}