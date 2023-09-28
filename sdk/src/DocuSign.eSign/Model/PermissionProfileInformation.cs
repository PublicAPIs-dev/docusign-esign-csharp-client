/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// Contains details about the permission profiles associated with an account.
    /// </summary>
    [DataContract]
    public partial class PermissionProfileInformation :  IEquatable<PermissionProfileInformation>, IValidatableObject
    {
        public PermissionProfileInformation()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionProfileInformation" /> class.
        /// </summary>
        /// <param name="PermissionProfiles">A complex type containing a collection of permission profiles..</param>
        public PermissionProfileInformation(List<PermissionProfile> PermissionProfiles = default(List<PermissionProfile>))
        {
            this.PermissionProfiles = PermissionProfiles;
        }
        
        /// <summary>
        /// A complex type containing a collection of permission profiles.
        /// </summary>
        /// <value>A complex type containing a collection of permission profiles.</value>
        [DataMember(Name="permissionProfiles", EmitDefaultValue=false)]
        public List<PermissionProfile> PermissionProfiles { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionProfileInformation {\n");
            sb.Append("  PermissionProfiles: ").Append(PermissionProfiles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as PermissionProfileInformation);
        }

        /// <summary>
        /// Returns true if PermissionProfileInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PermissionProfileInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PermissionProfileInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PermissionProfiles == other.PermissionProfiles ||
                    this.PermissionProfiles != null &&
                    this.PermissionProfiles.SequenceEqual(other.PermissionProfiles)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.PermissionProfiles != null)
                    hash = hash * 59 + this.PermissionProfiles.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
