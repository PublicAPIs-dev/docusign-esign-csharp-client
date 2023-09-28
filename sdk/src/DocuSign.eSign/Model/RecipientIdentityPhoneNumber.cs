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
    /// RecipientIdentityPhoneNumber
    /// </summary>
    [DataContract]
    public partial class RecipientIdentityPhoneNumber :  IEquatable<RecipientIdentityPhoneNumber>, IValidatableObject
    {
        public RecipientIdentityPhoneNumber()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientIdentityPhoneNumber" /> class.
        /// </summary>
        /// <param name="CountryCode">CountryCode.</param>
        /// <param name="CountryCodeLock">CountryCodeLock.</param>
        /// <param name="CountryCodeMetadata">Metadata that indicates if the &#x60;countryCode&#x60; property is editable..</param>
        /// <param name="Extension">Extension.</param>
        /// <param name="ExtensionMetadata">Metadata that indicates if the &#x60;extension&#x60; property is editable..</param>
        /// <param name="Number">Number.</param>
        /// <param name="NumberMetadata">Metadata that indicates if the &#x60;number&#x60; property is editable..</param>
        public RecipientIdentityPhoneNumber(string CountryCode = default(string), string CountryCodeLock = default(string), PropertyMetadata CountryCodeMetadata = default(PropertyMetadata), string Extension = default(string), PropertyMetadata ExtensionMetadata = default(PropertyMetadata), string Number = default(string), PropertyMetadata NumberMetadata = default(PropertyMetadata))
        {
            this.CountryCode = CountryCode;
            this.CountryCodeLock = CountryCodeLock;
            this.CountryCodeMetadata = CountryCodeMetadata;
            this.Extension = Extension;
            this.ExtensionMetadata = ExtensionMetadata;
            this.Number = Number;
            this.NumberMetadata = NumberMetadata;
        }
        
        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        /// <summary>
        /// Gets or Sets CountryCodeLock
        /// </summary>
        [DataMember(Name="countryCodeLock", EmitDefaultValue=false)]
        public string CountryCodeLock { get; set; }
        /// <summary>
        /// Metadata that indicates if the &#x60;countryCode&#x60; property is editable.
        /// </summary>
        /// <value>Metadata that indicates if the &#x60;countryCode&#x60; property is editable.</value>
        [DataMember(Name="countryCodeMetadata", EmitDefaultValue=false)]
        public PropertyMetadata CountryCodeMetadata { get; set; }
        /// <summary>
        /// Gets or Sets Extension
        /// </summary>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public string Extension { get; set; }
        /// <summary>
        /// Metadata that indicates if the &#x60;extension&#x60; property is editable.
        /// </summary>
        /// <value>Metadata that indicates if the &#x60;extension&#x60; property is editable.</value>
        [DataMember(Name="extensionMetadata", EmitDefaultValue=false)]
        public PropertyMetadata ExtensionMetadata { get; set; }
        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }
        /// <summary>
        /// Metadata that indicates if the &#x60;number&#x60; property is editable.
        /// </summary>
        /// <value>Metadata that indicates if the &#x60;number&#x60; property is editable.</value>
        [DataMember(Name="numberMetadata", EmitDefaultValue=false)]
        public PropertyMetadata NumberMetadata { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientIdentityPhoneNumber {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CountryCodeLock: ").Append(CountryCodeLock).Append("\n");
            sb.Append("  CountryCodeMetadata: ").Append(CountryCodeMetadata).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  ExtensionMetadata: ").Append(ExtensionMetadata).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  NumberMetadata: ").Append(NumberMetadata).Append("\n");
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
            return this.Equals(obj as RecipientIdentityPhoneNumber);
        }

        /// <summary>
        /// Returns true if RecipientIdentityPhoneNumber instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientIdentityPhoneNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientIdentityPhoneNumber other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CountryCode == other.CountryCode ||
                    this.CountryCode != null &&
                    this.CountryCode.Equals(other.CountryCode)
                ) && 
                (
                    this.CountryCodeLock == other.CountryCodeLock ||
                    this.CountryCodeLock != null &&
                    this.CountryCodeLock.Equals(other.CountryCodeLock)
                ) && 
                (
                    this.CountryCodeMetadata == other.CountryCodeMetadata ||
                    this.CountryCodeMetadata != null &&
                    this.CountryCodeMetadata.Equals(other.CountryCodeMetadata)
                ) && 
                (
                    this.Extension == other.Extension ||
                    this.Extension != null &&
                    this.Extension.Equals(other.Extension)
                ) && 
                (
                    this.ExtensionMetadata == other.ExtensionMetadata ||
                    this.ExtensionMetadata != null &&
                    this.ExtensionMetadata.Equals(other.ExtensionMetadata)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.NumberMetadata == other.NumberMetadata ||
                    this.NumberMetadata != null &&
                    this.NumberMetadata.Equals(other.NumberMetadata)
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
                if (this.CountryCode != null)
                    hash = hash * 59 + this.CountryCode.GetHashCode();
                if (this.CountryCodeLock != null)
                    hash = hash * 59 + this.CountryCodeLock.GetHashCode();
                if (this.CountryCodeMetadata != null)
                    hash = hash * 59 + this.CountryCodeMetadata.GetHashCode();
                if (this.Extension != null)
                    hash = hash * 59 + this.Extension.GetHashCode();
                if (this.ExtensionMetadata != null)
                    hash = hash * 59 + this.ExtensionMetadata.GetHashCode();
                if (this.Number != null)
                    hash = hash * 59 + this.Number.GetHashCode();
                if (this.NumberMetadata != null)
                    hash = hash * 59 + this.NumberMetadata.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
