/* 
 * Docusign eSignature REST API
 *
 * The Docusign eSignature REST API provides you with a powerful, convenient, and simple Web services API for interacting with Docusign.
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
    /// This optional complex element allows a message to be sent a specified URL when the envelope or recipient changes status. It is similar to DocuSign Connect. For example, if an envelope changes from \&quot;Sent\&quot; to \&quot;Delivered\&quot;, a message containing the updated envelope status and optionally the documents is sent to the URL. When an eventNotification is attached to an envelope using the API, it only applies to the envelope (treating the envelope as the sender). This is different from envelopes created through the console user interface, where the user is treated as the sender.
    /// </summary>
    [DataContract]
    public partial class EventNotification :  IEquatable<EventNotification>, IValidatableObject
    {
        public EventNotification()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventNotification" /> class.
        /// </summary>
        /// <param name="DeliveryMode">DeliveryMode.</param>
        /// <param name="EnvelopeEvents">A list of envelope-level event statuses that will trigger Connect to send updates to the endpoint specified in the &#x60;url&#x60; property.   To receive notifications, you must include either an &#x60;envelopeEvents&#x60; node or a &#x60;recipientEvents&#x60; node. You do not need to specify both..</param>
        /// <param name="EventData">Allows you to specify the format of the information the Connect webhooks returns. For more information, see [Connect webhooks with JSON notifications](https://www.docusign.com/blog/developers/connect-webhooks-json-notifications).</param>
        /// <param name="Events">Events.</param>
        /// <param name="IncludeCertificateOfCompletion">When set to **true**, the Connect Service includes the Certificate of Completion with completed envelopes. .</param>
        /// <param name="IncludeCertificateWithSoap">When set to **true**, this tells the Connect service to send the DocuSign signedby certificate as part of the outgoing SOAP xml. This appears in the XML as wsse:BinarySecurityToken..</param>
        /// <param name="IncludeDocumentFields">When set to **true**, the Document Fields associated with envelope documents are included in the data. Document Fields are optional custom name-value pairs added to documents using the API. .</param>
        /// <param name="IncludeDocuments">When set to **true**, the PDF documents are included in the message along with the updated XML. .</param>
        /// <param name="IncludeEnvelopeVoidReason">When set to **true**, this tells the Connect Service to include the void reason, as entered by the person that voided the envelope, in the message. .</param>
        /// <param name="IncludeHMAC">IncludeHMAC.</param>
        /// <param name="IncludeOAuth">IncludeOAuth.</param>
        /// <param name="IncludeSenderAccountAsCustomField">When set to **true**, the sender account ID is included as a envelope custom field in the data. .</param>
        /// <param name="IncludeTimeZone">When set to **true**, the envelope time zone information is included in the message. .</param>
        /// <param name="IntegratorManaged">IntegratorManaged.</param>
        /// <param name="LoggingEnabled">When set to **true**, logging is turned on for envelope events on the Web Console Connect page. .</param>
        /// <param name="RecipientEvents">A list of recipient event statuses that will trigger Connect to send updates to   the endpoint specified in the url property.  To receive notifications, you must include either an &#x60;envelopeEvents&#x60; node or a &#x60;recipientEvents&#x60; node. You do not need to specify both..</param>
        /// <param name="RequireAcknowledgment">When set to **true**, the DocuSign Connect service checks that the message was received and retries on failures. .</param>
        /// <param name="SignMessageWithX509Cert">When set to **true**, messages are signed with an X509 certificate. This provides support for 2-way SSL in the envelope. .</param>
        /// <param name="SoapNameSpace">This lists the namespace in the SOAP listener provided..</param>
        /// <param name="Url">Specifies the endpoint to which envelope updates are sent. Udpates are sent as XML unless &#x60;useSoapInterface&#x60; property is set to **true**..</param>
        /// <param name="UseSoapInterface">When set to **true**, this tells the Connect service that the user&#39;s endpoint has implemented a SOAP interface. .</param>
        public EventNotification(string DeliveryMode = default(string), List<EnvelopeEvent> EnvelopeEvents = default(List<EnvelopeEvent>), ConnectEventData EventData = default(ConnectEventData), List<string> Events = default(List<string>), string IncludeCertificateOfCompletion = default(string), string IncludeCertificateWithSoap = default(string), string IncludeDocumentFields = default(string), string IncludeDocuments = default(string), string IncludeEnvelopeVoidReason = default(string), string IncludeHMAC = default(string), string IncludeOAuth = default(string), string IncludeSenderAccountAsCustomField = default(string), string IncludeTimeZone = default(string), string IntegratorManaged = default(string), string LoggingEnabled = default(string), List<RecipientEvent> RecipientEvents = default(List<RecipientEvent>), string RequireAcknowledgment = default(string), string SignMessageWithX509Cert = default(string), string SoapNameSpace = default(string), string Url = default(string), string UseSoapInterface = default(string))
        {
            this.DeliveryMode = DeliveryMode;
            this.EnvelopeEvents = EnvelopeEvents;
            this.EventData = EventData;
            this.Events = Events;
            this.IncludeCertificateOfCompletion = IncludeCertificateOfCompletion;
            this.IncludeCertificateWithSoap = IncludeCertificateWithSoap;
            this.IncludeDocumentFields = IncludeDocumentFields;
            this.IncludeDocuments = IncludeDocuments;
            this.IncludeEnvelopeVoidReason = IncludeEnvelopeVoidReason;
            this.IncludeHMAC = IncludeHMAC;
            this.IncludeOAuth = IncludeOAuth;
            this.IncludeSenderAccountAsCustomField = IncludeSenderAccountAsCustomField;
            this.IncludeTimeZone = IncludeTimeZone;
            this.IntegratorManaged = IntegratorManaged;
            this.LoggingEnabled = LoggingEnabled;
            this.RecipientEvents = RecipientEvents;
            this.RequireAcknowledgment = RequireAcknowledgment;
            this.SignMessageWithX509Cert = SignMessageWithX509Cert;
            this.SoapNameSpace = SoapNameSpace;
            this.Url = Url;
            this.UseSoapInterface = UseSoapInterface;
        }
        
        /// <summary>
        /// Gets or Sets DeliveryMode
        /// </summary>
        [DataMember(Name="deliveryMode", EmitDefaultValue=false)]
        public string DeliveryMode { get; set; }
        /// <summary>
        /// A list of envelope-level event statuses that will trigger Connect to send updates to the endpoint specified in the &#x60;url&#x60; property.   To receive notifications, you must include either an &#x60;envelopeEvents&#x60; node or a &#x60;recipientEvents&#x60; node. You do not need to specify both.
        /// </summary>
        /// <value>A list of envelope-level event statuses that will trigger Connect to send updates to the endpoint specified in the &#x60;url&#x60; property.   To receive notifications, you must include either an &#x60;envelopeEvents&#x60; node or a &#x60;recipientEvents&#x60; node. You do not need to specify both.</value>
        [DataMember(Name="envelopeEvents", EmitDefaultValue=false)]
        public List<EnvelopeEvent> EnvelopeEvents { get; set; }
        /// <summary>
        /// Allows you to specify the format of the information the Connect webhooks returns. For more information, see [Connect webhooks with JSON notifications](https://www.docusign.com/blog/developers/connect-webhooks-json-notifications)
        /// </summary>
        /// <value>Allows you to specify the format of the information the Connect webhooks returns. For more information, see [Connect webhooks with JSON notifications](https://www.docusign.com/blog/developers/connect-webhooks-json-notifications)</value>
        [DataMember(Name="eventData", EmitDefaultValue=false)]
        public ConnectEventData EventData { get; set; }
        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<string> Events { get; set; }
        /// <summary>
        /// When set to **true**, the Connect Service includes the Certificate of Completion with completed envelopes. 
        /// </summary>
        /// <value>When set to **true**, the Connect Service includes the Certificate of Completion with completed envelopes. </value>
        [DataMember(Name="includeCertificateOfCompletion", EmitDefaultValue=false)]
        public string IncludeCertificateOfCompletion { get; set; }
        /// <summary>
        /// When set to **true**, this tells the Connect service to send the DocuSign signedby certificate as part of the outgoing SOAP xml. This appears in the XML as wsse:BinarySecurityToken.
        /// </summary>
        /// <value>When set to **true**, this tells the Connect service to send the DocuSign signedby certificate as part of the outgoing SOAP xml. This appears in the XML as wsse:BinarySecurityToken.</value>
        [DataMember(Name="includeCertificateWithSoap", EmitDefaultValue=false)]
        public string IncludeCertificateWithSoap { get; set; }
        /// <summary>
        /// When set to **true**, the Document Fields associated with envelope documents are included in the data. Document Fields are optional custom name-value pairs added to documents using the API. 
        /// </summary>
        /// <value>When set to **true**, the Document Fields associated with envelope documents are included in the data. Document Fields are optional custom name-value pairs added to documents using the API. </value>
        [DataMember(Name="includeDocumentFields", EmitDefaultValue=false)]
        public string IncludeDocumentFields { get; set; }
        /// <summary>
        /// When set to **true**, the PDF documents are included in the message along with the updated XML. 
        /// </summary>
        /// <value>When set to **true**, the PDF documents are included in the message along with the updated XML. </value>
        [DataMember(Name="includeDocuments", EmitDefaultValue=false)]
        public string IncludeDocuments { get; set; }
        /// <summary>
        /// When set to **true**, this tells the Connect Service to include the void reason, as entered by the person that voided the envelope, in the message. 
        /// </summary>
        /// <value>When set to **true**, this tells the Connect Service to include the void reason, as entered by the person that voided the envelope, in the message. </value>
        [DataMember(Name="includeEnvelopeVoidReason", EmitDefaultValue=false)]
        public string IncludeEnvelopeVoidReason { get; set; }
        /// <summary>
        /// Gets or Sets IncludeHMAC
        /// </summary>
        [DataMember(Name="includeHMAC", EmitDefaultValue=false)]
        public string IncludeHMAC { get; set; }
        /// <summary>
        /// Gets or Sets IncludeOAuth
        /// </summary>
        [DataMember(Name="includeOAuth", EmitDefaultValue=false)]
        public string IncludeOAuth { get; set; }
        /// <summary>
        /// When set to **true**, the sender account ID is included as a envelope custom field in the data. 
        /// </summary>
        /// <value>When set to **true**, the sender account ID is included as a envelope custom field in the data. </value>
        [DataMember(Name="includeSenderAccountAsCustomField", EmitDefaultValue=false)]
        public string IncludeSenderAccountAsCustomField { get; set; }
        /// <summary>
        /// When set to **true**, the envelope time zone information is included in the message. 
        /// </summary>
        /// <value>When set to **true**, the envelope time zone information is included in the message. </value>
        [DataMember(Name="includeTimeZone", EmitDefaultValue=false)]
        public string IncludeTimeZone { get; set; }
        /// <summary>
        /// Gets or Sets IntegratorManaged
        /// </summary>
        [DataMember(Name="integratorManaged", EmitDefaultValue=false)]
        public string IntegratorManaged { get; set; }
        /// <summary>
        /// When set to **true**, logging is turned on for envelope events on the Web Console Connect page. 
        /// </summary>
        /// <value>When set to **true**, logging is turned on for envelope events on the Web Console Connect page. </value>
        [DataMember(Name="loggingEnabled", EmitDefaultValue=false)]
        public string LoggingEnabled { get; set; }
        /// <summary>
        /// A list of recipient event statuses that will trigger Connect to send updates to   the endpoint specified in the url property.  To receive notifications, you must include either an &#x60;envelopeEvents&#x60; node or a &#x60;recipientEvents&#x60; node. You do not need to specify both.
        /// </summary>
        /// <value>A list of recipient event statuses that will trigger Connect to send updates to   the endpoint specified in the url property.  To receive notifications, you must include either an &#x60;envelopeEvents&#x60; node or a &#x60;recipientEvents&#x60; node. You do not need to specify both.</value>
        [DataMember(Name="recipientEvents", EmitDefaultValue=false)]
        public List<RecipientEvent> RecipientEvents { get; set; }
        /// <summary>
        /// When set to **true**, the DocuSign Connect service checks that the message was received and retries on failures. 
        /// </summary>
        /// <value>When set to **true**, the DocuSign Connect service checks that the message was received and retries on failures. </value>
        [DataMember(Name="requireAcknowledgment", EmitDefaultValue=false)]
        public string RequireAcknowledgment { get; set; }
        /// <summary>
        /// When set to **true**, messages are signed with an X509 certificate. This provides support for 2-way SSL in the envelope. 
        /// </summary>
        /// <value>When set to **true**, messages are signed with an X509 certificate. This provides support for 2-way SSL in the envelope. </value>
        [DataMember(Name="signMessageWithX509Cert", EmitDefaultValue=false)]
        public string SignMessageWithX509Cert { get; set; }
        /// <summary>
        /// This lists the namespace in the SOAP listener provided.
        /// </summary>
        /// <value>This lists the namespace in the SOAP listener provided.</value>
        [DataMember(Name="soapNameSpace", EmitDefaultValue=false)]
        public string SoapNameSpace { get; set; }
        /// <summary>
        /// Specifies the endpoint to which envelope updates are sent. Udpates are sent as XML unless &#x60;useSoapInterface&#x60; property is set to **true**.
        /// </summary>
        /// <value>Specifies the endpoint to which envelope updates are sent. Udpates are sent as XML unless &#x60;useSoapInterface&#x60; property is set to **true**.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// When set to **true**, this tells the Connect service that the user&#39;s endpoint has implemented a SOAP interface. 
        /// </summary>
        /// <value>When set to **true**, this tells the Connect service that the user&#39;s endpoint has implemented a SOAP interface. </value>
        [DataMember(Name="useSoapInterface", EmitDefaultValue=false)]
        public string UseSoapInterface { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EventNotification {\n");
            sb.Append("  DeliveryMode: ").Append(DeliveryMode).Append("\n");
            sb.Append("  EnvelopeEvents: ").Append(EnvelopeEvents).Append("\n");
            sb.Append("  EventData: ").Append(EventData).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  IncludeCertificateOfCompletion: ").Append(IncludeCertificateOfCompletion).Append("\n");
            sb.Append("  IncludeCertificateWithSoap: ").Append(IncludeCertificateWithSoap).Append("\n");
            sb.Append("  IncludeDocumentFields: ").Append(IncludeDocumentFields).Append("\n");
            sb.Append("  IncludeDocuments: ").Append(IncludeDocuments).Append("\n");
            sb.Append("  IncludeEnvelopeVoidReason: ").Append(IncludeEnvelopeVoidReason).Append("\n");
            sb.Append("  IncludeHMAC: ").Append(IncludeHMAC).Append("\n");
            sb.Append("  IncludeOAuth: ").Append(IncludeOAuth).Append("\n");
            sb.Append("  IncludeSenderAccountAsCustomField: ").Append(IncludeSenderAccountAsCustomField).Append("\n");
            sb.Append("  IncludeTimeZone: ").Append(IncludeTimeZone).Append("\n");
            sb.Append("  IntegratorManaged: ").Append(IntegratorManaged).Append("\n");
            sb.Append("  LoggingEnabled: ").Append(LoggingEnabled).Append("\n");
            sb.Append("  RecipientEvents: ").Append(RecipientEvents).Append("\n");
            sb.Append("  RequireAcknowledgment: ").Append(RequireAcknowledgment).Append("\n");
            sb.Append("  SignMessageWithX509Cert: ").Append(SignMessageWithX509Cert).Append("\n");
            sb.Append("  SoapNameSpace: ").Append(SoapNameSpace).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  UseSoapInterface: ").Append(UseSoapInterface).Append("\n");
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
            return this.Equals(obj as EventNotification);
        }

        /// <summary>
        /// Returns true if EventNotification instances are equal
        /// </summary>
        /// <param name="other">Instance of EventNotification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventNotification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DeliveryMode == other.DeliveryMode ||
                    this.DeliveryMode != null &&
                    this.DeliveryMode.Equals(other.DeliveryMode)
                ) && 
                (
                    this.EnvelopeEvents == other.EnvelopeEvents ||
                    this.EnvelopeEvents != null &&
                    this.EnvelopeEvents.SequenceEqual(other.EnvelopeEvents)
                ) && 
                (
                    this.EventData == other.EventData ||
                    this.EventData != null &&
                    this.EventData.Equals(other.EventData)
                ) && 
                (
                    this.Events == other.Events ||
                    this.Events != null &&
                    this.Events.SequenceEqual(other.Events)
                ) && 
                (
                    this.IncludeCertificateOfCompletion == other.IncludeCertificateOfCompletion ||
                    this.IncludeCertificateOfCompletion != null &&
                    this.IncludeCertificateOfCompletion.Equals(other.IncludeCertificateOfCompletion)
                ) && 
                (
                    this.IncludeCertificateWithSoap == other.IncludeCertificateWithSoap ||
                    this.IncludeCertificateWithSoap != null &&
                    this.IncludeCertificateWithSoap.Equals(other.IncludeCertificateWithSoap)
                ) && 
                (
                    this.IncludeDocumentFields == other.IncludeDocumentFields ||
                    this.IncludeDocumentFields != null &&
                    this.IncludeDocumentFields.Equals(other.IncludeDocumentFields)
                ) && 
                (
                    this.IncludeDocuments == other.IncludeDocuments ||
                    this.IncludeDocuments != null &&
                    this.IncludeDocuments.Equals(other.IncludeDocuments)
                ) && 
                (
                    this.IncludeEnvelopeVoidReason == other.IncludeEnvelopeVoidReason ||
                    this.IncludeEnvelopeVoidReason != null &&
                    this.IncludeEnvelopeVoidReason.Equals(other.IncludeEnvelopeVoidReason)
                ) && 
                (
                    this.IncludeHMAC == other.IncludeHMAC ||
                    this.IncludeHMAC != null &&
                    this.IncludeHMAC.Equals(other.IncludeHMAC)
                ) && 
                (
                    this.IncludeOAuth == other.IncludeOAuth ||
                    this.IncludeOAuth != null &&
                    this.IncludeOAuth.Equals(other.IncludeOAuth)
                ) && 
                (
                    this.IncludeSenderAccountAsCustomField == other.IncludeSenderAccountAsCustomField ||
                    this.IncludeSenderAccountAsCustomField != null &&
                    this.IncludeSenderAccountAsCustomField.Equals(other.IncludeSenderAccountAsCustomField)
                ) && 
                (
                    this.IncludeTimeZone == other.IncludeTimeZone ||
                    this.IncludeTimeZone != null &&
                    this.IncludeTimeZone.Equals(other.IncludeTimeZone)
                ) && 
                (
                    this.IntegratorManaged == other.IntegratorManaged ||
                    this.IntegratorManaged != null &&
                    this.IntegratorManaged.Equals(other.IntegratorManaged)
                ) && 
                (
                    this.LoggingEnabled == other.LoggingEnabled ||
                    this.LoggingEnabled != null &&
                    this.LoggingEnabled.Equals(other.LoggingEnabled)
                ) && 
                (
                    this.RecipientEvents == other.RecipientEvents ||
                    this.RecipientEvents != null &&
                    this.RecipientEvents.SequenceEqual(other.RecipientEvents)
                ) && 
                (
                    this.RequireAcknowledgment == other.RequireAcknowledgment ||
                    this.RequireAcknowledgment != null &&
                    this.RequireAcknowledgment.Equals(other.RequireAcknowledgment)
                ) && 
                (
                    this.SignMessageWithX509Cert == other.SignMessageWithX509Cert ||
                    this.SignMessageWithX509Cert != null &&
                    this.SignMessageWithX509Cert.Equals(other.SignMessageWithX509Cert)
                ) && 
                (
                    this.SoapNameSpace == other.SoapNameSpace ||
                    this.SoapNameSpace != null &&
                    this.SoapNameSpace.Equals(other.SoapNameSpace)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.UseSoapInterface == other.UseSoapInterface ||
                    this.UseSoapInterface != null &&
                    this.UseSoapInterface.Equals(other.UseSoapInterface)
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
                if (this.DeliveryMode != null)
                    hash = hash * 59 + this.DeliveryMode.GetHashCode();
                if (this.EnvelopeEvents != null)
                    hash = hash * 59 + this.EnvelopeEvents.GetHashCode();
                if (this.EventData != null)
                    hash = hash * 59 + this.EventData.GetHashCode();
                if (this.Events != null)
                    hash = hash * 59 + this.Events.GetHashCode();
                if (this.IncludeCertificateOfCompletion != null)
                    hash = hash * 59 + this.IncludeCertificateOfCompletion.GetHashCode();
                if (this.IncludeCertificateWithSoap != null)
                    hash = hash * 59 + this.IncludeCertificateWithSoap.GetHashCode();
                if (this.IncludeDocumentFields != null)
                    hash = hash * 59 + this.IncludeDocumentFields.GetHashCode();
                if (this.IncludeDocuments != null)
                    hash = hash * 59 + this.IncludeDocuments.GetHashCode();
                if (this.IncludeEnvelopeVoidReason != null)
                    hash = hash * 59 + this.IncludeEnvelopeVoidReason.GetHashCode();
                if (this.IncludeHMAC != null)
                    hash = hash * 59 + this.IncludeHMAC.GetHashCode();
                if (this.IncludeOAuth != null)
                    hash = hash * 59 + this.IncludeOAuth.GetHashCode();
                if (this.IncludeSenderAccountAsCustomField != null)
                    hash = hash * 59 + this.IncludeSenderAccountAsCustomField.GetHashCode();
                if (this.IncludeTimeZone != null)
                    hash = hash * 59 + this.IncludeTimeZone.GetHashCode();
                if (this.IntegratorManaged != null)
                    hash = hash * 59 + this.IntegratorManaged.GetHashCode();
                if (this.LoggingEnabled != null)
                    hash = hash * 59 + this.LoggingEnabled.GetHashCode();
                if (this.RecipientEvents != null)
                    hash = hash * 59 + this.RecipientEvents.GetHashCode();
                if (this.RequireAcknowledgment != null)
                    hash = hash * 59 + this.RequireAcknowledgment.GetHashCode();
                if (this.SignMessageWithX509Cert != null)
                    hash = hash * 59 + this.SignMessageWithX509Cert.GetHashCode();
                if (this.SoapNameSpace != null)
                    hash = hash * 59 + this.SoapNameSpace.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.UseSoapInterface != null)
                    hash = hash * 59 + this.UseSoapInterface.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
