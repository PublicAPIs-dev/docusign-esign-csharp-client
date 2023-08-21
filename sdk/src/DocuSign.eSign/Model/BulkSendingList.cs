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
    /// This object contains the details for the bulk send list.
    /// </summary>
    [DataContract]
    public partial class BulkSendingList :  IEquatable<BulkSendingList>, IValidatableObject
    {
        public BulkSendingList()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSendingList" /> class.
        /// </summary>
        /// <param name="BulkCopies">BulkCopies.</param>
        /// <param name="ListId">ListId.</param>
        /// <param name="Name">Name.</param>
        public BulkSendingList(List<BulkSendingCopy> BulkCopies = default(List<BulkSendingCopy>), string ListId = default(string), string Name = default(string))
        {
            this.BulkCopies = BulkCopies;
            this.ListId = ListId;
            this.Name = Name;
        }
        
        /// <summary>
        /// Gets or Sets BulkCopies
        /// </summary>
        [DataMember(Name="bulkCopies", EmitDefaultValue=false)]
        public List<BulkSendingCopy> BulkCopies { get; set; }
        /// <summary>
        /// Gets or Sets ListId
        /// </summary>
        [DataMember(Name="listId", EmitDefaultValue=false)]
        public string ListId { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkSendingList {\n");
            sb.Append("  BulkCopies: ").Append(BulkCopies).Append("\n");
            sb.Append("  ListId: ").Append(ListId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(obj as BulkSendingList);
        }

        /// <summary>
        /// Returns true if BulkSendingList instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkSendingList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkSendingList other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BulkCopies == other.BulkCopies ||
                    this.BulkCopies != null &&
                    this.BulkCopies.SequenceEqual(other.BulkCopies)
                ) && 
                (
                    this.ListId == other.ListId ||
                    this.ListId != null &&
                    this.ListId.Equals(other.ListId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
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
                if (this.BulkCopies != null)
                    hash = hash * 59 + this.BulkCopies.GetHashCode();
                if (this.ListId != null)
                    hash = hash * 59 + this.ListId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
