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
    /// RecipientRules
    /// </summary>
    [DataContract]
    public partial class RecipientRules :  IEquatable<RecipientRules>, IValidatableObject
    {
        public RecipientRules()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientRules" /> class.
        /// </summary>
        /// <param name="ConditionalRecipients">ConditionalRecipients.</param>
        public RecipientRules(List<ConditionalRecipientRule> ConditionalRecipients = default(List<ConditionalRecipientRule>))
        {
            this.ConditionalRecipients = ConditionalRecipients;
        }
        
        /// <summary>
        /// Gets or Sets ConditionalRecipients
        /// </summary>
        [DataMember(Name="conditionalRecipients", EmitDefaultValue=false)]
        public List<ConditionalRecipientRule> ConditionalRecipients { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientRules {\n");
            sb.Append("  ConditionalRecipients: ").Append(ConditionalRecipients).Append("\n");
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
            return this.Equals(obj as RecipientRules);
        }

        /// <summary>
        /// Returns true if RecipientRules instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientRules to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientRules other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ConditionalRecipients == other.ConditionalRecipients ||
                    this.ConditionalRecipients != null &&
                    this.ConditionalRecipients.SequenceEqual(other.ConditionalRecipients)
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
                if (this.ConditionalRecipients != null)
                    hash = hash * 59 + this.ConditionalRecipients.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
