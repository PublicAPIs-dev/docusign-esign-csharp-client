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
    /// Result of &#x60;getBulkSendBatchStatus&#x60;
    /// </summary>
    [DataContract]
    public partial class BulkSendBatchStatus :  IEquatable<BulkSendBatchStatus>, IValidatableObject
    {
        public BulkSendBatchStatus()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSendBatchStatus" /> class.
        /// </summary>
        /// <param name="Action">Action.</param>
        /// <param name="ActionStatus">ActionStatus.</param>
        /// <param name="BatchId">BatchId.</param>
        /// <param name="BatchName">BatchName.</param>
        /// <param name="BatchSize">BatchSize.</param>
        /// <param name="BulkErrors">BulkErrors.</param>
        /// <param name="EnvelopeIdOrTemplateId">EnvelopeIdOrTemplateId.</param>
        /// <param name="EnvelopesInfo">EnvelopesInfo.</param>
        /// <param name="EnvelopesUri">EnvelopesUri.</param>
        /// <param name="Failed">Failed.</param>
        /// <param name="MailingListId">MailingListId.</param>
        /// <param name="MailingListName">MailingListName.</param>
        /// <param name="OwnerUserId">OwnerUserId.</param>
        /// <param name="Queued">Queued.</param>
        /// <param name="ResendsRemaining">ResendsRemaining.</param>
        /// <param name="SenderUserId">SenderUserId.</param>
        /// <param name="Sent">Sent.</param>
        /// <param name="SubmittedDate">SubmittedDate.</param>
        public BulkSendBatchStatus(string Action = default(string), string ActionStatus = default(string), string BatchId = default(string), string BatchName = default(string), string BatchSize = default(string), List<BulkSendErrorStatus> BulkErrors = default(List<BulkSendErrorStatus>), string EnvelopeIdOrTemplateId = default(string), BulkSendEnvelopesInfo EnvelopesInfo = default(BulkSendEnvelopesInfo), string EnvelopesUri = default(string), string Failed = default(string), string MailingListId = default(string), string MailingListName = default(string), string OwnerUserId = default(string), string Queued = default(string), string ResendsRemaining = default(string), string SenderUserId = default(string), string Sent = default(string), string SubmittedDate = default(string))
        {
            this.Action = Action;
            this.ActionStatus = ActionStatus;
            this.BatchId = BatchId;
            this.BatchName = BatchName;
            this.BatchSize = BatchSize;
            this.BulkErrors = BulkErrors;
            this.EnvelopeIdOrTemplateId = EnvelopeIdOrTemplateId;
            this.EnvelopesInfo = EnvelopesInfo;
            this.EnvelopesUri = EnvelopesUri;
            this.Failed = Failed;
            this.MailingListId = MailingListId;
            this.MailingListName = MailingListName;
            this.OwnerUserId = OwnerUserId;
            this.Queued = Queued;
            this.ResendsRemaining = ResendsRemaining;
            this.SenderUserId = SenderUserId;
            this.Sent = Sent;
            this.SubmittedDate = SubmittedDate;
        }
        
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public string Action { get; set; }
        /// <summary>
        /// Gets or Sets ActionStatus
        /// </summary>
        [DataMember(Name="actionStatus", EmitDefaultValue=false)]
        public string ActionStatus { get; set; }
        /// <summary>
        /// Gets or Sets BatchId
        /// </summary>
        [DataMember(Name="batchId", EmitDefaultValue=false)]
        public string BatchId { get; set; }
        /// <summary>
        /// Gets or Sets BatchName
        /// </summary>
        [DataMember(Name="batchName", EmitDefaultValue=false)]
        public string BatchName { get; set; }
        /// <summary>
        /// Gets or Sets BatchSize
        /// </summary>
        [DataMember(Name="batchSize", EmitDefaultValue=false)]
        public string BatchSize { get; set; }
        /// <summary>
        /// Gets or Sets BulkErrors
        /// </summary>
        [DataMember(Name="bulkErrors", EmitDefaultValue=false)]
        public List<BulkSendErrorStatus> BulkErrors { get; set; }
        /// <summary>
        /// Gets or Sets EnvelopeIdOrTemplateId
        /// </summary>
        [DataMember(Name="envelopeIdOrTemplateId", EmitDefaultValue=false)]
        public string EnvelopeIdOrTemplateId { get; set; }
        /// <summary>
        /// Gets or Sets EnvelopesInfo
        /// </summary>
        [DataMember(Name="envelopesInfo", EmitDefaultValue=false)]
        public BulkSendEnvelopesInfo EnvelopesInfo { get; set; }
        /// <summary>
        /// Gets or Sets EnvelopesUri
        /// </summary>
        [DataMember(Name="envelopesUri", EmitDefaultValue=false)]
        public string EnvelopesUri { get; set; }
        /// <summary>
        /// Gets or Sets Failed
        /// </summary>
        [DataMember(Name="failed", EmitDefaultValue=false)]
        public string Failed { get; set; }
        /// <summary>
        /// Gets or Sets MailingListId
        /// </summary>
        [DataMember(Name="mailingListId", EmitDefaultValue=false)]
        public string MailingListId { get; set; }
        /// <summary>
        /// Gets or Sets MailingListName
        /// </summary>
        [DataMember(Name="mailingListName", EmitDefaultValue=false)]
        public string MailingListName { get; set; }
        /// <summary>
        /// Gets or Sets OwnerUserId
        /// </summary>
        [DataMember(Name="ownerUserId", EmitDefaultValue=false)]
        public string OwnerUserId { get; set; }
        /// <summary>
        /// Gets or Sets Queued
        /// </summary>
        [DataMember(Name="queued", EmitDefaultValue=false)]
        public string Queued { get; set; }
        /// <summary>
        /// Gets or Sets ResendsRemaining
        /// </summary>
        [DataMember(Name="resendsRemaining", EmitDefaultValue=false)]
        public string ResendsRemaining { get; set; }
        /// <summary>
        /// Gets or Sets SenderUserId
        /// </summary>
        [DataMember(Name="senderUserId", EmitDefaultValue=false)]
        public string SenderUserId { get; set; }
        /// <summary>
        /// Gets or Sets Sent
        /// </summary>
        [DataMember(Name="sent", EmitDefaultValue=false)]
        public string Sent { get; set; }
        /// <summary>
        /// Gets or Sets SubmittedDate
        /// </summary>
        [DataMember(Name="submittedDate", EmitDefaultValue=false)]
        public string SubmittedDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkSendBatchStatus {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  ActionStatus: ").Append(ActionStatus).Append("\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  BatchName: ").Append(BatchName).Append("\n");
            sb.Append("  BatchSize: ").Append(BatchSize).Append("\n");
            sb.Append("  BulkErrors: ").Append(BulkErrors).Append("\n");
            sb.Append("  EnvelopeIdOrTemplateId: ").Append(EnvelopeIdOrTemplateId).Append("\n");
            sb.Append("  EnvelopesInfo: ").Append(EnvelopesInfo).Append("\n");
            sb.Append("  EnvelopesUri: ").Append(EnvelopesUri).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  MailingListId: ").Append(MailingListId).Append("\n");
            sb.Append("  MailingListName: ").Append(MailingListName).Append("\n");
            sb.Append("  OwnerUserId: ").Append(OwnerUserId).Append("\n");
            sb.Append("  Queued: ").Append(Queued).Append("\n");
            sb.Append("  ResendsRemaining: ").Append(ResendsRemaining).Append("\n");
            sb.Append("  SenderUserId: ").Append(SenderUserId).Append("\n");
            sb.Append("  Sent: ").Append(Sent).Append("\n");
            sb.Append("  SubmittedDate: ").Append(SubmittedDate).Append("\n");
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
            return this.Equals(obj as BulkSendBatchStatus);
        }

        /// <summary>
        /// Returns true if BulkSendBatchStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkSendBatchStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkSendBatchStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
                ) && 
                (
                    this.ActionStatus == other.ActionStatus ||
                    this.ActionStatus != null &&
                    this.ActionStatus.Equals(other.ActionStatus)
                ) && 
                (
                    this.BatchId == other.BatchId ||
                    this.BatchId != null &&
                    this.BatchId.Equals(other.BatchId)
                ) && 
                (
                    this.BatchName == other.BatchName ||
                    this.BatchName != null &&
                    this.BatchName.Equals(other.BatchName)
                ) && 
                (
                    this.BatchSize == other.BatchSize ||
                    this.BatchSize != null &&
                    this.BatchSize.Equals(other.BatchSize)
                ) && 
                (
                    this.BulkErrors == other.BulkErrors ||
                    this.BulkErrors != null &&
                    this.BulkErrors.SequenceEqual(other.BulkErrors)
                ) && 
                (
                    this.EnvelopeIdOrTemplateId == other.EnvelopeIdOrTemplateId ||
                    this.EnvelopeIdOrTemplateId != null &&
                    this.EnvelopeIdOrTemplateId.Equals(other.EnvelopeIdOrTemplateId)
                ) && 
                (
                    this.EnvelopesInfo == other.EnvelopesInfo ||
                    this.EnvelopesInfo != null &&
                    this.EnvelopesInfo.Equals(other.EnvelopesInfo)
                ) && 
                (
                    this.EnvelopesUri == other.EnvelopesUri ||
                    this.EnvelopesUri != null &&
                    this.EnvelopesUri.Equals(other.EnvelopesUri)
                ) && 
                (
                    this.Failed == other.Failed ||
                    this.Failed != null &&
                    this.Failed.Equals(other.Failed)
                ) && 
                (
                    this.MailingListId == other.MailingListId ||
                    this.MailingListId != null &&
                    this.MailingListId.Equals(other.MailingListId)
                ) && 
                (
                    this.MailingListName == other.MailingListName ||
                    this.MailingListName != null &&
                    this.MailingListName.Equals(other.MailingListName)
                ) && 
                (
                    this.OwnerUserId == other.OwnerUserId ||
                    this.OwnerUserId != null &&
                    this.OwnerUserId.Equals(other.OwnerUserId)
                ) && 
                (
                    this.Queued == other.Queued ||
                    this.Queued != null &&
                    this.Queued.Equals(other.Queued)
                ) && 
                (
                    this.ResendsRemaining == other.ResendsRemaining ||
                    this.ResendsRemaining != null &&
                    this.ResendsRemaining.Equals(other.ResendsRemaining)
                ) && 
                (
                    this.SenderUserId == other.SenderUserId ||
                    this.SenderUserId != null &&
                    this.SenderUserId.Equals(other.SenderUserId)
                ) && 
                (
                    this.Sent == other.Sent ||
                    this.Sent != null &&
                    this.Sent.Equals(other.Sent)
                ) && 
                (
                    this.SubmittedDate == other.SubmittedDate ||
                    this.SubmittedDate != null &&
                    this.SubmittedDate.Equals(other.SubmittedDate)
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
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                if (this.ActionStatus != null)
                    hash = hash * 59 + this.ActionStatus.GetHashCode();
                if (this.BatchId != null)
                    hash = hash * 59 + this.BatchId.GetHashCode();
                if (this.BatchName != null)
                    hash = hash * 59 + this.BatchName.GetHashCode();
                if (this.BatchSize != null)
                    hash = hash * 59 + this.BatchSize.GetHashCode();
                if (this.BulkErrors != null)
                    hash = hash * 59 + this.BulkErrors.GetHashCode();
                if (this.EnvelopeIdOrTemplateId != null)
                    hash = hash * 59 + this.EnvelopeIdOrTemplateId.GetHashCode();
                if (this.EnvelopesInfo != null)
                    hash = hash * 59 + this.EnvelopesInfo.GetHashCode();
                if (this.EnvelopesUri != null)
                    hash = hash * 59 + this.EnvelopesUri.GetHashCode();
                if (this.Failed != null)
                    hash = hash * 59 + this.Failed.GetHashCode();
                if (this.MailingListId != null)
                    hash = hash * 59 + this.MailingListId.GetHashCode();
                if (this.MailingListName != null)
                    hash = hash * 59 + this.MailingListName.GetHashCode();
                if (this.OwnerUserId != null)
                    hash = hash * 59 + this.OwnerUserId.GetHashCode();
                if (this.Queued != null)
                    hash = hash * 59 + this.Queued.GetHashCode();
                if (this.ResendsRemaining != null)
                    hash = hash * 59 + this.ResendsRemaining.GetHashCode();
                if (this.SenderUserId != null)
                    hash = hash * 59 + this.SenderUserId.GetHashCode();
                if (this.Sent != null)
                    hash = hash * 59 + this.Sent.GetHashCode();
                if (this.SubmittedDate != null)
                    hash = hash * 59 + this.SubmittedDate.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
