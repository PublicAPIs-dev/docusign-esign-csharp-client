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
    /// RecipientFormData
    /// </summary>
    [DataContract]
    public partial class RecipientFormData :  IEquatable<RecipientFormData>, IValidatableObject
    {
        public RecipientFormData()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientFormData" /> class.
        /// </summary>
        /// <param name="DeclinedTime">DeclinedTime.</param>
        /// <param name="DeliveredTime">DeliveredTime.</param>
        /// <param name="Email">Email.</param>
        /// <param name="FormData">FormData.</param>
        /// <param name="Name">Name.</param>
        /// <param name="RecipientId">Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document..</param>
        /// <param name="SentTime">SentTime.</param>
        /// <param name="SignedTime">SignedTime.</param>
        public RecipientFormData(string DeclinedTime = default(string), string DeliveredTime = default(string), string Email = default(string), List<FormDataItem> FormData = default(List<FormDataItem>), string Name = default(string), string RecipientId = default(string), string SentTime = default(string), string SignedTime = default(string))
        {
            this.DeclinedTime = DeclinedTime;
            this.DeliveredTime = DeliveredTime;
            this.Email = Email;
            this.FormData = FormData;
            this.Name = Name;
            this.RecipientId = RecipientId;
            this.SentTime = SentTime;
            this.SignedTime = SignedTime;
        }
        
        /// <summary>
        /// Gets or Sets DeclinedTime
        /// </summary>
        [DataMember(Name="DeclinedTime", EmitDefaultValue=false)]
        public string DeclinedTime { get; set; }
        /// <summary>
        /// Gets or Sets DeliveredTime
        /// </summary>
        [DataMember(Name="DeliveredTime", EmitDefaultValue=false)]
        public string DeliveredTime { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets FormData
        /// </summary>
        [DataMember(Name="formData", EmitDefaultValue=false)]
        public List<FormDataItem> FormData { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.
        /// </summary>
        /// <value>Unique for the recipient. It is used by the tab element to indicate which recipient is to sign the Document.</value>
        [DataMember(Name="recipientId", EmitDefaultValue=false)]
        public string RecipientId { get; set; }
        /// <summary>
        /// Gets or Sets SentTime
        /// </summary>
        [DataMember(Name="SentTime", EmitDefaultValue=false)]
        public string SentTime { get; set; }
        /// <summary>
        /// Gets or Sets SignedTime
        /// </summary>
        [DataMember(Name="SignedTime", EmitDefaultValue=false)]
        public string SignedTime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientFormData {\n");
            sb.Append("  DeclinedTime: ").Append(DeclinedTime).Append("\n");
            sb.Append("  DeliveredTime: ").Append(DeliveredTime).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FormData: ").Append(FormData).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RecipientId: ").Append(RecipientId).Append("\n");
            sb.Append("  SentTime: ").Append(SentTime).Append("\n");
            sb.Append("  SignedTime: ").Append(SignedTime).Append("\n");
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
            return this.Equals(obj as RecipientFormData);
        }

        /// <summary>
        /// Returns true if RecipientFormData instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientFormData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientFormData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeclinedTime == other.DeclinedTime ||
                    this.DeclinedTime != null &&
                    this.DeclinedTime.Equals(other.DeclinedTime)
                ) && 
                (
                    this.DeliveredTime == other.DeliveredTime ||
                    this.DeliveredTime != null &&
                    this.DeliveredTime.Equals(other.DeliveredTime)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.FormData == other.FormData ||
                    this.FormData != null &&
                    this.FormData.SequenceEqual(other.FormData)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.RecipientId == other.RecipientId ||
                    this.RecipientId != null &&
                    this.RecipientId.Equals(other.RecipientId)
                ) && 
                (
                    this.SentTime == other.SentTime ||
                    this.SentTime != null &&
                    this.SentTime.Equals(other.SentTime)
                ) && 
                (
                    this.SignedTime == other.SignedTime ||
                    this.SignedTime != null &&
                    this.SignedTime.Equals(other.SignedTime)
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
                if (this.DeclinedTime != null)
                    hash = hash * 59 + this.DeclinedTime.GetHashCode();
                if (this.DeliveredTime != null)
                    hash = hash * 59 + this.DeliveredTime.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.FormData != null)
                    hash = hash * 59 + this.FormData.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.RecipientId != null)
                    hash = hash * 59 + this.RecipientId.GetHashCode();
                if (this.SentTime != null)
                    hash = hash * 59 + this.SentTime.GetHashCode();
                if (this.SignedTime != null)
                    hash = hash * 59 + this.SignedTime.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
