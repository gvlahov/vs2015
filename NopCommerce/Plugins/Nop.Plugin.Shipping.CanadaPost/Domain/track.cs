﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5483
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.1432.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.canadapost.ca/ws/track")]
[System.Xml.Serialization.XmlRootAttribute("tracking-summary", Namespace="http://www.canadapost.ca/ws/track", IsNullable=false)]
public partial class trackingsummary {
    
    private pinsummary[] pinsummaryField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("pin-summary")]
    public pinsummary[] pinsummary {
        get {
            return this.pinsummaryField;
        }
        set {
            this.pinsummaryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="pin-summary", Namespace="http://www.canadapost.ca/ws/track")]
public partial class pinsummary {
    
    private string pinField;
    
    private string originpostalidField;
    
    private string destinationpostalidField;
    
    private string destinationprovinceField;
    
    private string servicenameField;
    
    private string mailedondateField;
    
    private string expecteddeliverydateField;
    
    private string actualdeliverydateField;
    
    private string deliveryoptioncompletedindField;
    
    private string eventdatetimeField;
    
    private string eventdescriptionField;
    
    private string attempteddateField;
    
    private string customerref1Field;
    
    private string customerref2Field;
    
    private string returnpinField;
    
    private string eventtypeField;
    
    private string eventlocationField;
    
    private string signatorynameField;
    
