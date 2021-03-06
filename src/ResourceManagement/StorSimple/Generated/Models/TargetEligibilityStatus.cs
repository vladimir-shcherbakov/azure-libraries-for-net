// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for TargetEligibilityStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TargetEligibilityStatus
    {
        [EnumMember(Value = "NotEligible")]
        NotEligible,
        [EnumMember(Value = "Eligible")]
        Eligible
    }
    internal static class TargetEligibilityStatusEnumExtension
    {
        internal static string ToSerializedValue(this TargetEligibilityStatus? value)
        {
            return value == null ? null : ((TargetEligibilityStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this TargetEligibilityStatus value)
        {
            switch( value )
            {
                case TargetEligibilityStatus.NotEligible:
                    return "NotEligible";
                case TargetEligibilityStatus.Eligible:
                    return "Eligible";
            }
            return null;
        }

        internal static TargetEligibilityStatus? ParseTargetEligibilityStatus(this string value)
        {
            switch( value )
            {
                case "NotEligible":
                    return TargetEligibilityStatus.NotEligible;
                case "Eligible":
                    return TargetEligibilityStatus.Eligible;
            }
            return null;
        }
    }
}
