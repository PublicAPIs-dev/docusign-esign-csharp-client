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
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// This object contains information used to configure [eNote](https://www.docusign.com/products/enote) functionality. To use eNote, the Allow eNote for eOriginal account plan item must be on, and the Connect configuration for eOriginal must be set correctly.
    /// </summary>
    [DataContract]
    public partial class ENoteConfiguration :  IEquatable<ENoteConfiguration>, IValidatableObject
    {
        public ENoteConfiguration()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ENoteConfiguration" /> class.
        /// </summary>
        /// <param name="ApiKey">ApiKey.</param>
        /// <param name="ConnectConfigured">ConnectConfigured.</param>
        /// <param name="ENoteConfigured">ENoteConfigured.</param>
        /// <param name="Organization">Organization.</param>
        /// <param name="Password">Password.</param>
        /// <param name="UserName">UserName.</param>
        public ENoteConfiguration(string ApiKey = default(string), string ConnectConfigured = default(string), string ENoteConfigured = default(string), string Organization = default(string), string Password = default(string), string UserName = default(string))
        {
            this.ApiKey = ApiKey;
            this.ConnectConfigured = ConnectConfigured;
            this.ENoteConfigured = ENoteConfigured;
            this.Organization = Organization;
            this.Password = Password;
            this.UserName = UserName;
        }
        
        /// <summary>
        /// Gets or Sets ApiKey
        /// </summary>
        [DataMember(Name="apiKey", EmitDefaultValue=false)]
        public string ApiKey { get; set; }
        /// <summary>
        /// Gets or Sets ConnectConfigured
        /// </summary>
        [DataMember(Name="connectConfigured", EmitDefaultValue=false)]
        public string ConnectConfigured { get; set; }
        /// <summary>
        /// Gets or Sets ENoteConfigured
        /// </summary>
        [DataMember(Name="eNoteConfigured", EmitDefaultValue=false)]
        public string ENoteConfigured { get; set; }
        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public string Organization { get; set; }
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }
        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ENoteConfiguration {\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  ConnectConfigured: ").Append(ConnectConfigured).Append("\n");
            sb.Append("  ENoteConfigured: ").Append(ENoteConfigured).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
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
            return this.Equals(obj as ENoteConfiguration);
        }

        /// <summary>
        /// Returns true if ENoteConfiguration instances are equal
        /// </summary>
        /// <param name="other">Instance of ENoteConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ENoteConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApiKey == other.ApiKey ||
                    this.ApiKey != null &&
                    this.ApiKey.Equals(other.ApiKey)
                ) && 
                (
                    this.ConnectConfigured == other.ConnectConfigured ||
                    this.ConnectConfigured != null &&
                    this.ConnectConfigured.Equals(other.ConnectConfigured)
                ) && 
                (
                    this.ENoteConfigured == other.ENoteConfigured ||
                    this.ENoteConfigured != null &&
                    this.ENoteConfigured.Equals(other.ENoteConfigured)
                ) && 
                (
                    this.Organization == other.Organization ||
                    this.Organization != null &&
                    this.Organization.Equals(other.Organization)
                ) && 
                (
                    this.Password == other.Password ||
                    this.Password != null &&
                    this.Password.Equals(other.Password)
                ) && 
                (
                    this.UserName == other.UserName ||
                    this.UserName != null &&
                    this.UserName.Equals(other.UserName)
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
                if (this.ApiKey != null)
                    hash = hash * 59 + this.ApiKey.GetHashCode();
                if (this.ConnectConfigured != null)
                    hash = hash * 59 + this.ConnectConfigured.GetHashCode();
                if (this.ENoteConfigured != null)
                    hash = hash * 59 + this.ENoteConfigured.GetHashCode();
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();
                if (this.Password != null)
                    hash = hash * 59 + this.Password.GetHashCode();
                if (this.UserName != null)
                    hash = hash * 59 + this.UserName.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
