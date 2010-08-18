﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.net/OrderService.Messages")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.net/OrderService.Messages", IsNullable=true)]
public partial class OrderStatusChangedMessage {
    
    private string purchaseOrderNumberField;
    
    private System.Guid partnerIdField;
    
    private OrderStatusEnum statusField;
    
    private object[] orderLinesField;
    
    /// <remarks/>
    public string PurchaseOrderNumber {
        get {
            return this.purchaseOrderNumberField;
        }
        set {
            this.purchaseOrderNumberField = value;
        }
    }
    
    /// <remarks/>
    public System.Guid PartnerId {
        get {
            return this.partnerIdField;
        }
        set {
            this.partnerIdField = value;
        }
    }
    
    /// <remarks/>
    public OrderStatusEnum Status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("OrderLine")]
    public object[] OrderLines {
        get {
            return this.orderLinesField;
        }
        set {
            this.orderLinesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.net/OrderService.Messages")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.net/OrderService.Messages", IsNullable=false)]
public enum OrderStatusEnum {
    
    /// <remarks/>
    Tentative,
    
    /// <remarks/>
    Recieved,
    
    /// <remarks/>
    Authorized,
    
    /// <remarks/>
    Rejected,
    
    /// <remarks/>
    Accepted,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.net/OrderService.Messages")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.net/OrderService.Messages", IsNullable=true)]
public partial class OrderMessage {
    
    private bool doneField;
    
    private System.DateTime provideByField;
    
    private object[] orderLinesField;
    
    private string purchaseOrderNumberField;
    
    private System.Guid partnerIdField;
    
    /// <remarks/>
    public bool Done {
        get {
            return this.doneField;
        }
        set {
            this.doneField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime ProvideBy {
        get {
            return this.provideByField;
        }
        set {
            this.provideByField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("OrderLine")]
    public object[] OrderLines {
        get {
            return this.orderLinesField;
        }
        set {
            this.orderLinesField = value;
        }
    }
    
    /// <remarks/>
    public string PurchaseOrderNumber {
        get {
            return this.purchaseOrderNumberField;
        }
        set {
            this.purchaseOrderNumberField = value;
        }
    }
    
    /// <remarks/>
    public System.Guid PartnerId {
        get {
            return this.partnerIdField;
        }
        set {
            this.partnerIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="ArrayOfOrderLine", Namespace="http://tempuri.net/OrderService.Messages")]
[System.Xml.Serialization.XmlRootAttribute("ArrayOfOrderLine", Namespace="http://tempuri.net/OrderService.Messages", IsNullable=true)]
public partial class ArrayOfOrderLine1 {
    
    private object[] orderLineField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("OrderLine", IsNullable=true)]
    public object[] OrderLine {
        get {
            return this.orderLineField;
        }
        set {
            this.orderLineField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.net/OrderService.Messages")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.net/OrderService.Messages", IsNullable=true)]
public partial class OrderLine {
    
    private System.Guid productIdField;
    
    private float quantityField;
    
    /// <remarks/>
    public System.Guid ProductId {
        get {
            return this.productIdField;
        }
        set {
            this.productIdField = value;
        }
    }
    
    /// <remarks/>
    public float Quantity {
        get {
            return this.quantityField;
        }
        set {
            this.quantityField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.net/OrderService.Messages")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.net/OrderService.Messages", IsNullable=true)]
public partial class CancelOrderMessage {
    
    private string purchaseOrderNumberField;
    
    private System.Guid partnerIdField;
    
    /// <remarks/>
    public string PurchaseOrderNumber {
        get {
            return this.purchaseOrderNumberField;
        }
        set {
            this.purchaseOrderNumberField = value;
        }
    }
    
    /// <remarks/>
    public System.Guid PartnerId {
        get {
            return this.partnerIdField;
        }
        set {
            this.partnerIdField = value;
        }
    }
}
