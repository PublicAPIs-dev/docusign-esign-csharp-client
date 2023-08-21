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
    /// This object contains information abut a BCC email archive configuration (a BCC email address used to archive DocuSign-generated emails).
    /// </summary>
    [DataContract]
    public partial class BccEmailArchive :  IEquatable<BccEmailArchive>, IValidatableObject
    {
        public BccEmailArchive()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BccEmailArchive" /> class.
        /// </summary>
        /// <param name="AccountId">The account ID associated with the envelope..</param>
        /// <param name="BccEmailArchiveId">BccEmailArchiveId.</param>
        /// <param name="Created">Created.</param>
        /// <param name="CreatedBy">Details about the user who created the BCC email archive configuration..</param>
        /// <param name="Email">Email.</param>
        /// <param name="EmailNotificationId">EmailNotificationId.</param>
        /// <param name="Modified">Modified.</param>
        /// <param name="ModifiedBy">Details about the user who last modified the BCC email archive configuration..</param>
        /// <param name="Status">Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later..</param>
        /// <param name="Uri">Uri.</param>
        public BccEmailArchive(string AccountId = default(string), string BccEmailArchiveId = default(string), string Created = default(string), UserInfo CreatedBy = default(UserInfo), string Email = default(string), string EmailNotificationId = default(string), string Modified = default(string), UserInfo ModifiedBy = default(UserInfo), string Status = default(string), string Uri = default(string))
        {
            this.AccountId = AccountId;
            this.BccEmailArchiveId = BccEmailArchiveId;
            this.Created = Created;
            this.CreatedBy = CreatedBy;
            this.Email = Email;
            this.EmailNotificationId = EmailNotificationId;
            this.Modified = Modified;
            this.ModifiedBy = ModifiedBy;
            this.Status = Status;
            this.Uri = Uri;
        }
        
        /// <summary>
        /// The account ID associated with the envelope.
        /// </summary>
        /// <value>The account ID associated with the envelope.</value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }
        /// <summary>
        /// Gets or Sets BccEmailArchiveId
        /// </summary>
        [DataMember(Name="bccEmailArchiveId", EmitDefaultValue=false)]
        public string BccEmailArchiveId { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public string Created { get; set; }
        /// <summary>
        /// Details about the user who created the BCC email archive configuration.
        /// </summary>
        /// <value>Details about the user who created the BCC email archive configuration.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public UserInfo CreatedBy { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets EmailNotificationId
        /// </summary>
        [DataMember(Name="emailNotificationId", EmitDefaultValue=false)]
        public string EmailNotificationId { get; set; }
        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name="modified", EmitDefaultValue=false)]
        public string Modified { get; set; }
        /// <summary>
        /// Details about the user who last modified the BCC email archive configuration.
        /// </summary>
        /// <value>Details about the user who last modified the BCC email archive configuration.</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public UserInfo ModifiedBy { get; set; }
        /// <summary>
        /// Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later.
        /// </summary>
        /// <value>Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
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
            sb.Append("class BccEmailArchive {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  BccEmailArchiveId: ").Append(BccEmailArchiveId).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EmailNotificationId: ").Append(EmailNotificationId).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as BccEmailArchive);
        }

        /// <summary>
        /// Returns true if BccEmailArchive instances are equal
        /// </summary>
        /// <param name="other">Instance of BccEmailArchive to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BccEmailArchive other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.BccEmailArchiveId == other.BccEmailArchiveId ||
                    this.BccEmailArchiveId != null &&
                    this.BccEmailArchiveId.Equals(other.BccEmailArchiveId)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.EmailNotificationId == other.EmailNotificationId ||
                    this.EmailNotificationId != null &&
                    this.EmailNotificationId.Equals(other.EmailNotificationId)
                ) && 
                (
                    this.Modified == other.Modified ||
                    this.Modified != null &&
                    this.Modified.Equals(other.Modified)
                ) && 
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.BccEmailArchiveId != null)
                    hash = hash * 59 + this.BccEmailArchiveId.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.EmailNotificationId != null)
                    hash = hash * 59 + this.EmailNotificationId.GetHashCode();
                if (this.Modified != null)
                    hash = hash * 59 + this.Modified.GetHashCode();
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
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