    /// <remarks/>
    public string pin {
        get {
            return this.pinField;
        }
        set {
            this.pinField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("origin-postal-id")]
    public string originpostalid {
        get {
            return this.originpostalidField;
        }
        set {
            this.originpostalidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("destination-postal-id")]
    public string destinationpostalid {
        get {
            return this.destinationpostalidField;
        }
        set {
            this.destinationpostalidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("destination-province")]
    public string destinationprovince {
        get {
            return this.destinationprovinceField;
        }
        set {
            this.destinationprovinceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("service-name")]
    public string servicename {
        get {
            return this.servicenameField;
        }
        set {
            this.servicenameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("mailed-on-date")]
    public string mailedondate {
        get {
            return this.mailedondateField;
        }
        set {
            this.mailedondateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("expected-delivery-date")]
    public string expecteddeliverydate {
        get {
            return this.expecteddeliverydateField;
        }
        set {
            this.expecteddeliverydateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("actual-delivery-date")]
    public string actualdeliverydate {
        get {
            return this.actualdeliverydateField;
        }
        set {
            this.actualdeliverydateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("delivery-option-completed-ind")]
    public string deliveryoptioncompletedind {
        get {
            return this.deliveryoptioncompletedindField;
        }
        set {
            this.deliveryoptioncompletedindField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("event-date-time")]
    public string eventdatetime {
        get {
            return this.eventdatetimeField;
        }
        set {
            this.eventdatetimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("event-description")]
    public string eventdescription {
        get {
            return this.eventdescriptionField;
        }
        set {
            this.eventdescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("attempted-date")]
    public string attempteddate {
        get {
            return this.attempteddateField;
        }
        set {
            this.attempteddateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("customer-ref-1")]
    public string customerref1 {
        get {
            return this.customerref1Field;
        }
        set {
            this.customerref1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("customer-ref-2")]
    public string customerref2 {
        get {
            return this.customerref2Field;
        }
        set {
            this.customerref2Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("return-pin")]
    public string returnpin {
        get {
            return this.returnpinField;
        }
        set {
            this.returnpinField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("event-type")]
    public string eventtype {
        get {
            return this.eventtypeField;
        }
        set {
            this.eventtypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("event-location")]
    public string eventlocation {
        get {
            return this.eventlocationField;
        }
        set {
            this.eventlocationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("signatory-name")]
    public string signatoryname {
        get {
            return this.signatorynameField;
        }
        set {
            this.signatorynameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="cod-remit-info", Namespace="http://www.canadapost.ca/ws/track")]
public partial class codremitinfo {
    
    private string pinField;
    
    private string typeField;
    
    /// <remarks/>
    public string pin {
        get {
            return this.pinField;
        }
        set {
            this.pinField = value;
        }
    }
    
    /// <remarks/>
    public string type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.canadapost.ca/ws/track")]
[System.Xml.Serialization.XmlRootAttribute("tracking-detail", Namespace="http://www.canadapost.ca/ws/track", IsNullable=false)]
public partial class trackingdetail {
    
    private string pinField;
    
    private string activeexistsField;
    
    private string archiveexistsField;
    
    private string changedexpecteddateField;
    
    private string destinationpostalidField;
    
    private string expecteddeliverydateField;
    
    private string changedexpecteddeliveryreasonField;
    
    private string mailedbycustomernumberField;
    
    private string mailedonbehalfofcustomernumberField;
    
    private string originalpinField;
    
    private string servicenameField;
    
    private string servicename2Field;
    
    private string customerref1Field;
    
    private string customerref2Field;
    
    private string returnpinField;
    
    private string signatureimageexistsField;
    
    private string suppresssignatureField;
    
    private deliveryoptionsItem[] deliveryoptionsField;
    
    private codremitinfo codremitinfoField;
    
    private significanteventsOccurrence[] significanteventsField;
    
    /// <remarks/>
    public string pin {
        get {
            return this.pinField;
        }
        set {
            this.pinField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("active-exists")]
    public string activeexists {
        get {
            return this.activeexistsField;
        }
        set {
            this.activeexistsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("archive-exists")]
    public string archiveexists {
        get {
            return this.archiveexistsField;
        }
        set {
            this.archiveexistsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("changed-expected-date")]
    public string changedexpecteddate {
        get {
            return this.changedexpecteddateField;
        }
        set {
            this.changedexpecteddateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("destination-postal-id")]
    public string destinationpostalid {
        get {
            return this.destinationpostalidField;
        }
        set {
            this.destinationpostalidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("expected-delivery-date")]
    public string expecteddeliverydate {
        get {
            return this.expecteddeliverydateField;
        }
        set {
            this.expecteddeliverydateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("changed-expected-delivery-reason")]
    public string changedexpecteddeliveryreason {
        get {
            return this.changedexpecteddeliveryreasonField;
        }
        set {
            this.changedexpecteddeliveryreasonField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("mailed-by-customer-number")]
    public string mailedbycustomernumber {
        get {
            return this.mailedbycustomernumberField;
        }
        set {
            this.mailedbycustomernumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("mailed-on-behalf-of-customer-number")]
    public string mailedonbehalfofcustomernumber {
        get {
            return this.mailedonbehalfofcustomernumberField;
        }
        set {
            this.mailedonbehalfofcustomernumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("original-pin")]
    public string originalpin {
        get {
            return this.originalpinField;
        }
        set {
            this.originalpinField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("service-name")]
    public string servicename {
        get {
            return this.servicenameField;
        }
        set {
            this.servicenameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("service-name-2")]
    public string servicename2 {
        get {
            return this.servicename2Field;
        }
        set {
            this.servicename2Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("customer-ref-1")]
    public string customerref1 {
        get {
            return this.customerref1Field;
        }
        set {
            this.customerref1Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("customer-ref-2")]
    public string customerref2 {
        get {
            return this.customerref2Field;
        }
        set {
            this.customerref2Field = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("return-pin")]
    public string returnpin {
        get {
            return this.returnpinField;
        }
        set {
            this.returnpinField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("signature-image-exists")]
    public string signatureimageexists {
        get {
            return this.signatureimageexistsField;
        }
        set {
            this.signatureimageexistsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("suppress-signature")]
    public string suppresssignature {
        get {
            return this.suppresssignatureField;
        }
        set {
            this.suppresssignatureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute("delivery-options")]
    [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
    public deliveryoptionsItem[] deliveryoptions {
        get {
            return this.deliveryoptionsField;
        }
        set {
            this.deliveryoptionsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("cod-remit-info")]
    public codremitinfo codremitinfo {
        get {
            return this.codremitinfoField;
        }
        set {
            this.codremitinfoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute("significant-events")]
    [System.Xml.Serialization.XmlArrayItemAttribute("occurrence", IsNullable=false)]
    public significanteventsOccurrence[] significantevents {
        get {
            return this.significanteventsField;
        }
        set {
            this.significanteventsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.canadapost.ca/ws/track")]
public partial class deliveryoptionsItem {
    
    private string deliveryoptionField;
    
    private string deliveryoptiondescriptionField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("delivery-option")]
    public string deliveryoption {
        get {
            return this.deliveryoptionField;
        }
        set {
            this.deliveryoptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("delivery-option-description")]
    public string deliveryoptiondescription {
        get {
            return this.deliveryoptiondescriptionField;
        }
        set {
            this.deliveryoptiondescriptionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.canadapost.ca/ws/track")]
public partial class significanteventsOccurrence {
    
    private string eventidentifierField;
    
    private string eventdateField;
    
    private string eventtimeField;
    
    private string eventtimezoneField;
    
    private string eventdescriptionField;
    
    private string signatorynameField;
    
    private string eventsiteField;
    
    private string eventprovinceField;
    
    private string eventretaillocationidField;
    
    private string eventretailnameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("event-identifier")]
    public string eventidentifier {
        get {
            return this.eventidentifierField;
        }
        set {
            this.eventidentifierField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("event-date")]
    public string eventdate {
        get {
            return this.eventdateField;
        }
        set {
            this.eventdateField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("event-time")]
    public string eventtime {
        get {
            return this.eventtimeField;
        }
        set {
            this.eventtimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("event-time-zone")]
    public string eventtimezone {
        get {
            return this.eventtimezoneField;
        }
        set {
            this.eventtimezoneField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("event-description")]
    public string eventdescription {
        get {
            return this.eventdescriptionField;
        }
        set {
            this.eventdescriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("signatory-name")]
    public string signatoryname {
        get {
            return this.signatorynameField;
        }
        set {
            this.signatorynameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("event-site")]
    public string eventsite {
        get {
            return this.eventsiteField;
        }
        set {
            this.eventsiteField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("event-province")]
    public string eventprovince {
        get {
            return this.eventprovinceField;
        }
        set {
            this.eventprovinceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("event-retail-location-id")]
    public string eventretaillocationid {
        get {
            return this.eventretaillocationidField;
        }
        set {
            this.eventretaillocationidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("event-retail-name")]
    public string eventretailname {
        get {
            return this.eventretailnameField;
        }
        set {
            this.eventretailnameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.canadapost.ca/ws/track")]
[System.Xml.Serialization.XmlRootAttribute("signature-image", Namespace="http://www.canadapost.ca/ws/track", IsNullable=false)]
public partial class signatureimage {
    
    private string filenameField;
    
    private string imageField;
    
    private string mimetypeField;
    
    /// <remarks/>
    public string filename {
        get {
            return this.filenameField;
        }
        set {
            this.filenameField = value;
        }
    }
    
    /// <remarks/>
    public string image {
        get {
            return this.imageField;
        }
        set {
            this.imageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("mime-type")]
    public string mimetype {
        get {
            return this.mimetypeField;
        }
        set {
            this.mimetypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.canadapost.ca/ws/track")]
[System.Xml.Serialization.XmlRootAttribute("delivery-confirmation-certificate", Namespace="http://www.canadapost.ca/ws/track", IsNullable=false)]
public partial class deliveryconfirmationcertificate {
    
    private string filenameField;
    
    private string imageField;
    
    private string mimetypeField;
    
    /// <remarks/>
    public string filename {
        get {
            return this.filenameField;
        }
        set {
            this.filenameField = value;
        }
    }
    
    /// <remarks/>
    public string image {
        get {
            return this.imageField;
        }
        set {
            this.imageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("mime-type")]
    public string mimetype {
        get {
            return this.mimetypeField;
        }
        set {
            this.mimetypeField = value;
        }
    }
}
