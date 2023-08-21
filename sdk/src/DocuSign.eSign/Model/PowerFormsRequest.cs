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
    /// PowerFormsRequest
    /// </summary>
    [DataContract]
    public partial class PowerFormsRequest :  IEquatable<PowerFormsRequest>, IValidatableObject
    {
        public PowerFormsRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PowerFormsRequest" /> class.
        /// </summary>
        /// <param name="PowerForms">PowerForms.</param>
        public PowerFormsRequest(List<PowerForm> PowerForms = default(List<PowerForm>))
        {
            this.PowerForms = PowerForms;
        }
        
        /// <summary>
        /// Gets or Sets PowerForms
        /// </summary>
        [DataMember(Name="powerForms", EmitDefaultValue=false)]
        public List<PowerForm> PowerForms { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PowerFormsRequest {\n");
            sb.Append("  PowerForms: ").Append(PowerForms).Append("\n");
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
            return this.Equals(obj as PowerFormsRequest);
        }

        /// <summary>
        /// Returns true if PowerFormsRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of PowerFormsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PowerFormsRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PowerForms == other.PowerForms ||
                    this.PowerForms != null &&
                    this.PowerForms.SequenceEqual(other.PowerForms)
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
                if (this.PowerForms != null)
                    hash = hash * 59 + this.PowerForms.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
