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
    /// UserSignature
    /// </summary>
    [DataContract]
    public partial class UserSignature :  IEquatable<UserSignature>, IValidatableObject
    {
        public UserSignature()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSignature" /> class.
        /// </summary>
        /// <param name="AdoptedDateTime">The date and time the user adopted their signature..</param>
        /// <param name="CreatedDateTime">Indicates the date and time the item was created..</param>
        /// <param name="CustomField">CustomField.</param>
        /// <param name="DateStampProperties">Specifies the area in which a date stamp is placed. This parameter uses pixel positioning to draw a rectangle at the center of the stamp area. The stamp is superimposed on top of this central area.  This property contains the following information about the central rectangle:  - &#x60;DateAreaX&#x60;: The X axis position of the top-left corner. - &#x60;DateAreaY&#x60;: The Y axis position of the top-left corner. - &#x60;DateAreaWidth&#x60;: The width of the rectangle. - &#x60;DateAreaHeight&#x60;: The height of the rectangle..</param>
        /// <param name="DisallowUserResizeStamp">DisallowUserResizeStamp.</param>
        /// <param name="ErrorDetails">Array or errors..</param>
        /// <param name="ExternalID">ExternalID.</param>
        /// <param name="ImageBase64">ImageBase64.</param>
        /// <param name="ImageType">ImageType.</param>
        /// <param name="Initials150ImageId">Initials150ImageId.</param>
        /// <param name="InitialsImageUri">Contains the URI for an endpoint that you can use to retrieve the initials image..</param>
        /// <param name="IsDefault">IsDefault.</param>
        /// <param name="LastModifiedDateTime">The date and time the item was last modified..</param>
        /// <param name="NrdsId">NrdsId.</param>
        /// <param name="NrdsLastName">NrdsLastName.</param>
        /// <param name="NrdsStatus">NrdsStatus.</param>
        /// <param name="PhoneticName">PhoneticName.</param>
        /// <param name="Signature150ImageId">Signature150ImageId.</param>
        /// <param name="SignatureFont">The font type for the signature, if the signature is not drawn. The supported font types are:  \&quot;7_DocuSign\&quot;, \&quot;1_DocuSign\&quot;, \&quot;6_DocuSign\&quot;, \&quot;8_DocuSign\&quot;, \&quot;3_DocuSign\&quot;, \&quot;Mistral\&quot;, \&quot;4_DocuSign\&quot;, \&quot;2_DocuSign\&quot;, \&quot;5_DocuSign\&quot;, \&quot;Rage Italic\&quot; .</param>
        /// <param name="SignatureId">Specifies the signature ID associated with the signature name. You can use the signature ID in the URI in place of the signature name, and the value stored in the &#x60;signatureName&#x60; property in the body is used. This allows the use of special characters (such as \&quot;&amp;\&quot;, \&quot;&lt;\&quot;, \&quot;&gt;\&quot;) in a the signature name. Note that with each update to signatures, the returned signature ID might change, so the caller will need to trigger off the signature name to get the new signature ID..</param>
        /// <param name="SignatureImageUri">Contains the URI for an endpoint that you can use to retrieve the signature image..</param>
        /// <param name="SignatureInitials"> The initials associated with the signature..</param>
        /// <param name="SignatureName">Specifies the user signature name..</param>
        /// <param name="SignatureRights">SignatureRights.</param>
        /// <param name="SignatureType">SignatureType.</param>
        /// <param name="StampFormat">StampFormat.</param>
        /// <param name="StampImageUri">StampImageUri.</param>
        /// <param name="StampSizeMM">StampSizeMM.</param>
        /// <param name="StampType">StampType.</param>
        /// <param name="Status">Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later..</param>
        public UserSignature(string AdoptedDateTime = default(string), string CreatedDateTime = default(string), string CustomField = default(string), DateStampProperties DateStampProperties = default(DateStampProperties), string DisallowUserResizeStamp = default(string), ErrorDetails ErrorDetails = default(ErrorDetails), string ExternalID = default(string), string ImageBase64 = default(string), string ImageType = default(string), string Initials150ImageId = default(string), string InitialsImageUri = default(string), string IsDefault = default(string), string LastModifiedDateTime = default(string), string NrdsId = default(string), string NrdsLastName = default(string), string NrdsStatus = default(string), string PhoneticName = default(string), string Signature150ImageId = default(string), string SignatureFont = default(string), string SignatureId = default(string), string SignatureImageUri = default(string), string SignatureInitials = default(string), string SignatureName = default(string), string SignatureRights = default(string), string SignatureType = default(string), string StampFormat = default(string), string StampImageUri = default(string), string StampSizeMM = default(string), string StampType = default(string), string Status = default(string))
        {
            this.AdoptedDateTime = AdoptedDateTime;
            this.CreatedDateTime = CreatedDateTime;
            this.CustomField = CustomField;
            this.DateStampProperties = DateStampProperties;
            this.DisallowUserResizeStamp = DisallowUserResizeStamp;
            this.ErrorDetails = ErrorDetails;
            this.ExternalID = ExternalID;
            this.ImageBase64 = ImageBase64;
            this.ImageType = ImageType;
            this.Initials150ImageId = Initials150ImageId;
            this.InitialsImageUri = InitialsImageUri;
            this.IsDefault = IsDefault;
            this.LastModifiedDateTime = LastModifiedDateTime;
            this.NrdsId = NrdsId;
            this.NrdsLastName = NrdsLastName;
            this.NrdsStatus = NrdsStatus;
            this.PhoneticName = PhoneticName;
            this.Signature150ImageId = Signature150ImageId;
            this.SignatureFont = SignatureFont;
            this.SignatureId = SignatureId;
            this.SignatureImageUri = SignatureImageUri;
            this.SignatureInitials = SignatureInitials;
            this.SignatureName = SignatureName;
            this.SignatureRights = SignatureRights;
            this.SignatureType = SignatureType;
            this.StampFormat = StampFormat;
            this.StampImageUri = StampImageUri;
            this.StampSizeMM = StampSizeMM;
            this.StampType = StampType;
            this.Status = Status;
        }
        
        /// <summary>
        /// The date and time the user adopted their signature.
        /// </summary>
        /// <value>The date and time the user adopted their signature.</value>
        [DataMember(Name="adoptedDateTime", EmitDefaultValue=false)]
        public string AdoptedDateTime { get; set; }
        /// <summary>
        /// Indicates the date and time the item was created.
        /// </summary>
        /// <value>Indicates the date and time the item was created.</value>
        [DataMember(Name="createdDateTime", EmitDefaultValue=false)]
        public string CreatedDateTime { get; set; }
        /// <summary>
        /// Gets or Sets CustomField
        /// </summary>
        [DataMember(Name="customField", EmitDefaultValue=false)]
        public string CustomField { get; set; }
        /// <summary>
        /// Specifies the area in which a date stamp is placed. This parameter uses pixel positioning to draw a rectangle at the center of the stamp area. The stamp is superimposed on top of this central area.  This property contains the following information about the central rectangle:  - &#x60;DateAreaX&#x60;: The X axis position of the top-left corner. - &#x60;DateAreaY&#x60;: The Y axis position of the top-left corner. - &#x60;DateAreaWidth&#x60;: The width of the rectangle. - &#x60;DateAreaHeight&#x60;: The height of the rectangle.
        /// </summary>
        /// <value>Specifies the area in which a date stamp is placed. This parameter uses pixel positioning to draw a rectangle at the center of the stamp area. The stamp is superimposed on top of this central area.  This property contains the following information about the central rectangle:  - &#x60;DateAreaX&#x60;: The X axis position of the top-left corner. - &#x60;DateAreaY&#x60;: The Y axis position of the top-left corner. - &#x60;DateAreaWidth&#x60;: The width of the rectangle. - &#x60;DateAreaHeight&#x60;: The height of the rectangle.</value>
        [DataMember(Name="dateStampProperties", EmitDefaultValue=false)]
        public DateStampProperties DateStampProperties { get; set; }
        /// <summary>
        /// Gets or Sets DisallowUserResizeStamp
        /// </summary>
        [DataMember(Name="disallowUserResizeStamp", EmitDefaultValue=false)]
        public string DisallowUserResizeStamp { get; set; }
        /// <summary>
        /// Array or errors.
        /// </summary>
        /// <value>Array or errors.</value>
        [DataMember(Name="errorDetails", EmitDefaultValue=false)]
        public ErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Gets or Sets ExternalID
        /// </summary>
        [DataMember(Name="externalID", EmitDefaultValue=false)]
        public string ExternalID { get; set; }
        /// <summary>
        /// Gets or Sets ImageBase64
        /// </summary>
        [DataMember(Name="imageBase64", EmitDefaultValue=false)]
        public string ImageBase64 { get; set; }
        /// <summary>
        /// Gets or Sets ImageType
        /// </summary>
        [DataMember(Name="imageType", EmitDefaultValue=false)]
        public string ImageType { get; set; }
        /// <summary>
        /// Gets or Sets Initials150ImageId
        /// </summary>
        [DataMember(Name="initials150ImageId", EmitDefaultValue=false)]
        public string Initials150ImageId { get; set; }
        /// <summary>
        /// Contains the URI for an endpoint that you can use to retrieve the initials image.
        /// </summary>
        /// <value>Contains the URI for an endpoint that you can use to retrieve the initials image.</value>
        [DataMember(Name="initialsImageUri", EmitDefaultValue=false)]
        public string InitialsImageUri { get; set; }
        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name="isDefault", EmitDefaultValue=false)]
        public string IsDefault { get; set; }
        /// <summary>
        /// The date and time the item was last modified.
        /// </summary>
        /// <value>The date and time the item was last modified.</value>
        [DataMember(Name="lastModifiedDateTime", EmitDefaultValue=false)]
        public string LastModifiedDateTime { get; set; }
        /// <summary>
        /// Gets or Sets NrdsId
        /// </summary>
        [DataMember(Name="nrdsId", EmitDefaultValue=false)]
        public string NrdsId { get; set; }
        /// <summary>
        /// Gets or Sets NrdsLastName
        /// </summary>
        [DataMember(Name="nrdsLastName", EmitDefaultValue=false)]
        public string NrdsLastName { get; set; }
        /// <summary>
        /// Gets or Sets NrdsStatus
        /// </summary>
        [DataMember(Name="nrdsStatus", EmitDefaultValue=false)]
        public string NrdsStatus { get; set; }
        /// <summary>
        /// Gets or Sets PhoneticName
        /// </summary>
        [DataMember(Name="phoneticName", EmitDefaultValue=false)]
        public string PhoneticName { get; set; }
        /// <summary>
        /// Gets or Sets Signature150ImageId
        /// </summary>
        [DataMember(Name="signature150ImageId", EmitDefaultValue=false)]
        public string Signature150ImageId { get; set; }
        /// <summary>
        /// The font type for the signature, if the signature is not drawn. The supported font types are:  \&quot;7_DocuSign\&quot;, \&quot;1_DocuSign\&quot;, \&quot;6_DocuSign\&quot;, \&quot;8_DocuSign\&quot;, \&quot;3_DocuSign\&quot;, \&quot;Mistral\&quot;, \&quot;4_DocuSign\&quot;, \&quot;2_DocuSign\&quot;, \&quot;5_DocuSign\&quot;, \&quot;Rage Italic\&quot; 
        /// </summary>
        /// <value>The font type for the signature, if the signature is not drawn. The supported font types are:  \&quot;7_DocuSign\&quot;, \&quot;1_DocuSign\&quot;, \&quot;6_DocuSign\&quot;, \&quot;8_DocuSign\&quot;, \&quot;3_DocuSign\&quot;, \&quot;Mistral\&quot;, \&quot;4_DocuSign\&quot;, \&quot;2_DocuSign\&quot;, \&quot;5_DocuSign\&quot;, \&quot;Rage Italic\&quot; </value>
        [DataMember(Name="signatureFont", EmitDefaultValue=false)]
        public string SignatureFont { get; set; }
        /// <summary>
        /// Specifies the signature ID associated with the signature name. You can use the signature ID in the URI in place of the signature name, and the value stored in the &#x60;signatureName&#x60; property in the body is used. This allows the use of special characters (such as \&quot;&amp;\&quot;, \&quot;&lt;\&quot;, \&quot;&gt;\&quot;) in a the signature name. Note that with each update to signatures, the returned signature ID might change, so the caller will need to trigger off the signature name to get the new signature ID.
        /// </summary>
        /// <value>Specifies the signature ID associated with the signature name. You can use the signature ID in the URI in place of the signature name, and the value stored in the &#x60;signatureName&#x60; property in the body is used. This allows the use of special characters (such as \&quot;&amp;\&quot;, \&quot;&lt;\&quot;, \&quot;&gt;\&quot;) in a the signature name. Note that with each update to signatures, the returned signature ID might change, so the caller will need to trigger off the signature name to get the new signature ID.</value>
        [DataMember(Name="signatureId", EmitDefaultValue=false)]
        public string SignatureId { get; set; }
        /// <summary>
        /// Contains the URI for an endpoint that you can use to retrieve the signature image.
        /// </summary>
        /// <value>Contains the URI for an endpoint that you can use to retrieve the signature image.</value>
        [DataMember(Name="signatureImageUri", EmitDefaultValue=false)]
        public string SignatureImageUri { get; set; }
        /// <summary>
        ///  The initials associated with the signature.
        /// </summary>
        /// <value> The initials associated with the signature.</value>
        [DataMember(Name="signatureInitials", EmitDefaultValue=false)]
        public string SignatureInitials { get; set; }
        /// <summary>
        /// Specifies the user signature name.
        /// </summary>
        /// <value>Specifies the user signature name.</value>
        [DataMember(Name="signatureName", EmitDefaultValue=false)]
        public string SignatureName { get; set; }
        /// <summary>
        /// Gets or Sets SignatureRights
        /// </summary>
        [DataMember(Name="signatureRights", EmitDefaultValue=false)]
        public string SignatureRights { get; set; }
        /// <summary>
        /// Gets or Sets SignatureType
        /// </summary>
        [DataMember(Name="signatureType", EmitDefaultValue=false)]
        public string SignatureType { get; set; }
        /// <summary>
        /// Gets or Sets StampFormat
        /// </summary>
        [DataMember(Name="stampFormat", EmitDefaultValue=false)]
        public string StampFormat { get; set; }
        /// <summary>
        /// Gets or Sets StampImageUri
        /// </summary>
        [DataMember(Name="stampImageUri", EmitDefaultValue=false)]
        public string StampImageUri { get; set; }
        /// <summary>
        /// Gets or Sets StampSizeMM
        /// </summary>
        [DataMember(Name="stampSizeMM", EmitDefaultValue=false)]
        public string StampSizeMM { get; set; }
        /// <summary>
        /// Gets or Sets StampType
        /// </summary>
        [DataMember(Name="stampType", EmitDefaultValue=false)]
        public string StampType { get; set; }
        /// <summary>
        /// Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later.
        /// </summary>
        /// <value>Indicates the envelope status. Valid values are:  * sent - The envelope is sent to the recipients.  * created - The envelope is saved as a draft and can be modified and sent later.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSignature {\n");
            sb.Append("  AdoptedDateTime: ").Append(AdoptedDateTime).Append("\n");
            sb.Append("  CreatedDateTime: ").Append(CreatedDateTime).Append("\n");
            sb.Append("  CustomField: ").Append(CustomField).Append("\n");
            sb.Append("  DateStampProperties: ").Append(DateStampProperties).Append("\n");
            sb.Append("  DisallowUserResizeStamp: ").Append(DisallowUserResizeStamp).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  ExternalID: ").Append(ExternalID).Append("\n");
            sb.Append("  ImageBase64: ").Append(ImageBase64).Append("\n");
            sb.Append("  ImageType: ").Append(ImageType).Append("\n");
            sb.Append("  Initials150ImageId: ").Append(Initials150ImageId).Append("\n");
            sb.Append("  InitialsImageUri: ").Append(InitialsImageUri).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  LastModifiedDateTime: ").Append(LastModifiedDateTime).Append("\n");
            sb.Append("  NrdsId: ").Append(NrdsId).Append("\n");
            sb.Append("  NrdsLastName: ").Append(NrdsLastName).Append("\n");
            sb.Append("  NrdsStatus: ").Append(NrdsStatus).Append("\n");
            sb.Append("  PhoneticName: ").Append(PhoneticName).Append("\n");
            sb.Append("  Signature150ImageId: ").Append(Signature150ImageId).Append("\n");
            sb.Append("  SignatureFont: ").Append(SignatureFont).Append("\n");
            sb.Append("  SignatureId: ").Append(SignatureId).Append("\n");
            sb.Append("  SignatureImageUri: ").Append(SignatureImageUri).Append("\n");
            sb.Append("  SignatureInitials: ").Append(SignatureInitials).Append("\n");
            sb.Append("  SignatureName: ").Append(SignatureName).Append("\n");
            sb.Append("  SignatureRights: ").Append(SignatureRights).Append("\n");
            sb.Append("  SignatureType: ").Append(SignatureType).Append("\n");
            sb.Append("  StampFormat: ").Append(StampFormat).Append("\n");
            sb.Append("  StampImageUri: ").Append(StampImageUri).Append("\n");
            sb.Append("  StampSizeMM: ").Append(StampSizeMM).Append("\n");
            sb.Append("  StampType: ").Append(StampType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as UserSignature);
        }

        /// <summary>
        /// Returns true if UserSignature instances are equal
        /// </summary>
        /// <param name="other">Instance of UserSignature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSignature other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AdoptedDateTime == other.AdoptedDateTime ||
                    this.AdoptedDateTime != null &&
                    this.AdoptedDateTime.Equals(other.AdoptedDateTime)
                ) && 
                (
                    this.CreatedDateTime == other.CreatedDateTime ||
                    this.CreatedDateTime != null &&
                    this.CreatedDateTime.Equals(other.CreatedDateTime)
                ) && 
                (
                    this.CustomField == other.CustomField ||
                    this.CustomField != null &&
                    this.CustomField.Equals(other.CustomField)
                ) && 
                (
                    this.DateStampProperties == other.DateStampProperties ||
                    this.DateStampProperties != null &&
                    this.DateStampProperties.Equals(other.DateStampProperties)
                ) && 
                (
                    this.DisallowUserResizeStamp == other.DisallowUserResizeStamp ||
                    this.DisallowUserResizeStamp != null &&
                    this.DisallowUserResizeStamp.Equals(other.DisallowUserResizeStamp)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.ExternalID == other.ExternalID ||
                    this.ExternalID != null &&
                    this.ExternalID.Equals(other.ExternalID)
                ) && 
                (
                    this.ImageBase64 == other.ImageBase64 ||
                    this.ImageBase64 != null &&
                    this.ImageBase64.Equals(other.ImageBase64)
                ) && 
                (
                    this.ImageType == other.ImageType ||
                    this.ImageType != null &&
                    this.ImageType.Equals(other.ImageType)
                ) && 
                (
                    this.Initials150ImageId == other.Initials150ImageId ||
                    this.Initials150ImageId != null &&
                    this.Initials150ImageId.Equals(other.Initials150ImageId)
                ) && 
                (
                    this.InitialsImageUri == other.InitialsImageUri ||
                    this.InitialsImageUri != null &&
                    this.InitialsImageUri.Equals(other.InitialsImageUri)
                ) && 
                (
                    this.IsDefault == other.IsDefault ||
                    this.IsDefault != null &&
                    this.IsDefault.Equals(other.IsDefault)
                ) && 
                (
                    this.LastModifiedDateTime == other.LastModifiedDateTime ||
                    this.LastModifiedDateTime != null &&
                    this.LastModifiedDateTime.Equals(other.LastModifiedDateTime)
                ) && 
                (
                    this.NrdsId == other.NrdsId ||
                    this.NrdsId != null &&
                    this.NrdsId.Equals(other.NrdsId)
                ) && 
                (
                    this.NrdsLastName == other.NrdsLastName ||
                    this.NrdsLastName != null &&
                    this.NrdsLastName.Equals(other.NrdsLastName)
                ) && 
                (
                    this.NrdsStatus == other.NrdsStatus ||
                    this.NrdsStatus != null &&
                    this.NrdsStatus.Equals(other.NrdsStatus)
                ) && 
                (
                    this.PhoneticName == other.PhoneticName ||
                    this.PhoneticName != null &&
                    this.PhoneticName.Equals(other.PhoneticName)
                ) && 
                (
                    this.Signature150ImageId == other.Signature150ImageId ||
                    this.Signature150ImageId != null &&
                    this.Signature150ImageId.Equals(other.Signature150ImageId)
                ) && 
                (
                    this.SignatureFont == other.SignatureFont ||
                    this.SignatureFont != null &&
                    this.SignatureFont.Equals(other.SignatureFont)
                ) && 
                (
                    this.SignatureId == other.SignatureId ||
                    this.SignatureId != null &&
                    this.SignatureId.Equals(other.SignatureId)
                ) && 
                (
                    this.SignatureImageUri == other.SignatureImageUri ||
                    this.SignatureImageUri != null &&
                    this.SignatureImageUri.Equals(other.SignatureImageUri)
                ) && 
                (
                    this.SignatureInitials == other.SignatureInitials ||
                    this.SignatureInitials != null &&
                    this.SignatureInitials.Equals(other.SignatureInitials)
                ) && 
                (
                    this.SignatureName == other.SignatureName ||
                    this.SignatureName != null &&
                    this.SignatureName.Equals(other.SignatureName)
                ) && 
                (
                    this.SignatureRights == other.SignatureRights ||
                    this.SignatureRights != null &&
                    this.SignatureRights.Equals(other.SignatureRights)
                ) && 
                (
                    this.SignatureType == other.SignatureType ||
                    this.SignatureType != null &&
                    this.SignatureType.Equals(other.SignatureType)
                ) && 
                (
                    this.StampFormat == other.StampFormat ||
                    this.StampFormat != null &&
                    this.StampFormat.Equals(other.StampFormat)
                ) && 
                (
                    this.StampImageUri == other.StampImageUri ||
                    this.StampImageUri != null &&
                    this.StampImageUri.Equals(other.StampImageUri)
                ) && 
                (
                    this.StampSizeMM == other.StampSizeMM ||
                    this.StampSizeMM != null &&
                    this.StampSizeMM.Equals(other.StampSizeMM)
                ) && 
                (
                    this.StampType == other.StampType ||
                    this.StampType != null &&
                    this.StampType.Equals(other.StampType)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.AdoptedDateTime != null)
                    hash = hash * 59 + this.AdoptedDateTime.GetHashCode();
                if (this.CreatedDateTime != null)
                    hash = hash * 59 + this.CreatedDateTime.GetHashCode();
                if (this.CustomField != null)
                    hash = hash * 59 + this.CustomField.GetHashCode();
                if (this.DateStampProperties != null)
                    hash = hash * 59 + this.DateStampProperties.GetHashCode();
                if (this.DisallowUserResizeStamp != null)
                    hash = hash * 59 + this.DisallowUserResizeStamp.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.ExternalID != null)
                    hash = hash * 59 + this.ExternalID.GetHashCode();
                if (this.ImageBase64 != null)
                    hash = hash * 59 + this.ImageBase64.GetHashCode();
                if (this.ImageType != null)
                    hash = hash * 59 + this.ImageType.GetHashCode();
                if (this.Initials150ImageId != null)
                    hash = hash * 59 + this.Initials150ImageId.GetHashCode();
                if (this.InitialsImageUri != null)
                    hash = hash * 59 + this.InitialsImageUri.GetHashCode();
                if (this.IsDefault != null)
                    hash = hash * 59 + this.IsDefault.GetHashCode();
                if (this.LastModifiedDateTime != null)
                    hash = hash * 59 + this.LastModifiedDateTime.GetHashCode();
                if (this.NrdsId != null)
                    hash = hash * 59 + this.NrdsId.GetHashCode();
                if (this.NrdsLastName != null)
                    hash = hash * 59 + this.NrdsLastName.GetHashCode();
                if (this.NrdsStatus != null)
                    hash = hash * 59 + this.NrdsStatus.GetHashCode();
                if (this.PhoneticName != null)
                    hash = hash * 59 + this.PhoneticName.GetHashCode();
                if (this.Signature150ImageId != null)
                    hash = hash * 59 + this.Signature150ImageId.GetHashCode();
                if (this.SignatureFont != null)
                    hash = hash * 59 + this.SignatureFont.GetHashCode();
                if (this.SignatureId != null)
                    hash = hash * 59 + this.SignatureId.GetHashCode();
                if (this.SignatureImageUri != null)
                    hash = hash * 59 + this.SignatureImageUri.GetHashCode();
                if (this.SignatureInitials != null)
                    hash = hash * 59 + this.SignatureInitials.GetHashCode();
                if (this.SignatureName != null)
                    hash = hash * 59 + this.SignatureName.GetHashCode();
                if (this.SignatureRights != null)
                    hash = hash * 59 + this.SignatureRights.GetHashCode();
                if (this.SignatureType != null)
                    hash = hash * 59 + this.SignatureType.GetHashCode();
                if (this.StampFormat != null)
                    hash = hash * 59 + this.StampFormat.GetHashCode();
                if (this.StampImageUri != null)
                    hash = hash * 59 + this.StampImageUri.GetHashCode();
                if (this.StampSizeMM != null)
                    hash = hash * 59 + this.StampSizeMM.GetHashCode();
                if (this.StampType != null)
                    hash = hash * 59 + this.StampType.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
