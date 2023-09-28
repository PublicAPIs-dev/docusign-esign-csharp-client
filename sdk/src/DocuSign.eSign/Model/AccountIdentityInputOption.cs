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
    /// AccountIdentityInputOption
    /// </summary>
    [DataContract]
    public partial class AccountIdentityInputOption :  IEquatable<AccountIdentityInputOption>, IValidatableObject
    {
        public AccountIdentityInputOption()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountIdentityInputOption" /> class.
        /// </summary>
        /// <param name="IsRequired">IsRequired.</param>
        /// <param name="OptionName">OptionName.</param>
        /// <param name="ValueType">ValueType.</param>
        public AccountIdentityInputOption(bool? IsRequired = default(bool?), string OptionName = default(string), string ValueType = default(string))
        {
            this.IsRequired = IsRequired;
            this.OptionName = OptionName;
            this.ValueType = ValueType;
        }
        
        /// <summary>
        /// Gets or Sets IsRequired
        /// </summary>
        [DataMember(Name="isRequired", EmitDefaultValue=false)]
        public bool? IsRequired { get; set; }
        /// <summary>
        /// Gets or Sets OptionName
        /// </summary>
        [DataMember(Name="optionName", EmitDefaultValue=false)]
        public string OptionName { get; set; }
        /// <summary>
        /// Gets or Sets ValueType
        /// </summary>
        [DataMember(Name="valueType", EmitDefaultValue=false)]
        public string ValueType { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountIdentityInputOption {\n");
            sb.Append("  IsRequired: ").Append(IsRequired).Append("\n");
            sb.Append("  OptionName: ").Append(OptionName).Append("\n");
            sb.Append("  ValueType: ").Append(ValueType).Append("\n");
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
            return this.Equals(obj as AccountIdentityInputOption);
        }

        /// <summary>
        /// Returns true if AccountIdentityInputOption instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountIdentityInputOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountIdentityInputOption other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsRequired == other.IsRequired ||
                    this.IsRequired != null &&
                    this.IsRequired.Equals(other.IsRequired)
                ) && 
                (
                    this.OptionName == other.OptionName ||
                    this.OptionName != null &&
                    this.OptionName.Equals(other.OptionName)
                ) && 
                (
                    this.ValueType == other.ValueType ||
                    this.ValueType != null &&
                    this.ValueType.Equals(other.ValueType)
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
                if (this.IsRequired != null)
                    hash = hash * 59 + this.IsRequired.GetHashCode();
                if (this.OptionName != null)
                    hash = hash * 59 + this.OptionName.GetHashCode();
                if (this.ValueType != null)
                    hash = hash * 59 + this.ValueType.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
