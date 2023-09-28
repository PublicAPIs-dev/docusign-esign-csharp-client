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
    /// DowngradRequestBillingInfoResponse
    /// </summary>
    [DataContract]
    public partial class DowngradRequestBillingInfoResponse :  IEquatable<DowngradRequestBillingInfoResponse>, IValidatableObject
    {
        public DowngradRequestBillingInfoResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DowngradRequestBillingInfoResponse" /> class.
        /// </summary>
        /// <param name="DowngradePlanInformation">DowngradePlanInformation.</param>
        /// <param name="PaymentMethod">PaymentMethod.</param>
        public DowngradRequestBillingInfoResponse(DowngradePlanUpdateResponse DowngradePlanInformation = default(DowngradePlanUpdateResponse), string PaymentMethod = default(string))
        {
            this.DowngradePlanInformation = DowngradePlanInformation;
            this.PaymentMethod = PaymentMethod;
        }
        
        /// <summary>
        /// Gets or Sets DowngradePlanInformation
        /// </summary>
        [DataMember(Name="downgradePlanInformation", EmitDefaultValue=false)]
        public DowngradePlanUpdateResponse DowngradePlanInformation { get; set; }
        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public string PaymentMethod { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DowngradRequestBillingInfoResponse {\n");
            sb.Append("  DowngradePlanInformation: ").Append(DowngradePlanInformation).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
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
            return this.Equals(obj as DowngradRequestBillingInfoResponse);
        }

        /// <summary>
        /// Returns true if DowngradRequestBillingInfoResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of DowngradRequestBillingInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DowngradRequestBillingInfoResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DowngradePlanInformation == other.DowngradePlanInformation ||
                    this.DowngradePlanInformation != null &&
                    this.DowngradePlanInformation.Equals(other.DowngradePlanInformation)
                ) && 
                (
                    this.PaymentMethod == other.PaymentMethod ||
                    this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(other.PaymentMethod)
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
                if (this.DowngradePlanInformation != null)
                    hash = hash * 59 + this.DowngradePlanInformation.GetHashCode();
                if (this.PaymentMethod != null)
                    hash = hash * 59 + this.PaymentMethod.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
