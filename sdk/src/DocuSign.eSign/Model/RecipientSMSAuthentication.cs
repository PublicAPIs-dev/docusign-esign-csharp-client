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
    /// Contains the element senderProvidedNumbers which is an Array  of phone numbers the recipient can use for SMS text authentication.
    /// </summary>
    [DataContract]
    public partial class RecipientSMSAuthentication :  IEquatable<RecipientSMSAuthentication>, IValidatableObject
    {
        public RecipientSMSAuthentication()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientSMSAuthentication" /> class.
        /// </summary>
        /// <param name="SenderProvidedNumbers">An Array containing a list of phone numbers the recipient may use for SMS text authentication. .</param>
        /// <param name="SenderProvidedNumbersMetadata">Metadata that indicates whether the &#x60;senderProvidedNumbers&#x60; property can be edited..</param>
        public RecipientSMSAuthentication(List<string> SenderProvidedNumbers = default(List<string>), PropertyMetadata SenderProvidedNumbersMetadata = default(PropertyMetadata))
        {
            this.SenderProvidedNumbers = SenderProvidedNumbers;
            this.SenderProvidedNumbersMetadata = SenderProvidedNumbersMetadata;
        }
        
        /// <summary>
        /// An Array containing a list of phone numbers the recipient may use for SMS text authentication. 
        /// </summary>
        /// <value>An Array containing a list of phone numbers the recipient may use for SMS text authentication. </value>
        [DataMember(Name="senderProvidedNumbers", EmitDefaultValue=false)]
        public List<string> SenderProvidedNumbers { get; set; }
        /// <summary>
        /// Metadata that indicates whether the &#x60;senderProvidedNumbers&#x60; property can be edited.
        /// </summary>
        /// <value>Metadata that indicates whether the &#x60;senderProvidedNumbers&#x60; property can be edited.</value>
        [DataMember(Name="senderProvidedNumbersMetadata", EmitDefaultValue=false)]
        public PropertyMetadata SenderProvidedNumbersMetadata { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientSMSAuthentication {\n");
            sb.Append("  SenderProvidedNumbers: ").Append(SenderProvidedNumbers).Append("\n");
            sb.Append("  SenderProvidedNumbersMetadata: ").Append(SenderProvidedNumbersMetadata).Append("\n");
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
            return this.Equals(obj as RecipientSMSAuthentication);
        }

        /// <summary>
        /// Returns true if RecipientSMSAuthentication instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientSMSAuthentication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientSMSAuthentication other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SenderProvidedNumbers == other.SenderProvidedNumbers ||
                    this.SenderProvidedNumbers != null &&
                    this.SenderProvidedNumbers.SequenceEqual(other.SenderProvidedNumbers)
                ) && 
                (
                    this.SenderProvidedNumbersMetadata == other.SenderProvidedNumbersMetadata ||
                    this.SenderProvidedNumbersMetadata != null &&
                    this.SenderProvidedNumbersMetadata.Equals(other.SenderProvidedNumbersMetadata)
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
                if (this.SenderProvidedNumbers != null)
                    hash = hash * 59 + this.SenderProvidedNumbers.GetHashCode();
                if (this.SenderProvidedNumbersMetadata != null)
                    hash = hash * 59 + this.SenderProvidedNumbersMetadata.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
