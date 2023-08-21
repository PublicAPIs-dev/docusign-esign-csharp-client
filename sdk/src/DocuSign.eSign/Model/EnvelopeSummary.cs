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
    ///  This object describes an envelope.
    /// </summary>
    [DataContract]
    public partial class EnvelopeSummary :  IEquatable<EnvelopeSummary>, IValidatableObject
    {
        public EnvelopeSummary()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopeSummary" /> class.
        /// </summary>
        /// <param name="BulkEnvelopeStatus">An object that describes the status of the bulk send envelopes..</param>
        /// <param name="EnvelopeId">The envelope ID of the envelope status that failed to post..</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="RecipientSigningUri">RecipientSigningUri.</param>
        /// <param name="RecipientSigningUriError">RecipientSigningUriError.</param>
        /// <param name="Status">Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later..</param>
        /// <param name="StatusDateTime">The DateTime that the envelope changed status (i.e. was created or sent.).</param>
        /// <param name="Uri">Uri.</param>
        public EnvelopeSummary(BulkEnvelopeStatus BulkEnvelopeStatus = default(BulkEnvelopeStatus), string EnvelopeId = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string RecipientSigningUri = default(string), string RecipientSigningUriError = default(string), string Status = default(string), string StatusDateTime = default(string), string Uri = default(string))
        {
            this.BulkEnvelopeStatus = BulkEnvelopeStatus;
            this.EnvelopeId = EnvelopeId;
            this.ErrorDetails = ErrorDetails;
            this.RecipientSigningUri = RecipientSigningUri;
            this.RecipientSigningUriError = RecipientSigningUriError;
            this.Status = Status;
            this.StatusDateTime = StatusDateTime;
            this.Uri = Uri;
        }
        
        /// <summary>
        /// An object that describes the status of the bulk send envelopes.
        /// </summary>
        /// <value>An object that describes the status of the bulk send envelopes.</value>
        [DataMember(Name="bulkEnvelopeStatus", EmitDefaultValue=false)]
        public BulkEnvelopeStatus BulkEnvelopeStatus { get; set; }
        /// <summary>
        /// The envelope ID of the envelope status that failed to post.
        /// </summary>
        /// <value>The envelope ID of the envelope status that failed to post.</value>
        [DataMember(Name="envelopeId", EmitDefaultValue=false)]
        public string EnvelopeId { get; set; }
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Gets or Sets RecipientSigningUri
        /// </summary>
        [DataMember(Name="recipientSigningUri", EmitDefaultValue=false)]
        public string RecipientSigningUri { get; set; }
        /// <summary>
        /// Gets or Sets RecipientSigningUriError
        /// </summary>
        [DataMember(Name="recipientSigningUriError", EmitDefaultValue=false)]
        public string RecipientSigningUriError { get; set; }
        /// <summary>
        /// Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later.
        /// </summary>
        /// <value>Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// The DateTime that the envelope changed status (i.e. was created or sent.)
        /// </summary>
        /// <value>The DateTime that the envelope changed status (i.e. was created or sent.)</value>
        [DataMember(Name="statusDateTime", EmitDefaultValue=false)]
        public string StatusDateTime { get; set; }
        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopeSummary {\n");
            sb.Append("  BulkEnvelopeStatus: ").Append(BulkEnvelopeStatus).Append("\n");
            sb.Append("  EnvelopeId: ").Append(EnvelopeId).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  RecipientSigningUri: ").Append(RecipientSigningUri).Append("\n");
            sb.Append("  RecipientSigningUriError: ").Append(RecipientSigningUriError).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusDateTime: ").Append(StatusDateTime).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
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
            return this.Equals(obj as EnvelopeSummary);
        }

        /// <summary>
        /// Returns true if EnvelopeSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopeSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeSummary other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BulkEnvelopeStatus == other.BulkEnvelopeStatus ||
                    this.BulkEnvelopeStatus != null &&
                    this.BulkEnvelopeStatus.Equals(other.BulkEnvelopeStatus)
                ) && 
                (
                    this.EnvelopeId == other.EnvelopeId ||
                    this.EnvelopeId != null &&
                    this.EnvelopeId.Equals(other.EnvelopeId)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.RecipientSigningUri == other.RecipientSigningUri ||
                    this.RecipientSigningUri != null &&
                    this.RecipientSigningUri.Equals(other.RecipientSigningUri)
                ) && 
                (
                    this.RecipientSigningUriError == other.RecipientSigningUriError ||
                    this.RecipientSigningUriError != null &&
                    this.RecipientSigningUriError.Equals(other.RecipientSigningUriError)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusDateTime == other.StatusDateTime ||
                    this.StatusDateTime != null &&
                    this.StatusDateTime.Equals(other.StatusDateTime)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
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
                if (this.BulkEnvelopeStatus != null)
                    hash = hash * 59 + this.BulkEnvelopeStatus.GetHashCode();
                if (this.EnvelopeId != null)
                    hash = hash * 59 + this.EnvelopeId.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.RecipientSigningUri != null)
                    hash = hash * 59 + this.RecipientSigningUri.GetHashCode();
                if (this.RecipientSigningUriError != null)
                    hash = hash * 59 + this.RecipientSigningUriError.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.StatusDateTime != null)
                    hash = hash * 59 + this.StatusDateTime.GetHashCode();
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
