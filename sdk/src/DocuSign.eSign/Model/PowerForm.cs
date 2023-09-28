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
    /// Contains details about a PowerForm.
    /// </summary>
    [DataContract]
    public partial class PowerForm :  IEquatable<PowerForm>, IValidatableObject
    {
        public PowerForm()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerForm" /> class.
        /// </summary>
        /// <param name="CreatedBy">CreatedBy.</param>
        /// <param name="CreatedDateTime">Indicates the date and time the item was created..</param>
        /// <param name="EmailBody">Specifies the email body of the message sent to the recipient.   Maximum length: 10000 characters. .</param>
        /// <param name="EmailSubject">Specifies the subject of the email that is sent to all recipients.  See [ML:Template Email Subject Merge Fields] for information about adding merge field information to the email subject..</param>
        /// <param name="Envelopes">Envelopes.</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="Instructions">Instructions.</param>
        /// <param name="IsActive">IsActive.</param>
        /// <param name="LastUsed">LastUsed.</param>
        /// <param name="LimitUseInterval">LimitUseInterval.</param>
        /// <param name="LimitUseIntervalEnabled">LimitUseIntervalEnabled.</param>
        /// <param name="LimitUseIntervalUnits">LimitUseIntervalUnits.</param>
        /// <param name="MaxUseEnabled">MaxUseEnabled.</param>
        /// <param name="Name">Name.</param>
        /// <param name="PowerFormId">PowerFormId.</param>
        /// <param name="PowerFormUrl">PowerFormUrl.</param>
        /// <param name="Recipients">An array of powerform recipients..</param>
        /// <param name="SenderName">SenderName.</param>
        /// <param name="SenderUserId">SenderUserId.</param>
        /// <param name="SigningMode">SigningMode.</param>
        /// <param name="TemplateId">The unique identifier of the template. If this is not provided, DocuSign will generate a value. .</param>
        /// <param name="TemplateName">TemplateName.</param>
        /// <param name="TimesUsed">TimesUsed.</param>
        /// <param name="Uri">Uri.</param>
        /// <param name="UsesRemaining">UsesRemaining.</param>
        public PowerForm(string CreatedBy = default(string), string CreatedDateTime = default(string), string EmailBody = default(string), string EmailSubject = default(string), List<Envelope> Envelopes = default(List<Envelope>), ErrorDetails ErrorDetails = default(ErrorDetails), string Instructions = default(string), string IsActive = default(string), string LastUsed = default(string), string LimitUseInterval = default(string), string LimitUseIntervalEnabled = default(string), string LimitUseIntervalUnits = default(string), string MaxUseEnabled = default(string), string Name = default(string), string PowerFormId = default(string), string PowerFormUrl = default(string), List<PowerFormRecipient> Recipients = default(List<PowerFormRecipient>), string SenderName = default(string), string SenderUserId = default(string), string SigningMode = default(string), string TemplateId = default(string), string TemplateName = default(string), string TimesUsed = default(string), string Uri = default(string), string UsesRemaining = default(string))
        {
            this.CreatedBy = CreatedBy;
            this.CreatedDateTime = CreatedDateTime;
            this.EmailBody = EmailBody;
            this.EmailSubject = EmailSubject;
            this.Envelopes = Envelopes;
            this.ErrorDetails = ErrorDetails;
            this.Instructions = Instructions;
            this.IsActive = IsActive;
            this.LastUsed = LastUsed;
            this.LimitUseInterval = LimitUseInterval;
            this.LimitUseIntervalEnabled = LimitUseIntervalEnabled;
            this.LimitUseIntervalUnits = LimitUseIntervalUnits;
            this.MaxUseEnabled = MaxUseEnabled;
            this.Name = Name;
            this.PowerFormId = PowerFormId;
            this.PowerFormUrl = PowerFormUrl;
            this.Recipients = Recipients;
            this.SenderName = SenderName;
            this.SenderUserId = SenderUserId;
            this.SigningMode = SigningMode;
            this.TemplateId = TemplateId;
            this.TemplateName = TemplateName;
            this.TimesUsed = TimesUsed;
            this.Uri = Uri;
            this.UsesRemaining = UsesRemaining;
        }
        
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }
        /// <summary>
        /// Indicates the date and time the item was created.
        /// </summary>
        /// <value>Indicates the date and time the item was created.</value>
        [DataMember(Name="createdDateTime", EmitDefaultValue=false)]
        public string CreatedDateTime { get; set; }
        /// <summary>
        /// Specifies the email body of the message sent to the recipient.   Maximum length: 10000 characters. 
        /// </summary>
        /// <value>Specifies the email body of the message sent to the recipient.   Maximum length: 10000 characters. </value>
        [DataMember(Name="emailBody", EmitDefaultValue=false)]
        public string EmailBody { get; set; }
        /// <summary>
        /// Specifies the subject of the email that is sent to all recipients.  See [ML:Template Email Subject Merge Fields] for information about adding merge field information to the email subject.
        /// </summary>
        /// <value>Specifies the subject of the email that is sent to all recipients.  See [ML:Template Email Subject Merge Fields] for information about adding merge field information to the email subject.</value>
        [DataMember(Name="emailSubject", EmitDefaultValue=false)]
        public string EmailSubject { get; set; }
        /// <summary>
        /// Gets or Sets Envelopes
        /// </summary>
        [DataMember(Name="envelopes", EmitDefaultValue=false)]
        public List<Envelope> Envelopes { get; set; }
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Gets or Sets Instructions
        /// </summary>
        [DataMember(Name="instructions", EmitDefaultValue=false)]
        public string Instructions { get; set; }
        /// <summary>
        /// Gets or Sets IsActive
        /// </summary>
        [DataMember(Name="isActive", EmitDefaultValue=false)]
        public string IsActive { get; set; }
        /// <summary>
        /// Gets or Sets LastUsed
        /// </summary>
        [DataMember(Name="lastUsed", EmitDefaultValue=false)]
        public string LastUsed { get; set; }
        /// <summary>
        /// Gets or Sets LimitUseInterval
        /// </summary>
        [DataMember(Name="limitUseInterval", EmitDefaultValue=false)]
        public string LimitUseInterval { get; set; }
        /// <summary>
        /// Gets or Sets LimitUseIntervalEnabled
        /// </summary>
        [DataMember(Name="limitUseIntervalEnabled", EmitDefaultValue=false)]
        public string LimitUseIntervalEnabled { get; set; }
        /// <summary>
        /// Gets or Sets LimitUseIntervalUnits
        /// </summary>
        [DataMember(Name="limitUseIntervalUnits", EmitDefaultValue=false)]
        public string LimitUseIntervalUnits { get; set; }
        /// <summary>
        /// Gets or Sets MaxUseEnabled
        /// </summary>
        [DataMember(Name="maxUseEnabled", EmitDefaultValue=false)]
        public string MaxUseEnabled { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets PowerFormId
        /// </summary>
        [DataMember(Name="powerFormId", EmitDefaultValue=false)]
        public string PowerFormId { get; set; }
        /// <summary>
        /// Gets or Sets PowerFormUrl
        /// </summary>
        [DataMember(Name="powerFormUrl", EmitDefaultValue=false)]
        public string PowerFormUrl { get; set; }
        /// <summary>
        /// An array of powerform recipients.
        /// </summary>
        /// <value>An array of powerform recipients.</value>
        [DataMember(Name="recipients", EmitDefaultValue=false)]
        public List<PowerFormRecipient> Recipients { get; set; }
        /// <summary>
        /// Gets or Sets SenderName
        /// </summary>
        [DataMember(Name="senderName", EmitDefaultValue=false)]
        public string SenderName { get; set; }
        /// <summary>
        /// Gets or Sets SenderUserId
        /// </summary>
        [DataMember(Name="senderUserId", EmitDefaultValue=false)]
        public string SenderUserId { get; set; }
        /// <summary>
        /// Gets or Sets SigningMode
        /// </summary>
        [DataMember(Name="signingMode", EmitDefaultValue=false)]
        public string SigningMode { get; set; }
        /// <summary>
        /// The unique identifier of the template. If this is not provided, DocuSign will generate a value. 
        /// </summary>
        /// <value>The unique identifier of the template. If this is not provided, DocuSign will generate a value. </value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }
        /// <summary>
        /// Gets or Sets TemplateName
        /// </summary>
        [DataMember(Name="templateName", EmitDefaultValue=false)]
        public string TemplateName { get; set; }
        /// <summary>
        /// Gets or Sets TimesUsed
        /// </summary>
        [DataMember(Name="timesUsed", EmitDefaultValue=false)]
        public string TimesUsed { get; set; }
        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name="uri", EmitDefaultValue=false)]
        public string Uri { get; set; }
        /// <summary>
        /// Gets or Sets UsesRemaining
        /// </summary>
        [DataMember(Name="usesRemaining", EmitDefaultValue=false)]
        public string UsesRemaining { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PowerForm {\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  EmailBody: ").Append(EmailBody).Append("\n");
            sb.Append("  EmailSubject: ").Append(EmailSubject).Append("\n");
            sb.Append("  Envelopes: ").Append(Envelopes).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Instructions: ").Append(Instructions).Append("\n");
            sb.Append("  IsActive: ").Append(IsActive).Append("\n");
            sb.Append("  LastUsed: ").Append(LastUsed).Append("\n");
            sb.Append("  LimitUseInterval: ").Append(LimitUseInterval).Append("\n");
            sb.Append("  LimitUseIntervalEnabled: ").Append(LimitUseIntervalEnabled).Append("\n");
            sb.Append("  LimitUseIntervalUnits: ").Append(LimitUseIntervalUnits).Append("\n");
            sb.Append("  MaxUseEnabled: ").Append(MaxUseEnabled).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PowerFormId: ").Append(PowerFormId).Append("\n");
            sb.Append("  PowerFormUrl: ").Append(PowerFormUrl).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  SenderName: ").Append(SenderName).Append("\n");
            sb.Append("  SenderUserId: ").Append(SenderUserId).Append("\n");
            sb.Append("  SigningMode: ").Append(SigningMode).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  TemplateName: ").Append(TemplateName).Append("\n");
            sb.Append("  TimesUsed: ").Append(TimesUsed).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  UsesRemaining: ").Append(UsesRemaining).Append("\n");
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
            return this.Equals(obj as PowerForm);
        }

        /// <summary>
        /// Returns true if PowerForm instances are equal
        /// </summary>
        /// <param name="other">Instance of PowerForm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PowerForm other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    this.CreatedDateTime == other.CreatedDateTime ||
                    this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(other.CreatedDateTime)
                ) && 
                (
                    this.EmailBody == other.EmailBody ||
                    this.EmailBody != null &&
                    this.EmailBody.Equals(other.EmailBody)
                ) && 
                (
                    this.EmailSubject == other.EmailSubject ||
                    this.EmailSubject != null &&
                    this.EmailSubject.Equals(other.EmailSubject)
                ) && 
                (
                    this.Envelopes == other.Envelopes ||
                    this.Envelopes != null &&
                    this.Envelopes.SequenceEqual(other.Envelopes)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.Instructions == other.Instructions ||
                    this.Instructions != null &&
                    this.Instructions.Equals(other.Instructions)
                ) && 
                (
                    this.IsActive == other.IsActive ||
                    this.IsActive != null &&
                    this.IsActive.Equals(other.IsActive)
                ) && 
                (
                    this.LastUsed == other.LastUsed ||
                    this.LastUsed != null &&
                    this.LastUsed.Equals(other.LastUsed)
                ) && 
                (
                    this.LimitUseInterval == other.LimitUseInterval ||
                    this.LimitUseInterval != null &&
                    this.LimitUseInterval.Equals(other.LimitUseInterval)
                ) && 
                (
                    this.LimitUseIntervalEnabled == other.LimitUseIntervalEnabled ||
                    this.LimitUseIntervalEnabled != null &&
                    this.LimitUseIntervalEnabled.Equals(other.LimitUseIntervalEnabled)
                ) && 
                (
                    this.LimitUseIntervalUnits == other.LimitUseIntervalUnits ||
                    this.LimitUseIntervalUnits != null &&
                    this.LimitUseIntervalUnits.Equals(other.LimitUseIntervalUnits)
                ) && 
                (
                    this.MaxUseEnabled == other.MaxUseEnabled ||
                    this.MaxUseEnabled != null &&
                    this.MaxUseEnabled.Equals(other.MaxUseEnabled)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.PowerFormId == other.PowerFormId ||
                    this.PowerFormId != null &&
                    this.PowerFormId.Equals(other.PowerFormId)
                ) && 
                (
                    this.PowerFormUrl == other.PowerFormUrl ||
                    this.PowerFormUrl != null &&
                    this.PowerFormUrl.Equals(other.PowerFormUrl)
                ) && 
                (
                    this.Recipients == other.Recipients ||
                    this.Recipients != null &&
                    this.Recipients.SequenceEqual(other.Recipients)
                ) && 
                (
                    this.SenderName == other.SenderName ||
                    this.SenderName != null &&
                    this.SenderName.Equals(other.SenderName)
                ) && 
                (
                    this.SenderUserId == other.SenderUserId ||
                    this.SenderUserId != null &&
                    this.SenderUserId.Equals(other.SenderUserId)
                ) && 
                (
                    this.SigningMode == other.SigningMode ||
                    this.SigningMode != null &&
                    this.SigningMode.Equals(other.SigningMode)
                ) && 
                (
                    this.TemplateId == other.TemplateId ||
                    this.TemplateId != null &&
                    this.TemplateId.Equals(other.TemplateId)
                ) && 
                (
                    this.TemplateName == other.TemplateName ||
                    this.TemplateName != null &&
                    this.TemplateName.Equals(other.TemplateName)
                ) && 
                (
                    this.TimesUsed == other.TimesUsed ||
                    this.TimesUsed != null &&
                    this.TimesUsed.Equals(other.TimesUsed)
                ) && 
                (
                    this.Uri == other.Uri ||
                    this.Uri != null &&
                    this.Uri.Equals(other.Uri)
                ) && 
                (
                    this.UsesRemaining == other.UsesRemaining ||
                    this.UsesRemaining != null &&
                    this.UsesRemaining.Equals(other.UsesRemaining)
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
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedDateTime != null)
                    hash = hash * 59 + this.CreatedDateTime.GetHashCode();
                if (this.EmailBody != null)
                    hash = hash * 59 + this.EmailBody.GetHashCode();
                if (this.EmailSubject != null)
                    hash = hash * 59 + this.EmailSubject.GetHashCode();
                if (this.Envelopes != null)
                    hash = hash * 59 + this.Envelopes.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.Instructions != null)
                    hash = hash * 59 + this.Instructions.GetHashCode();
                if (this.IsActive != null)
                    hash = hash * 59 + this.IsActive.GetHashCode();
                if (this.LastUsed != null)
                    hash = hash * 59 + this.LastUsed.GetHashCode();
                if (this.LimitUseInterval != null)
                    hash = hash * 59 + this.LimitUseInterval.GetHashCode();
                if (this.LimitUseIntervalEnabled != null)
                    hash = hash * 59 + this.LimitUseIntervalEnabled.GetHashCode();
                if (this.LimitUseIntervalUnits != null)
                    hash = hash * 59 + this.LimitUseIntervalUnits.GetHashCode();
                if (this.MaxUseEnabled != null)
                    hash = hash * 59 + this.MaxUseEnabled.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.PowerFormId != null)
                    hash = hash * 59 + this.PowerFormId.GetHashCode();
                if (this.PowerFormUrl != null)
                    hash = hash * 59 + this.PowerFormUrl.GetHashCode();
                if (this.Recipients != null)
                    hash = hash * 59 + this.Recipients.GetHashCode();
                if (this.SenderName != null)
                    hash = hash * 59 + this.SenderName.GetHashCode();
                if (this.SenderUserId != null)
                    hash = hash * 59 + this.SenderUserId.GetHashCode();
                if (this.SigningMode != null)
                    hash = hash * 59 + this.SigningMode.GetHashCode();
                if (this.TemplateId != null)
                    hash = hash * 59 + this.TemplateId.GetHashCode();
                if (this.TemplateName != null)
                    hash = hash * 59 + this.TemplateName.GetHashCode();
                if (this.TimesUsed != null)
                    hash = hash * 59 + this.TimesUsed.GetHashCode();
                if (this.Uri != null)
                    hash = hash * 59 + this.Uri.GetHashCode();
                if (this.UsesRemaining != null)
                    hash = hash * 59 + this.UsesRemaining.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
