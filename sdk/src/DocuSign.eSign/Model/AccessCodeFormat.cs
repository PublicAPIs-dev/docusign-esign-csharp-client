/* 
 * Docusign eSignature REST API
 *
 * The Docusign eSignature REST API provides you with a powerful, convenient, and simple Web services API for interacting with Docusign.
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
    /// Object specifying the format of the string provided to a recipient in order to access an envelope.
    /// </summary>
    [DataContract]
    public partial class AccessCodeFormat :  IEquatable<AccessCodeFormat>, IValidatableObject
    {
        public AccessCodeFormat()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessCodeFormat" /> class.
        /// </summary>
        /// <param name="FormatRequired">FormatRequired.</param>
        /// <param name="FormatRequiredMetadata">Metadata indicating whether the &#x60;formatRequired&#x60; property is editable..</param>
        /// <param name="LetterRequired">LetterRequired.</param>
        /// <param name="LetterRequiredMetadata">Metadata indicating whether the &#x60;letterRequired&#x60; property is editable..</param>
        /// <param name="MinimumLength">MinimumLength.</param>
        /// <param name="MinimumLengthMetadata">Metadata indicating whether the &#x60;minimumLength&#x60; property is editable..</param>
        /// <param name="NumberRequired">NumberRequired.</param>
        /// <param name="NumberRequiredMetadata">Metadata indicating whether the &#x60;numberRequired&#x60; property is editable..</param>
        /// <param name="SpecialCharacterRequired">SpecialCharacterRequired.</param>
        /// <param name="SpecialCharacterRequiredMetadata">Metadata indicating whether the &#x60;specialCharacterRequired&#x60; property is editable..</param>
        public AccessCodeFormat(string FormatRequired = default(string), SettingsMetadata FormatRequiredMetadata = default(SettingsMetadata), string LetterRequired = default(string), SettingsMetadata LetterRequiredMetadata = default(SettingsMetadata), string MinimumLength = default(string), SettingsMetadata MinimumLengthMetadata = default(SettingsMetadata), string NumberRequired = default(string), SettingsMetadata NumberRequiredMetadata = default(SettingsMetadata), string SpecialCharacterRequired = default(string), SettingsMetadata SpecialCharacterRequiredMetadata = default(SettingsMetadata))
        {
            this.FormatRequired = FormatRequired;
            this.FormatRequiredMetadata = FormatRequiredMetadata;
            this.LetterRequired = LetterRequired;
            this.LetterRequiredMetadata = LetterRequiredMetadata;
            this.MinimumLength = MinimumLength;
            this.MinimumLengthMetadata = MinimumLengthMetadata;
            this.NumberRequired = NumberRequired;
            this.NumberRequiredMetadata = NumberRequiredMetadata;
            this.SpecialCharacterRequired = SpecialCharacterRequired;
            this.SpecialCharacterRequiredMetadata = SpecialCharacterRequiredMetadata;
        }
        
        /// <summary>
        /// Gets or Sets FormatRequired
        /// </summary>
        [DataMember(Name="formatRequired", EmitDefaultValue=false)]
        public string FormatRequired { get; set; }
        /// <summary>
        /// Metadata indicating whether the &#x60;formatRequired&#x60; property is editable.
        /// </summary>
        /// <value>Metadata indicating whether the &#x60;formatRequired&#x60; property is editable.</value>
        [DataMember(Name="formatRequiredMetadata", EmitDefaultValue=false)]
        public SettingsMetadata FormatRequiredMetadata { get; set; }
        /// <summary>
        /// Gets or Sets LetterRequired
        /// </summary>
        [DataMember(Name="letterRequired", EmitDefaultValue=false)]
        public string LetterRequired { get; set; }
        /// <summary>
        /// Metadata indicating whether the &#x60;letterRequired&#x60; property is editable.
        /// </summary>
        /// <value>Metadata indicating whether the &#x60;letterRequired&#x60; property is editable.</value>
        [DataMember(Name="letterRequiredMetadata", EmitDefaultValue=false)]
        public SettingsMetadata LetterRequiredMetadata { get; set; }
        /// <summary>
        /// Gets or Sets MinimumLength
        /// </summary>
        [DataMember(Name="minimumLength", EmitDefaultValue=false)]
        public string MinimumLength { get; set; }
        /// <summary>
        /// Metadata indicating whether the &#x60;minimumLength&#x60; property is editable.
        /// </summary>
        /// <value>Metadata indicating whether the &#x60;minimumLength&#x60; property is editable.</value>
        [DataMember(Name="minimumLengthMetadata", EmitDefaultValue=false)]
        public SettingsMetadata MinimumLengthMetadata { get; set; }
        /// <summary>
        /// Gets or Sets NumberRequired
        /// </summary>
        [DataMember(Name="numberRequired", EmitDefaultValue=false)]
        public string NumberRequired { get; set; }
        /// <summary>
        /// Metadata indicating whether the &#x60;numberRequired&#x60; property is editable.
        /// </summary>
        /// <value>Metadata indicating whether the &#x60;numberRequired&#x60; property is editable.</value>
        [DataMember(Name="numberRequiredMetadata", EmitDefaultValue=false)]
        public SettingsMetadata NumberRequiredMetadata { get; set; }
        /// <summary>
        /// Gets or Sets SpecialCharacterRequired
        /// </summary>
        [DataMember(Name="specialCharacterRequired", EmitDefaultValue=false)]
        public string SpecialCharacterRequired { get; set; }
        /// <summary>
        /// Metadata indicating whether the &#x60;specialCharacterRequired&#x60; property is editable.
        /// </summary>
        /// <value>Metadata indicating whether the &#x60;specialCharacterRequired&#x60; property is editable.</value>
        [DataMember(Name="specialCharacterRequiredMetadata", EmitDefaultValue=false)]
        public SettingsMetadata SpecialCharacterRequiredMetadata { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessCodeFormat {\n");
            sb.Append("  FormatRequired: ").Append(FormatRequired).Append("\n");
            sb.Append("  FormatRequiredMetadata: ").Append(FormatRequiredMetadata).Append("\n");
            sb.Append("  LetterRequired: ").Append(LetterRequired).Append("\n");
            sb.Append("  LetterRequiredMetadata: ").Append(LetterRequiredMetadata).Append("\n");
            sb.Append("  MinimumLength: ").Append(MinimumLength).Append("\n");
            sb.Append("  MinimumLengthMetadata: ").Append(MinimumLengthMetadata).Append("\n");
            sb.Append("  NumberRequired: ").Append(NumberRequired).Append("\n");
            sb.Append("  NumberRequiredMetadata: ").Append(NumberRequiredMetadata).Append("\n");
            sb.Append("  SpecialCharacterRequired: ").Append(SpecialCharacterRequired).Append("\n");
            sb.Append("  SpecialCharacterRequiredMetadata: ").Append(SpecialCharacterRequiredMetadata).Append("\n");
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
            return this.Equals(obj as AccessCodeFormat);
        }

        /// <summary>
        /// Returns true if AccessCodeFormat instances are equal
        /// </summary>
        /// <param name="other">Instance of AccessCodeFormat to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessCodeFormat other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FormatRequired == other.FormatRequired ||
                    this.FormatRequired != null &&
                    this.FormatRequired.Equals(other.FormatRequired)
                ) && 
                (
                    this.FormatRequiredMetadata == other.FormatRequiredMetadata ||
                    this.FormatRequiredMetadata != null &&
                    this.FormatRequiredMetadata.Equals(other.FormatRequiredMetadata)
                ) && 
                (
                    this.LetterRequired == other.LetterRequired ||
                    this.LetterRequired != null &&
                    this.LetterRequired.Equals(other.LetterRequired)
                ) && 
                (
                    this.LetterRequiredMetadata == other.LetterRequiredMetadata ||
                    this.LetterRequiredMetadata != null &&
                    this.LetterRequiredMetadata.Equals(other.LetterRequiredMetadata)
                ) && 
                (
                    this.MinimumLength == other.MinimumLength ||
                    this.MinimumLength != null &&
                    this.MinimumLength.Equals(other.MinimumLength)
                ) && 
                (
                    this.MinimumLengthMetadata == other.MinimumLengthMetadata ||
                    this.MinimumLengthMetadata != null &&
                    this.MinimumLengthMetadata.Equals(other.MinimumLengthMetadata)
                ) && 
                (
                    this.NumberRequired == other.NumberRequired ||
                    this.NumberRequired != null &&
                    this.NumberRequired.Equals(other.NumberRequired)
                ) && 
                (
                    this.NumberRequiredMetadata == other.NumberRequiredMetadata ||
                    this.NumberRequiredMetadata != null &&
                    this.NumberRequiredMetadata.Equals(other.NumberRequiredMetadata)
                ) && 
                (
                    this.SpecialCharacterRequired == other.SpecialCharacterRequired ||
                    this.SpecialCharacterRequired != null &&
                    this.SpecialCharacterRequired.Equals(other.SpecialCharacterRequired)
                ) && 
                (
                    this.SpecialCharacterRequiredMetadata == other.SpecialCharacterRequiredMetadata ||
                    this.SpecialCharacterRequiredMetadata != null &&
                    this.SpecialCharacterRequiredMetadata.Equals(other.SpecialCharacterRequiredMetadata)
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
                if (this.FormatRequired != null)
                    hash = hash * 59 + this.FormatRequired.GetHashCode();
                if (this.FormatRequiredMetadata != null)
                    hash = hash * 59 + this.FormatRequiredMetadata.GetHashCode();
                if (this.LetterRequired != null)
                    hash = hash * 59 + this.LetterRequired.GetHashCode();
                if (this.LetterRequiredMetadata != null)
                    hash = hash * 59 + this.LetterRequiredMetadata.GetHashCode();
                if (this.MinimumLength != null)
                    hash = hash * 59 + this.MinimumLength.GetHashCode();
                if (this.MinimumLengthMetadata != null)
                    hash = hash * 59 + this.MinimumLengthMetadata.GetHashCode();
                if (this.NumberRequired != null)
                    hash = hash * 59 + this.NumberRequired.GetHashCode();
                if (this.NumberRequiredMetadata != null)
                    hash = hash * 59 + this.NumberRequiredMetadata.GetHashCode();
                if (this.SpecialCharacterRequired != null)
                    hash = hash * 59 + this.SpecialCharacterRequired.GetHashCode();
                if (this.SpecialCharacterRequiredMetadata != null)
                    hash = hash * 59 + this.SpecialCharacterRequiredMetadata.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
