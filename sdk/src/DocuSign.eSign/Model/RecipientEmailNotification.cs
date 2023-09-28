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
    /// RecipientEmailNotification
    /// </summary>
    [DataContract]
    public partial class RecipientEmailNotification :  IEquatable<RecipientEmailNotification>, IValidatableObject
    {
        public RecipientEmailNotification()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientEmailNotification" /> class.
        /// </summary>
        /// <param name="EmailBody">Specifies the email body of the message sent to the recipient.   Maximum length: 10000 characters. .</param>
        /// <param name="EmailBodyMetadata">Metadata that indicates whether the &#x60;emailBody&#x60; property can be edited..</param>
        /// <param name="EmailSubject">Specifies the subject of the email that is sent to all recipients.  See [ML:Template Email Subject Merge Fields] for information about adding merge field information to the email subject..</param>
        /// <param name="EmailSubjectMetadata">Metadata that indicates whether the &#x60;emailSubject&#x60; property can be edited..</param>
        /// <param name="SupportedLanguage">A simple type enumeration of the language used. The supported languages, with the language value shown in parenthesis, are: Arabic (ar), Armenian (hy), Bahasa Indonesia (id), Bahasa Melayu (ms) Bulgarian (bg), Czech (cs), Chinese Simplified (zh_CN), Chinese Traditional (zh_TW), Croatian (hr), Danish (da), Dutch (nl), English US (en), English UK (en_GB), Estonian (et), Farsi (fa), Finnish (fi), French (fr), French Canada (fr_CA), German (de), Greek (el), Hebrew (he), Hindi (hi), Hungarian (hu), Italian (it), Japanese (ja), Korean (ko), Latvian (lv), Lithuanian (lt), Norwegian (no), Polish (pl), Portuguese (pt), Portuguese Brazil (pt_BR), Romanian (ro),Russian (ru), Serbian (sr), Slovak (sk), Slovenian (sl), Spanish (es),Spanish Latin America (es_MX), Swedish (sv), Thai (th), Turkish (tr), Ukrainian (uk), and Vietnamese (vi)..</param>
        /// <param name="SupportedLanguageMetadata">Metadata that indicates whether the &#x60;supportedLanguage&#x60; property can be edited..</param>
        public RecipientEmailNotification(string EmailBody = default(string), PropertyMetadata EmailBodyMetadata = default(PropertyMetadata), string EmailSubject = default(string), PropertyMetadata EmailSubjectMetadata = default(PropertyMetadata), string SupportedLanguage = default(string), PropertyMetadata SupportedLanguageMetadata = default(PropertyMetadata))
        {
            this.EmailBody = EmailBody;
            this.EmailBodyMetadata = EmailBodyMetadata;
            this.EmailSubject = EmailSubject;
            this.EmailSubjectMetadata = EmailSubjectMetadata;
            this.SupportedLanguage = SupportedLanguage;
            this.SupportedLanguageMetadata = SupportedLanguageMetadata;
        }
        
        /// <summary>
        /// Specifies the email body of the message sent to the recipient.   Maximum length: 10000 characters. 
        /// </summary>
        /// <value>Specifies the email body of the message sent to the recipient.   Maximum length: 10000 characters. </value>
        [DataMember(Name="emailBody", EmitDefaultValue=false)]
        public string EmailBody { get; set; }
        /// <summary>
        /// Metadata that indicates whether the &#x60;emailBody&#x60; property can be edited.
        /// </summary>
        /// <value>Metadata that indicates whether the &#x60;emailBody&#x60; property can be edited.</value>
        [DataMember(Name="emailBodyMetadata", EmitDefaultValue=false)]
        public PropertyMetadata EmailBodyMetadata { get; set; }
        /// <summary>
        /// Specifies the subject of the email that is sent to all recipients.  See [ML:Template Email Subject Merge Fields] for information about adding merge field information to the email subject.
        /// </summary>
        /// <value>Specifies the subject of the email that is sent to all recipients.  See [ML:Template Email Subject Merge Fields] for information about adding merge field information to the email subject.</value>
        [DataMember(Name="emailSubject", EmitDefaultValue=false)]
        public string EmailSubject { get; set; }
        /// <summary>
        /// Metadata that indicates whether the &#x60;emailSubject&#x60; property can be edited.
        /// </summary>
        /// <value>Metadata that indicates whether the &#x60;emailSubject&#x60; property can be edited.</value>
        [DataMember(Name="emailSubjectMetadata", EmitDefaultValue=false)]
        public PropertyMetadata EmailSubjectMetadata { get; set; }
        /// <summary>
        /// A simple type enumeration of the language used. The supported languages, with the language value shown in parenthesis, are: Arabic (ar), Armenian (hy), Bahasa Indonesia (id), Bahasa Melayu (ms) Bulgarian (bg), Czech (cs), Chinese Simplified (zh_CN), Chinese Traditional (zh_TW), Croatian (hr), Danish (da), Dutch (nl), English US (en), English UK (en_GB), Estonian (et), Farsi (fa), Finnish (fi), French (fr), French Canada (fr_CA), German (de), Greek (el), Hebrew (he), Hindi (hi), Hungarian (hu), Italian (it), Japanese (ja), Korean (ko), Latvian (lv), Lithuanian (lt), Norwegian (no), Polish (pl), Portuguese (pt), Portuguese Brazil (pt_BR), Romanian (ro),Russian (ru), Serbian (sr), Slovak (sk), Slovenian (sl), Spanish (es),Spanish Latin America (es_MX), Swedish (sv), Thai (th), Turkish (tr), Ukrainian (uk), and Vietnamese (vi).
        /// </summary>
        /// <value>A simple type enumeration of the language used. The supported languages, with the language value shown in parenthesis, are: Arabic (ar), Armenian (hy), Bahasa Indonesia (id), Bahasa Melayu (ms) Bulgarian (bg), Czech (cs), Chinese Simplified (zh_CN), Chinese Traditional (zh_TW), Croatian (hr), Danish (da), Dutch (nl), English US (en), English UK (en_GB), Estonian (et), Farsi (fa), Finnish (fi), French (fr), French Canada (fr_CA), German (de), Greek (el), Hebrew (he), Hindi (hi), Hungarian (hu), Italian (it), Japanese (ja), Korean (ko), Latvian (lv), Lithuanian (lt), Norwegian (no), Polish (pl), Portuguese (pt), Portuguese Brazil (pt_BR), Romanian (ro),Russian (ru), Serbian (sr), Slovak (sk), Slovenian (sl), Spanish (es),Spanish Latin America (es_MX), Swedish (sv), Thai (th), Turkish (tr), Ukrainian (uk), and Vietnamese (vi).</value>
        [DataMember(Name="supportedLanguage", EmitDefaultValue=false)]
        public string SupportedLanguage { get; set; }
        /// <summary>
        /// Metadata that indicates whether the &#x60;supportedLanguage&#x60; property can be edited.
        /// </summary>
        /// <value>Metadata that indicates whether the &#x60;supportedLanguage&#x60; property can be edited.</value>
        [DataMember(Name="supportedLanguageMetadata", EmitDefaultValue=false)]
        public PropertyMetadata SupportedLanguageMetadata { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientEmailNotification {\n");
            sb.Append("  EmailBody: ").Append(EmailBody).Append("\n");
            sb.Append("  EmailBodyMetadata: ").Append(EmailBodyMetadata).Append("\n");
            sb.Append("  EmailSubject: ").Append(EmailSubject).Append("\n");
            sb.Append("  EmailSubjectMetadata: ").Append(EmailSubjectMetadata).Append("\n");
            sb.Append("  SupportedLanguage: ").Append(SupportedLanguage).Append("\n");
            sb.Append("  SupportedLanguageMetadata: ").Append(SupportedLanguageMetadata).Append("\n");
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
            return this.Equals(obj as RecipientEmailNotification);
        }

        /// <summary>
        /// Returns true if RecipientEmailNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientEmailNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientEmailNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.EmailBody == other.EmailBody ||
                    this.EmailBody != null &&
                    this.EmailBody.Equals(other.EmailBody)
                ) && 
                (
                    this.EmailBodyMetadata == other.EmailBodyMetadata ||
                    this.EmailBodyMetadata != null &&
                    this.EmailBodyMetadata.Equals(other.EmailBodyMetadata)
                ) && 
                (
                    this.EmailSubject == other.EmailSubject ||
                    this.EmailSubject != null &&
                    this.EmailSubject.Equals(other.EmailSubject)
                ) && 
                (
                    this.EmailSubjectMetadata == other.EmailSubjectMetadata ||
                    this.EmailSubjectMetadata != null &&
                    this.EmailSubjectMetadata.Equals(other.EmailSubjectMetadata)
                ) && 
                (
                    this.SupportedLanguage == other.SupportedLanguage ||
                    this.SupportedLanguage != null &&
                    this.SupportedLanguage.Equals(other.SupportedLanguage)
                ) && 
                (
                    this.SupportedLanguageMetadata == other.SupportedLanguageMetadata ||
                    this.SupportedLanguageMetadata != null &&
                    this.SupportedLanguageMetadata.Equals(other.SupportedLanguageMetadata)
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
                if (this.EmailBody != null)
                    hash = hash * 59 + this.EmailBody.GetHashCode();
                if (this.EmailBodyMetadata != null)
                    hash = hash * 59 + this.EmailBodyMetadata.GetHashCode();
                if (this.EmailSubject != null)
                    hash = hash * 59 + this.EmailSubject.GetHashCode();
                if (this.EmailSubjectMetadata != null)
                    hash = hash * 59 + this.EmailSubjectMetadata.GetHashCode();
                if (this.SupportedLanguage != null)
                    hash = hash * 59 + this.SupportedLanguage.GetHashCode();
                if (this.SupportedLanguageMetadata != null)
                    hash = hash * 59 + this.SupportedLanguageMetadata.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
