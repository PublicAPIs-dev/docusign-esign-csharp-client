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
    /// EnvelopeAuditEventResponse
    /// </summary>
    [DataContract]
    public partial class EnvelopeAuditEventResponse :  IEquatable<EnvelopeAuditEventResponse>, IValidatableObject
    {
        public EnvelopeAuditEventResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopeAuditEventResponse" /> class.
        /// </summary>
        /// <param name="AuditEvents">Reserved: TBD.</param>
        public EnvelopeAuditEventResponse(List<EnvelopeAuditEvent> AuditEvents = default(List<EnvelopeAuditEvent>))
        {
            this.AuditEvents = AuditEvents;
        }
        
        /// <summary>
        /// Reserved: TBD
        /// </summary>
        /// <value>Reserved: TBD</value>
        [DataMember(Name="auditEvents", EmitDefaultValue=false)]
        public List<EnvelopeAuditEvent> AuditEvents { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopeAuditEventResponse {\n");
            sb.Append("  AuditEvents: ").Append(AuditEvents).Append("\n");
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
            return this.Equals(obj as EnvelopeAuditEventResponse);
        }

        /// <summary>
        /// Returns true if EnvelopeAuditEventResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopeAuditEventResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeAuditEventResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AuditEvents == other.AuditEvents ||
                    this.AuditEvents != null &&
                    this.AuditEvents.SequenceEqual(other.AuditEvents)
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
                if (this.AuditEvents != null)
                    hash = hash * 59 + this.AuditEvents.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
