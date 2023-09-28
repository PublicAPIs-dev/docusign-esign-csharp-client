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
    /// A complex element that has up to four Question/Answer pairs for forgotten password information.
    /// </summary>
    [DataContract]
    public partial class ForgottenPasswordInformation :  IEquatable<ForgottenPasswordInformation>, IValidatableObject
    {
        public ForgottenPasswordInformation()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ForgottenPasswordInformation" /> class.
        /// </summary>
        /// <param name="ForgottenPasswordAnswer1">The answer to the first forgotten password challenge question..</param>
        /// <param name="ForgottenPasswordAnswer2">The answer to the second forgotten password challenge question..</param>
        /// <param name="ForgottenPasswordAnswer3">The answer to the third forgotten password challenge question..</param>
        /// <param name="ForgottenPasswordAnswer4">The answer to the fourth forgotten password challenge question..</param>
        /// <param name="ForgottenPasswordQuestion1">The first challenge question presented to a user who has forgotten their password..</param>
        /// <param name="ForgottenPasswordQuestion2">The second challenge question presented to a user who has forgotten their password..</param>
        /// <param name="ForgottenPasswordQuestion3">The third challenge question presented to a user who has forgotten their password..</param>
        /// <param name="ForgottenPasswordQuestion4">The fourth challenge question presented to a user who has forgotten their password..</param>
        public ForgottenPasswordInformation(string ForgottenPasswordAnswer1 = default(string), string ForgottenPasswordAnswer2 = default(string), string ForgottenPasswordAnswer3 = default(string), string ForgottenPasswordAnswer4 = default(string), string ForgottenPasswordQuestion1 = default(string), string ForgottenPasswordQuestion2 = default(string), string ForgottenPasswordQuestion3 = default(string), string ForgottenPasswordQuestion4 = default(string))
        {
            this.ForgottenPasswordAnswer1 = ForgottenPasswordAnswer1;
            this.ForgottenPasswordAnswer2 = ForgottenPasswordAnswer2;
            this.ForgottenPasswordAnswer3 = ForgottenPasswordAnswer3;
            this.ForgottenPasswordAnswer4 = ForgottenPasswordAnswer4;
            this.ForgottenPasswordQuestion1 = ForgottenPasswordQuestion1;
            this.ForgottenPasswordQuestion2 = ForgottenPasswordQuestion2;
            this.ForgottenPasswordQuestion3 = ForgottenPasswordQuestion3;
            this.ForgottenPasswordQuestion4 = ForgottenPasswordQuestion4;
        }
        
        /// <summary>
        /// The answer to the first forgotten password challenge question.
        /// </summary>
        /// <value>The answer to the first forgotten password challenge question.</value>
        [DataMember(Name="forgottenPasswordAnswer1", EmitDefaultValue=false)]
        public string ForgottenPasswordAnswer1 { get; set; }
        /// <summary>
        /// The answer to the second forgotten password challenge question.
        /// </summary>
        /// <value>The answer to the second forgotten password challenge question.</value>
        [DataMember(Name="forgottenPasswordAnswer2", EmitDefaultValue=false)]
        public string ForgottenPasswordAnswer2 { get; set; }
        /// <summary>
        /// The answer to the third forgotten password challenge question.
        /// </summary>
        /// <value>The answer to the third forgotten password challenge question.</value>
        [DataMember(Name="forgottenPasswordAnswer3", EmitDefaultValue=false)]
        public string ForgottenPasswordAnswer3 { get; set; }
        /// <summary>
        /// The answer to the fourth forgotten password challenge question.
        /// </summary>
        /// <value>The answer to the fourth forgotten password challenge question.</value>
        [DataMember(Name="forgottenPasswordAnswer4", EmitDefaultValue=false)]
        public string ForgottenPasswordAnswer4 { get; set; }
        /// <summary>
        /// The first challenge question presented to a user who has forgotten their password.
        /// </summary>
        /// <value>The first challenge question presented to a user who has forgotten their password.</value>
        [DataMember(Name="forgottenPasswordQuestion1", EmitDefaultValue=false)]
        public string ForgottenPasswordQuestion1 { get; set; }
        /// <summary>
        /// The second challenge question presented to a user who has forgotten their password.
        /// </summary>
        /// <value>The second challenge question presented to a user who has forgotten their password.</value>
        [DataMember(Name="forgottenPasswordQuestion2", EmitDefaultValue=false)]
        public string ForgottenPasswordQuestion2 { get; set; }
        /// <summary>
        /// The third challenge question presented to a user who has forgotten their password.
        /// </summary>
        /// <value>The third challenge question presented to a user who has forgotten their password.</value>
        [DataMember(Name="forgottenPasswordQuestion3", EmitDefaultValue=false)]
        public string ForgottenPasswordQuestion3 { get; set; }
        /// <summary>
        /// The fourth challenge question presented to a user who has forgotten their password.
        /// </summary>
        /// <value>The fourth challenge question presented to a user who has forgotten their password.</value>
        [DataMember(Name="forgottenPasswordQuestion4", EmitDefaultValue=false)]
        public string ForgottenPasswordQuestion4 { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ForgottenPasswordInformation {\n");
            sb.Append("  ForgottenPasswordAnswer1: ").Append(ForgottenPasswordAnswer1).Append("\n");
            sb.Append("  ForgottenPasswordAnswer2: ").Append(ForgottenPasswordAnswer2).Append("\n");
            sb.Append("  ForgottenPasswordAnswer3: ").Append(ForgottenPasswordAnswer3).Append("\n");
            sb.Append("  ForgottenPasswordAnswer4: ").Append(ForgottenPasswordAnswer4).Append("\n");
            sb.Append("  ForgottenPasswordQuestion1: ").Append(ForgottenPasswordQuestion1).Append("\n");
            sb.Append("  ForgottenPasswordQuestion2: ").Append(ForgottenPasswordQuestion2).Append("\n");
            sb.Append("  ForgottenPasswordQuestion3: ").Append(ForgottenPasswordQuestion3).Append("\n");
            sb.Append("  ForgottenPasswordQuestion4: ").Append(ForgottenPasswordQuestion4).Append("\n");
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
            return this.Equals(obj as ForgottenPasswordInformation);
        }

        /// <summary>
        /// Returns true if ForgottenPasswordInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of ForgottenPasswordInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForgottenPasswordInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ForgottenPasswordAnswer1 == other.ForgottenPasswordAnswer1 ||
                    this.ForgottenPasswordAnswer1 != null &&
                    this.ForgottenPasswordAnswer1.Equals(other.ForgottenPasswordAnswer1)
                ) && 
                (
                    this.ForgottenPasswordAnswer2 == other.ForgottenPasswordAnswer2 ||
                    this.ForgottenPasswordAnswer2 != null &&
                    this.ForgottenPasswordAnswer2.Equals(other.ForgottenPasswordAnswer2)
                ) && 
                (
                    this.ForgottenPasswordAnswer3 == other.ForgottenPasswordAnswer3 ||
                    this.ForgottenPasswordAnswer3 != null &&
                    this.ForgottenPasswordAnswer3.Equals(other.ForgottenPasswordAnswer3)
                ) && 
                (
                    this.ForgottenPasswordAnswer4 == other.ForgottenPasswordAnswer4 ||
                    this.ForgottenPasswordAnswer4 != null &&
                    this.ForgottenPasswordAnswer4.Equals(other.ForgottenPasswordAnswer4)
                ) && 
                (
                    this.ForgottenPasswordQuestion1 == other.ForgottenPasswordQuestion1 ||
                    this.ForgottenPasswordQuestion1 != null &&
                    this.ForgottenPasswordQuestion1.Equals(other.ForgottenPasswordQuestion1)
                ) && 
                (
                    this.ForgottenPasswordQuestion2 == other.ForgottenPasswordQuestion2 ||
                    this.ForgottenPasswordQuestion2 != null &&
                    this.ForgottenPasswordQuestion2.Equals(other.ForgottenPasswordQuestion2)
                ) && 
                (
                    this.ForgottenPasswordQuestion3 == other.ForgottenPasswordQuestion3 ||
                    this.ForgottenPasswordQuestion3 != null &&
                    this.ForgottenPasswordQuestion3.Equals(other.ForgottenPasswordQuestion3)
                ) && 
                (
                    this.ForgottenPasswordQuestion4 == other.ForgottenPasswordQuestion4 ||
                    this.ForgottenPasswordQuestion4 != null &&
                    this.ForgottenPasswordQuestion4.Equals(other.ForgottenPasswordQuestion4)
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
                if (this.ForgottenPasswordAnswer1 != null)
                    hash = hash * 59 + this.ForgottenPasswordAnswer1.GetHashCode();
                if (this.ForgottenPasswordAnswer2 != null)
                    hash = hash * 59 + this.ForgottenPasswordAnswer2.GetHashCode();
                if (this.ForgottenPasswordAnswer3 != null)
                    hash = hash * 59 + this.ForgottenPasswordAnswer3.GetHashCode();
                if (this.ForgottenPasswordAnswer4 != null)
                    hash = hash * 59 + this.ForgottenPasswordAnswer4.GetHashCode();
                if (this.ForgottenPasswordQuestion1 != null)
                    hash = hash * 59 + this.ForgottenPasswordQuestion1.GetHashCode();
                if (this.ForgottenPasswordQuestion2 != null)
                    hash = hash * 59 + this.ForgottenPasswordQuestion2.GetHashCode();
                if (this.ForgottenPasswordQuestion3 != null)
                    hash = hash * 59 + this.ForgottenPasswordQuestion3.GetHashCode();
                if (this.ForgottenPasswordQuestion4 != null)
                    hash = hash * 59 + this.ForgottenPasswordQuestion4.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
