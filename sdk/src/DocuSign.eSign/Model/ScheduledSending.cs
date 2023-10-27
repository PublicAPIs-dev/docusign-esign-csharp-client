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
    /// ScheduledSending
    /// </summary>
    [DataContract]
    public partial class ScheduledSending :  IEquatable<ScheduledSending>, IValidatableObject
    {
        public ScheduledSending()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledSending" /> class.
        /// </summary>
        /// <param name="BulkListId">BulkListId.</param>
        /// <param name="ResumeDate">An ISO 8601 formatted datetime string indicating the date and time that the envelope is (or was) scheduled to be sent or null if the envelope has not yet been sent..</param>
        /// <param name="Rules">A list of envelope delay rules specified by the user indicating how and when the envelope should be scheduled for sending in the future. Currently only 1 rule may be specified..</param>
        /// <param name="Status">\\\&quot;pending\\\&quot; if the envelope has not yet been sent and the scheduled sending delay has not iniaited. \\\&quot;started\\\&quot; if the scheduled sending delay is in progress. \\\&quot;completed\\\&quot; if the scheduled sending delay has elapsed and the envelope has been sent..</param>
        public ScheduledSending(string BulkListId = default(string), string ResumeDate = default(string), List<EnvelopeDelayRule> Rules = default(List<EnvelopeDelayRule>), string Status = default(string))
        {
            this.BulkListId = BulkListId;
            this.ResumeDate = ResumeDate;
            this.Rules = Rules;
            this.Status = Status;
        }
        
        /// <summary>
        /// Gets or Sets BulkListId
        /// </summary>
        [DataMember(Name="bulkListId", EmitDefaultValue=false)]
        public string BulkListId { get; set; }
        /// <summary>
        /// An ISO 8601 formatted datetime string indicating the date and time that the envelope is (or was) scheduled to be sent or null if the envelope has not yet been sent.
        /// </summary>
        /// <value>An ISO 8601 formatted datetime string indicating the date and time that the envelope is (or was) scheduled to be sent or null if the envelope has not yet been sent.</value>
        [DataMember(Name="resumeDate", EmitDefaultValue=false)]
        public string ResumeDate { get; set; }
        /// <summary>
        /// A list of envelope delay rules specified by the user indicating how and when the envelope should be scheduled for sending in the future. Currently only 1 rule may be specified.
        /// </summary>
        /// <value>A list of envelope delay rules specified by the user indicating how and when the envelope should be scheduled for sending in the future. Currently only 1 rule may be specified.</value>
        [DataMember(Name="rules", EmitDefaultValue=false)]
        public List<EnvelopeDelayRule> Rules { get; set; }
        /// <summary>
        /// \\\&quot;pending\\\&quot; if the envelope has not yet been sent and the scheduled sending delay has not iniaited. \\\&quot;started\\\&quot; if the scheduled sending delay is in progress. \\\&quot;completed\\\&quot; if the scheduled sending delay has elapsed and the envelope has been sent.
        /// </summary>
        /// <value>\\\&quot;pending\\\&quot; if the envelope has not yet been sent and the scheduled sending delay has not iniaited. \\\&quot;started\\\&quot; if the scheduled sending delay is in progress. \\\&quot;completed\\\&quot; if the scheduled sending delay has elapsed and the envelope has been sent.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduledSending {\n");
            sb.Append("  BulkListId: ").Append(BulkListId).Append("\n");
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
            return this.Equals(obj as ScheduledSending);
        }

        /// <summary>
        /// Returns true if ScheduledSending instances are equal
        /// </summary>
        /// <param name="other">Instance of ScheduledSending to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduledSending other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BulkListId == other.BulkListId ||
                    this.BulkListId != null &&
                    this.BulkListId.Equals(other.BulkListId)
                ) && 
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
                if (this.BulkListId != null)
                    hash = hash * 59 + this.BulkListId.GetHashCode();
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
