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
    /// ConnectOAuthConfig
    /// </summary>
    [DataContract]
    public partial class ConnectOAuthConfig :  IEquatable<ConnectOAuthConfig>, IValidatableObject
    {
        public ConnectOAuthConfig()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectOAuthConfig" /> class.
        /// </summary>
        /// <param name="AuthorizationServerUrl">AuthorizationServerUrl.</param>
        /// <param name="ClientId">ClientId.</param>
        /// <param name="ClientSecret">ClientSecret.</param>
        /// <param name="CustomParameters">CustomParameters.</param>
        /// <param name="Scope">Scope.</param>
        public ConnectOAuthConfig(string AuthorizationServerUrl = default(string), string ClientId = default(string), string ClientSecret = default(string), string CustomParameters = default(string), string Scope = default(string))
        {
            this.AuthorizationServerUrl = AuthorizationServerUrl;
            this.ClientId = ClientId;
            this.ClientSecret = ClientSecret;
            this.CustomParameters = CustomParameters;
            this.Scope = Scope;
        }
        
        /// <summary>
        /// Gets or Sets AuthorizationServerUrl
        /// </summary>
        [DataMember(Name="authorizationServerUrl", EmitDefaultValue=false)]
        public string AuthorizationServerUrl { get; set; }
        /// <summary>
        /// Gets or Sets ClientId
        /// </summary>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; set; }
        /// <summary>
        /// Gets or Sets ClientSecret
        /// </summary>
        [DataMember(Name="clientSecret", EmitDefaultValue=false)]
        public string ClientSecret { get; set; }
        /// <summary>
        /// Gets or Sets CustomParameters
        /// </summary>
        [DataMember(Name="customParameters", EmitDefaultValue=false)]
        public string CustomParameters { get; set; }
        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name="scope", EmitDefaultValue=false)]
        public string Scope { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectOAuthConfig {\n");
            sb.Append("  AuthorizationServerUrl: ").Append(AuthorizationServerUrl).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  ClientSecret: ").Append(ClientSecret).Append("\n");
            sb.Append("  CustomParameters: ").Append(CustomParameters).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
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
            return this.Equals(obj as ConnectOAuthConfig);
        }

        /// <summary>
        /// Returns true if ConnectOAuthConfig instances are equal
        /// </summary>
        /// <param name="other">Instance of ConnectOAuthConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectOAuthConfig other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AuthorizationServerUrl == other.AuthorizationServerUrl ||
                    this.AuthorizationServerUrl != null &&
                    this.AuthorizationServerUrl.Equals(other.AuthorizationServerUrl)
                ) && 
                (
                    this.ClientId == other.ClientId ||
                    this.ClientId != null &&
                    this.ClientId.Equals(other.ClientId)
                ) && 
                (
                    this.ClientSecret == other.ClientSecret ||
                    this.ClientSecret != null &&
                    this.ClientSecret.Equals(other.ClientSecret)
                ) && 
                (
                    this.CustomParameters == other.CustomParameters ||
                    this.CustomParameters != null &&
                    this.CustomParameters.Equals(other.CustomParameters)
                ) && 
                (
                    this.Scope == other.Scope ||
                    this.Scope != null &&
                    this.Scope.Equals(other.Scope)
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
                if (this.AuthorizationServerUrl != null)
                    hash = hash * 59 + this.AuthorizationServerUrl.GetHashCode();
                if (this.ClientId != null)
                    hash = hash * 59 + this.ClientId.GetHashCode();
                if (this.ClientSecret != null)
                    hash = hash * 59 + this.ClientSecret.GetHashCode();
                if (this.CustomParameters != null)
                    hash = hash * 59 + this.CustomParameters.GetHashCode();
                if (this.Scope != null)
                    hash = hash * 59 + this.Scope.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
