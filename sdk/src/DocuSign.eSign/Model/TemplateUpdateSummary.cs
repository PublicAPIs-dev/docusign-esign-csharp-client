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
    /// TemplateUpdateSummary
    /// </summary>
    [DataContract]
    public partial class TemplateUpdateSummary :  IEquatable<TemplateUpdateSummary>, IValidatableObject
    {
        public TemplateUpdateSummary()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateUpdateSummary" /> class.
        /// </summary>
        /// <param name="BulkEnvelopeStatus">An object that describes the status of the bulk send envelopes..</param>
        /// <param name="EnvelopeId">The envelope ID of the envelope status that failed to post..</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="ListCustomFieldUpdateResults">ListCustomFieldUpdateResults.</param>
        /// <param name="LockInformation">Provides lock information about an envelope that a user has locked..</param>
        /// <param name="PurgeState">PurgeState.</param>
        /// <param name="RecipientUpdateResults">RecipientUpdateResults.</param>
        /// <param name="TabUpdateResults">TabUpdateResults.</param>
        /// <param name="TextCustomFieldUpdateResults">TextCustomFieldUpdateResults.</param>
        public TemplateUpdateSummary(BulkEnvelopeStatus BulkEnvelopeStatus = default(BulkEnvelopeStatus), string EnvelopeId = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), List<ListCustomField> ListCustomFieldUpdateResults = default(List<ListCustomField>), LockInformation LockInformation = default(LockInformation), string PurgeState = default(string), List<RecipientUpdateResponse> RecipientUpdateResults = default(List<RecipientUpdateResponse>), Tabs TabUpdateResults = default(Tabs), List<TextCustomField> TextCustomFieldUpdateResults = default(List<TextCustomField>))
        {
            this.BulkEnvelopeStatus = BulkEnvelopeStatus;
            this.EnvelopeId = EnvelopeId;
            this.ErrorDetails = ErrorDetails;
            this.ListCustomFieldUpdateResults = ListCustomFieldUpdateResults;
            this.LockInformation = LockInformation;
            this.PurgeState = PurgeState;
            this.RecipientUpdateResults = RecipientUpdateResults;
            this.TabUpdateResults = TabUpdateResults;
            this.TextCustomFieldUpdateResults = TextCustomFieldUpdateResults;
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
        /// Gets or Sets ListCustomFieldUpdateResults
        /// </summary>
        [DataMember(Name="listCustomFieldUpdateResults", EmitDefaultValue=false)]
        public List<ListCustomField> ListCustomFieldUpdateResults { get; set; }
        /// <summary>
        /// Provides lock information about an envelope that a user has locked.
        /// </summary>
        /// <value>Provides lock information about an envelope that a user has locked.</value>
        [DataMember(Name="lockInformation", EmitDefaultValue=false)]
        public LockInformation LockInformation { get; set; }
        /// <summary>
        /// Gets or Sets PurgeState
        /// </summary>
        [DataMember(Name="purgeState", EmitDefaultValue=false)]
        public string PurgeState { get; set; }
        /// <summary>
        /// Gets or Sets RecipientUpdateResults
        /// </summary>
        [DataMember(Name="recipientUpdateResults", EmitDefaultValue=false)]
        public List<RecipientUpdateResponse> RecipientUpdateResults { get; set; }
        /// <summary>
        /// Gets or Sets TabUpdateResults
        /// </summary>
        [DataMember(Name="tabUpdateResults", EmitDefaultValue=false)]
        public Tabs TabUpdateResults { get; set; }
        /// <summary>
        /// Gets or Sets TextCustomFieldUpdateResults
        /// </summary>
        [DataMember(Name="textCustomFieldUpdateResults", EmitDefaultValue=false)]
        public List<TextCustomField> TextCustomFieldUpdateResults { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateUpdateSummary {\n");
            sb.Append("  BulkEnvelopeStatus: ").Append(BulkEnvelopeStatus).Append("\n");
            sb.Append("  EnvelopeId: ").Append(EnvelopeId).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  ListCustomFieldUpdateResults: ").Append(ListCustomFieldUpdateResults).Append("\n");
            sb.Append("  LockInformation: ").Append(LockInformation).Append("\n");
            sb.Append("  PurgeState: ").Append(PurgeState).Append("\n");
            sb.Append("  RecipientUpdateResults: ").Append(RecipientUpdateResults).Append("\n");
            sb.Append("  TabUpdateResults: ").Append(TabUpdateResults).Append("\n");
            sb.Append("  TextCustomFieldUpdateResults: ").Append(TextCustomFieldUpdateResults).Append("\n");
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
            return this.Equals(obj as TemplateUpdateSummary);
        }

        /// <summary>
        /// Returns true if TemplateUpdateSummary instances are equal
        /// </summary>
        /// <param name="other">Instance of TemplateUpdateSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateUpdateSummary other)
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
                    this.ListCustomFieldUpdateResults == other.ListCustomFieldUpdateResults ||
                    this.ListCustomFieldUpdateResults != null &&
                    this.ListCustomFieldUpdateResults.SequenceEqual(other.ListCustomFieldUpdateResults)
                ) && 
                (
                    this.LockInformation == other.LockInformation ||
                    this.LockInformation != null &&
                    this.LockInformation.Equals(other.LockInformation)
                ) && 
                (
                    this.PurgeState == other.PurgeState ||
                    this.PurgeState != null &&
                    this.PurgeState.Equals(other.PurgeState)
                ) && 
                (
                    this.RecipientUpdateResults == other.RecipientUpdateResults ||
                    this.RecipientUpdateResults != null &&
                    this.RecipientUpdateResults.SequenceEqual(other.RecipientUpdateResults)
                ) && 
                (
                    this.TabUpdateResults == other.TabUpdateResults ||
                    this.TabUpdateResults != null &&
                    this.TabUpdateResults.Equals(other.TabUpdateResults)
                ) && 
                (
                    this.TextCustomFieldUpdateResults == other.TextCustomFieldUpdateResults ||
                    this.TextCustomFieldUpdateResults != null &&
                    this.TextCustomFieldUpdateResults.SequenceEqual(other.TextCustomFieldUpdateResults)
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
                if (this.ListCustomFieldUpdateResults != null)
                    hash = hash * 59 + this.ListCustomFieldUpdateResults.GetHashCode();
                if (this.LockInformation != null)
                    hash = hash * 59 + this.LockInformation.GetHashCode();
                if (this.PurgeState != null)
                    hash = hash * 59 + this.PurgeState.GetHashCode();
                if (this.RecipientUpdateResults != null)
                    hash = hash * 59 + this.RecipientUpdateResults.GetHashCode();
                if (this.TabUpdateResults != null)
                    hash = hash * 59 + this.TabUpdateResults.GetHashCode();
                if (this.TextCustomFieldUpdateResults != null)
                    hash = hash * 59 + this.TextCustomFieldUpdateResults.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
