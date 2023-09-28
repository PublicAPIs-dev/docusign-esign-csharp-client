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
    /// Describes the recipient phone number.
    /// </summary>
    [DataContract]
    public partial class RecipientPhoneNumber :  IEquatable<RecipientPhoneNumber>, IValidatableObject
    {
        public RecipientPhoneNumber()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientPhoneNumber" /> class.
        /// </summary>
        /// <param name="CountryCode">CountryCode.</param>
        /// <param name="CountryCodeMetadata">Metadata that indicates if the &#x60;countryCode&#x60; property is editable..</param>
        /// <param name="Number">Number.</param>
        /// <param name="NumberMetadata">Metadata that indicates if the &#x60;number&#x60; property is editable..</param>
        public RecipientPhoneNumber(string CountryCode = default(string), PropertyMetadata CountryCodeMetadata = default(PropertyMetadata), string Number = default(string), PropertyMetadata NumberMetadata = default(PropertyMetadata))
        {
            this.CountryCode = CountryCode;
            this.CountryCodeMetadata = CountryCodeMetadata;
            this.Number = Number;
            this.NumberMetadata = NumberMetadata;
        }
        
        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="countryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }
        /// <summary>
        /// Metadata that indicates if the &#x60;countryCode&#x60; property is editable.
        /// </summary>
        /// <value>Metadata that indicates if the &#x60;countryCode&#x60; property is editable.</value>
        [DataMember(Name="countryCodeMetadata", EmitDefaultValue=false)]
        public PropertyMetadata CountryCodeMetadata { get; set; }
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
            sb.Append("class RecipientPhoneNumber {\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  CountryCodeMetadata: ").Append(CountryCodeMetadata).Append("\n");
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
            return this.Equals(obj as RecipientPhoneNumber);
        }

        /// <summary>
        /// Returns true if RecipientPhoneNumber instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientPhoneNumber to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientPhoneNumber other)
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
                    this.CountryCodeMetadata == other.CountryCodeMetadata ||
                    this.CountryCodeMetadata != null &&
                    this.CountryCodeMetadata.Equals(other.CountryCodeMetadata)
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
                if (this.CountryCodeMetadata != null)
                    hash = hash * 59 + this.CountryCodeMetadata.GetHashCode();
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
