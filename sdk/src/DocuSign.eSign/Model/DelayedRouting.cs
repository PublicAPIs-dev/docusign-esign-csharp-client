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
    /// DelayedRouting
    /// </summary>
    [DataContract]
    public partial class DelayedRouting :  IEquatable<DelayedRouting>, IValidatableObject
    {
        public DelayedRouting()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DelayedRouting" /> class.
        /// </summary>
        /// <param name="ResumeDate">An ISO 8601 formatted datetime string indicating the date and time that the envelope is (or was) scheduled to be sent to the recipients associated with the current workflow step or null if the envelope has not yet begun processing the current workflow step..</param>
        /// <param name="Rules">A list of envelope delay rules specified by the user indicating how and when the envelope should be sent in the future for the current workflow step and its associated recipients. Currently only 1 rule may be specified..</param>
        /// <param name="Status">Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later..</param>
        public DelayedRouting(string ResumeDate = default(string), List<EnvelopeDelayRule> Rules = default(List<EnvelopeDelayRule>), string Status = default(string))
        {
            this.ResumeDate = ResumeDate;
            this.Rules = Rules;
            this.Status = Status;
        }
        
        /// <summary>
        /// An ISO 8601 formatted datetime string indicating the date and time that the envelope is (or was) scheduled to be sent to the recipients associated with the current workflow step or null if the envelope has not yet begun processing the current workflow step.
        /// </summary>
        /// <value>An ISO 8601 formatted datetime string indicating the date and time that the envelope is (or was) scheduled to be sent to the recipients associated with the current workflow step or null if the envelope has not yet begun processing the current workflow step.</value>
        [DataMember(Name="resumeDate", EmitDefaultValue=false)]
        public string ResumeDate { get; set; }
        /// <summary>
        /// A list of envelope delay rules specified by the user indicating how and when the envelope should be sent in the future for the current workflow step and its associated recipients. Currently only 1 rule may be specified.
        /// </summary>
        /// <value>A list of envelope delay rules specified by the user indicating how and when the envelope should be sent in the future for the current workflow step and its associated recipients. Currently only 1 rule may be specified.</value>
        [DataMember(Name="rules", EmitDefaultValue=false)]
        public List<EnvelopeDelayRule> Rules { get; set; }
        /// <summary>
        /// Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later.
        /// </summary>
        /// <value>Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DelayedRouting {\n");
            sb.Append("  ResumeDate: ").Append(ResumeDate).Append("\n");
            sb.Append("  Rules: ").Append(Rules).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as DelayedRouting);
        }

        /// <summary>
        /// Returns true if DelayedRouting instances are equal
        /// </summary>
        /// <param name="other">Instance of DelayedRouting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DelayedRouting other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ResumeDate == other.ResumeDate ||
                    this.ResumeDate != null &&
                    this.ResumeDate.Equals(other.ResumeDate)
                ) && 
                (
                    this.Rules == other.Rules ||
                    this.Rules != null &&
                    this.Rules.SequenceEqual(other.Rules)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.ResumeDate != null)
                    hash = hash * 59 + this.ResumeDate.GetHashCode();
                if (this.Rules != null)
                    hash = hash * 59 + this.Rules.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
