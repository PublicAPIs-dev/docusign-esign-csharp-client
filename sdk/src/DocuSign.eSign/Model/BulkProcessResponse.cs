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
    /// BulkProcessResponse
    /// </summary>
    [DataContract]
    public partial class BulkProcessResponse :  IEquatable<BulkProcessResponse>, IValidatableObject
    {
        public BulkProcessResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkProcessResponse" /> class.
        /// </summary>
        /// <param name="BatchId">BatchId.</param>
        /// <param name="BatchName">BatchName.</param>
        /// <param name="BatchSize">BatchSize.</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="Errors">Errors.</param>
        /// <param name="QueueLimit">QueueLimit.</param>
        /// <param name="TotalQueued">TotalQueued.</param>
        public BulkProcessResponse(string BatchId = default(string), string BatchName = default(string), string BatchSize = default(string), List<string> ErrorDetails = default(List<string>), List<string> Errors = default(List<string>), string QueueLimit = default(string), string TotalQueued = default(string))
        {
            this.BatchId = BatchId;
            this.BatchName = BatchName;
            this.BatchSize = BatchSize;
            this.ErrorDetails = ErrorDetails;
            this.Errors = Errors;
            this.QueueLimit = QueueLimit;
            this.TotalQueued = TotalQueued;
        }
        
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
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public List<string> ErrorDetails { get; set; }
        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<string> Errors { get; set; }
        /// <summary>
        /// Gets or Sets QueueLimit
        /// </summary>
        [DataMember(Name="queueLimit", EmitDefaultValue=false)]
        public string QueueLimit { get; set; }
        /// <summary>
        /// Gets or Sets TotalQueued
        /// </summary>
        [DataMember(Name="totalQueued", EmitDefaultValue=false)]
        public string TotalQueued { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkProcessResponse {\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  BatchName: ").Append(BatchName).Append("\n");
            sb.Append("  BatchSize: ").Append(BatchSize).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  QueueLimit: ").Append(QueueLimit).Append("\n");
            sb.Append("  TotalQueued: ").Append(TotalQueued).Append("\n");
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
            return this.Equals(obj as BulkProcessResponse);
        }

        /// <summary>
        /// Returns true if BulkProcessResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkProcessResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkProcessResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.SequenceEqual(other.ErrorDetails)
                ) && 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                ) && 
                (
                    this.QueueLimit == other.QueueLimit ||
                    this.QueueLimit != null &&
                    this.QueueLimit.Equals(other.QueueLimit)
                ) && 
                (
                    this.TotalQueued == other.TotalQueued ||
                    this.TotalQueued != null &&
                    this.TotalQueued.Equals(other.TotalQueued)
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
                if (this.BatchId != null)
                    hash = hash * 59 + this.BatchId.GetHashCode();
                if (this.BatchName != null)
                    hash = hash * 59 + this.BatchName.GetHashCode();
                if (this.BatchSize != null)
                    hash = hash * 59 + this.BatchSize.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                if (this.QueueLimit != null)
                    hash = hash * 59 + this.QueueLimit.GetHashCode();
                if (this.TotalQueued != null)
                    hash = hash * 59 + this.TotalQueued.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
