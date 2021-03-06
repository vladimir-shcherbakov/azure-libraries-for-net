// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLab.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLab;
    using Microsoft.Azure.Management.DevTestLab.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A virtual machine.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class LabVirtualMachineFragmentInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the LabVirtualMachineFragmentInner
        /// class.
        /// </summary>
        public LabVirtualMachineFragmentInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LabVirtualMachineFragmentInner
        /// class.
        /// </summary>
        /// <param name="notes">The notes of the virtual machine.</param>
        /// <param name="ownerObjectId">The object identifier of the owner of
        /// the virtual machine.</param>
        /// <param name="ownerUserPrincipalName">The user principal name of the
        /// virtual machine owner.</param>
        /// <param name="createdByUserId">The object identifier of the creator
        /// of the virtual machine.</param>
        /// <param name="createdByUser">The email address of creator of the
        /// virtual machine.</param>
        /// <param name="createdDate">The creation date of the virtual
        /// machine.</param>
        /// <param name="customImageId">The custom image identifier of the
        /// virtual machine.</param>
        /// <param name="osType">The OS type of the virtual machine.</param>
        /// <param name="size">The size of the virtual machine.</param>
        /// <param name="userName">The user name of the virtual
        /// machine.</param>
        /// <param name="password">The password of the virtual machine
        /// administrator.</param>
        /// <param name="sshKey">The SSH key of the virtual machine
        /// administrator.</param>
        /// <param name="isAuthenticationWithSshKey">Indicates whether this
        /// virtual machine uses an SSH key for authentication.</param>
        /// <param name="fqdn">The fully-qualified domain name of the virtual
        /// machine.</param>
        /// <param name="labSubnetName">The lab subnet name of the virtual
        /// machine.</param>
        /// <param name="labVirtualNetworkId">The lab virtual network
        /// identifier of the virtual machine.</param>
        /// <param name="disallowPublicIpAddress">Indicates whether the virtual
        /// machine is to be created without a public IP address.</param>
        /// <param name="artifacts">The artifacts to be installed on the
        /// virtual machine.</param>
        /// <param name="artifactDeploymentStatus">The artifact deployment
        /// status for the virtual machine.</param>
        /// <param name="galleryImageReference">The Microsoft Azure Marketplace
        /// image reference of the virtual machine.</param>
        /// <param name="computeVm">The compute virtual machine
        /// properties.</param>
        /// <param name="networkInterface">The network interface
        /// properties.</param>
        /// <param name="applicableSchedule">The applicable schedule for the
        /// virtual machine.</param>
        /// <param name="expirationDate">The expiration date for VM.</param>
        /// <param name="allowClaim">Indicates whether another user can take
        /// ownership of the virtual machine</param>
        /// <param name="storageType">Storage type to use for virtual machine
        /// (i.e. Standard, Premium).</param>
        /// <param name="virtualMachineCreationSource">Tells source of creation
        /// of lab virtual machine. Output property only. Possible values
        /// include: 'FromCustomImage', 'FromGalleryImage'</param>
        /// <param name="environmentId">The resource ID of the environment that
        /// contains this virtual machine, if any.</param>
        /// <param name="provisioningState">The provisioning status of the
        /// resource.</param>
        /// <param name="uniqueIdentifier">The unique immutable identifier of a
        /// resource (Guid).</param>
        public LabVirtualMachineFragmentInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string notes = default(string), string ownerObjectId = default(string), string ownerUserPrincipalName = default(string), string createdByUserId = default(string), string createdByUser = default(string), System.DateTime? createdDate = default(System.DateTime?), string customImageId = default(string), string osType = default(string), string size = default(string), string userName = default(string), string password = default(string), string sshKey = default(string), bool? isAuthenticationWithSshKey = default(bool?), string fqdn = default(string), string labSubnetName = default(string), string labVirtualNetworkId = default(string), bool? disallowPublicIpAddress = default(bool?), IList<ArtifactInstallPropertiesFragment> artifacts = default(IList<ArtifactInstallPropertiesFragment>), ArtifactDeploymentStatusPropertiesFragment artifactDeploymentStatus = default(ArtifactDeploymentStatusPropertiesFragment), GalleryImageReferenceFragment galleryImageReference = default(GalleryImageReferenceFragment), ComputeVmPropertiesFragment computeVm = default(ComputeVmPropertiesFragment), NetworkInterfacePropertiesFragment networkInterface = default(NetworkInterfacePropertiesFragment), ApplicableScheduleFragmentInner applicableSchedule = default(ApplicableScheduleFragmentInner), System.DateTime? expirationDate = default(System.DateTime?), bool? allowClaim = default(bool?), string storageType = default(string), string virtualMachineCreationSource = default(string), string environmentId = default(string), string provisioningState = default(string), string uniqueIdentifier = default(string))
            : base(location, id, name, type, tags)
        {
            Notes = notes;
            OwnerObjectId = ownerObjectId;
            OwnerUserPrincipalName = ownerUserPrincipalName;
            CreatedByUserId = createdByUserId;
            CreatedByUser = createdByUser;
            CreatedDate = createdDate;
            CustomImageId = customImageId;
            OsType = osType;
            Size = size;
            UserName = userName;
            Password = password;
            SshKey = sshKey;
            IsAuthenticationWithSshKey = isAuthenticationWithSshKey;
            Fqdn = fqdn;
            LabSubnetName = labSubnetName;
            LabVirtualNetworkId = labVirtualNetworkId;
            DisallowPublicIpAddress = disallowPublicIpAddress;
            Artifacts = artifacts;
            ArtifactDeploymentStatus = artifactDeploymentStatus;
            GalleryImageReference = galleryImageReference;
            ComputeVm = computeVm;
            NetworkInterface = networkInterface;
            ApplicableSchedule = applicableSchedule;
            ExpirationDate = expirationDate;
            AllowClaim = allowClaim;
            StorageType = storageType;
            VirtualMachineCreationSource = virtualMachineCreationSource;
            EnvironmentId = environmentId;
            ProvisioningState = provisioningState;
            UniqueIdentifier = uniqueIdentifier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the notes of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.notes")]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets the object identifier of the owner of the virtual
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ownerObjectId")]
        public string OwnerObjectId { get; set; }

        /// <summary>
        /// Gets or sets the user principal name of the virtual machine owner.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ownerUserPrincipalName")]
        public string OwnerUserPrincipalName { get; set; }

        /// <summary>
        /// Gets or sets the object identifier of the creator of the virtual
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdByUserId")]
        public string CreatedByUserId { get; set; }

        /// <summary>
        /// Gets or sets the email address of creator of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdByUser")]
        public string CreatedByUser { get; set; }

        /// <summary>
        /// Gets or sets the creation date of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDate")]
        public System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the custom image identifier of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customImageId")]
        public string CustomImageId { get; set; }

        /// <summary>
        /// Gets or sets the OS type of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public string OsType { get; set; }

        /// <summary>
        /// Gets or sets the size of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.size")]
        public string Size { get; set; }

        /// <summary>
        /// Gets or sets the user name of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the password of the virtual machine administrator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the SSH key of the virtual machine administrator.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sshKey")]
        public string SshKey { get; set; }

        /// <summary>
        /// Gets or sets indicates whether this virtual machine uses an SSH key
        /// for authentication.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isAuthenticationWithSshKey")]
        public bool? IsAuthenticationWithSshKey { get; set; }

        /// <summary>
        /// Gets or sets the fully-qualified domain name of the virtual
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fqdn")]
        public string Fqdn { get; set; }

        /// <summary>
        /// Gets or sets the lab subnet name of the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.labSubnetName")]
        public string LabSubnetName { get; set; }

        /// <summary>
        /// Gets or sets the lab virtual network identifier of the virtual
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.labVirtualNetworkId")]
        public string LabVirtualNetworkId { get; set; }

        /// <summary>
        /// Gets or sets indicates whether the virtual machine is to be created
        /// without a public IP address.
        /// </summary>
        [JsonProperty(PropertyName = "properties.disallowPublicIpAddress")]
        public bool? DisallowPublicIpAddress { get; set; }

        /// <summary>
        /// Gets or sets the artifacts to be installed on the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.artifacts")]
        public IList<ArtifactInstallPropertiesFragment> Artifacts { get; set; }

        /// <summary>
        /// Gets or sets the artifact deployment status for the virtual
        /// machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.artifactDeploymentStatus")]
        public ArtifactDeploymentStatusPropertiesFragment ArtifactDeploymentStatus { get; set; }

        /// <summary>
        /// Gets or sets the Microsoft Azure Marketplace image reference of the
        /// virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.galleryImageReference")]
        public GalleryImageReferenceFragment GalleryImageReference { get; set; }

        /// <summary>
        /// Gets or sets the compute virtual machine properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.computeVm")]
        public ComputeVmPropertiesFragment ComputeVm { get; set; }

        /// <summary>
        /// Gets or sets the network interface properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkInterface")]
        public NetworkInterfacePropertiesFragment NetworkInterface { get; set; }

        /// <summary>
        /// Gets or sets the applicable schedule for the virtual machine.
        /// </summary>
        [JsonProperty(PropertyName = "properties.applicableSchedule")]
        public ApplicableScheduleFragmentInner ApplicableSchedule { get; set; }

        /// <summary>
        /// Gets or sets the expiration date for VM.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expirationDate")]
        public System.DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Gets or sets indicates whether another user can take ownership of
        /// the virtual machine
        /// </summary>
        [JsonProperty(PropertyName = "properties.allowClaim")]
        public bool? AllowClaim { get; set; }

        /// <summary>
        /// Gets or sets storage type to use for virtual machine (i.e.
        /// Standard, Premium).
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageType")]
        public string StorageType { get; set; }

        /// <summary>
        /// Gets or sets tells source of creation of lab virtual machine.
        /// Output property only. Possible values include: 'FromCustomImage',
        /// 'FromGalleryImage'
        /// </summary>
        [JsonProperty(PropertyName = "properties.virtualMachineCreationSource")]
        public string VirtualMachineCreationSource { get; set; }

        /// <summary>
        /// Gets or sets the resource ID of the environment that contains this
        /// virtual machine, if any.
        /// </summary>
        [JsonProperty(PropertyName = "properties.environmentId")]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Gets or sets the provisioning status of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets the unique immutable identifier of a resource (Guid).
        /// </summary>
        [JsonProperty(PropertyName = "properties.uniqueIdentifier")]
        public string UniqueIdentifier { get; set; }

    }
}
