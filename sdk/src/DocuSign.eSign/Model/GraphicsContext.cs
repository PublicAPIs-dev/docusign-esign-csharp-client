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
    /// GraphicsContext
    /// </summary>
    [DataContract]
    public partial class GraphicsContext :  IEquatable<GraphicsContext>, IValidatableObject
    {
        public GraphicsContext()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GraphicsContext" /> class.
        /// </summary>
        /// <param name="FillColor">FillColor.</param>
        /// <param name="LineColor">LineColor.</param>
        /// <param name="LineWeight">LineWeight.</param>
        public GraphicsContext(string FillColor = default(string), string LineColor = default(string), string LineWeight = default(string))
        {
            this.FillColor = FillColor;
            this.LineColor = LineColor;
            this.LineWeight = LineWeight;
        }
        
        /// <summary>
        /// Gets or Sets FillColor
        /// </summary>
        [DataMember(Name="fillColor", EmitDefaultValue=false)]
        public string FillColor { get; set; }
        /// <summary>
        /// Gets or Sets LineColor
        /// </summary>
        [DataMember(Name="lineColor", EmitDefaultValue=false)]
        public string LineColor { get; set; }
        /// <summary>
        /// Gets or Sets LineWeight
        /// </summary>
        [DataMember(Name="lineWeight", EmitDefaultValue=false)]
        public string LineWeight { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GraphicsContext {\n");
            sb.Append("  FillColor: ").Append(FillColor).Append("\n");
            sb.Append("  LineColor: ").Append(LineColor).Append("\n");
            sb.Append("  LineWeight: ").Append(LineWeight).Append("\n");
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
            return this.Equals(obj as GraphicsContext);
        }

        /// <summary>
        /// Returns true if GraphicsContext instances are equal
        /// </summary>
        /// <param name="other">Instance of GraphicsContext to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GraphicsContext other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FillColor == other.FillColor ||
                    this.FillColor != null &&
                    this.FillColor.Equals(other.FillColor)
                ) && 
                (
                    this.LineColor == other.LineColor ||
                    this.LineColor != null &&
                    this.LineColor.Equals(other.LineColor)
                ) && 
                (
                    this.LineWeight == other.LineWeight ||
                    this.LineWeight != null &&
                    this.LineWeight.Equals(other.LineWeight)
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
                if (this.FillColor != null)
                    hash = hash * 59 + this.FillColor.GetHashCode();
                if (this.LineColor != null)
                    hash = hash * 59 + this.LineColor.GetHashCode();
                if (this.LineWeight != null)
                    hash = hash * 59 + this.LineWeight.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
