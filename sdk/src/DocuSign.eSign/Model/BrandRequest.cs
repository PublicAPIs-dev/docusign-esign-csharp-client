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
    /// This request object contains information about a specific brand.
    /// </summary>
    [DataContract]
    public partial class BrandRequest :  IEquatable<BrandRequest>, IValidatableObject
    {
        public BrandRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrandRequest" /> class.
        /// </summary>
        /// <param name="BrandId">The ID of the brand used in API calls.</param>
        public BrandRequest(string BrandId = default(string))
        {
            this.BrandId = BrandId;
        }
        
        /// <summary>
        /// The ID of the brand used in API calls
        /// </summary>
        /// <value>The ID of the brand used in API calls</value>
        [DataMember(Name="brandId", EmitDefaultValue=false)]
        public string BrandId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandRequest {\n");
            sb.Append("  BrandId: ").Append(BrandId).Append("\n");
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
            return this.Equals(obj as BrandRequest);
        }

        /// <summary>
        /// Returns true if BrandRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of BrandRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BrandId == other.BrandId ||
                    this.BrandId != null &&
                    this.BrandId.Equals(other.BrandId)
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
                if (this.BrandId != null)
                    hash = hash * 59 + this.BrandId.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
