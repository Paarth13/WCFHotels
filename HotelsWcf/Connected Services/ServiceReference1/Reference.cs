﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelsWcf.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HotelDemo", Namespace="http://schemas.datacontract.org/2004/07/WcfHotels")]
    [System.SerializableAttribute()]
    public partial class HotelDemo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RatingsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Ratings {
            get {
                return this.RatingsField;
            }
            set {
                if ((object.ReferenceEquals(this.RatingsField, value) != true)) {
                    this.RatingsField = value;
                    this.RaisePropertyChanged("Ratings");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IHotels")]
    public interface IHotels {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotels/GetAllHotels", ReplyAction="http://tempuri.org/IHotels/GetAllHotelsResponse")]
        HotelsWcf.ServiceReference1.HotelDemo[] GetAllHotels();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotels/GetAllHotels", ReplyAction="http://tempuri.org/IHotels/GetAllHotelsResponse")]
        System.Threading.Tasks.Task<HotelsWcf.ServiceReference1.HotelDemo[]> GetAllHotelsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotels/GetById", ReplyAction="http://tempuri.org/IHotels/GetByIdResponse")]
        HotelsWcf.ServiceReference1.HotelDemo GetById(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotels/GetById", ReplyAction="http://tempuri.org/IHotels/GetByIdResponse")]
        System.Threading.Tasks.Task<HotelsWcf.ServiceReference1.HotelDemo> GetByIdAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHotelsChannel : HotelsWcf.ServiceReference1.IHotels, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HotelsClient : System.ServiceModel.ClientBase<HotelsWcf.ServiceReference1.IHotels>, HotelsWcf.ServiceReference1.IHotels {
        
        public HotelsClient() {
        }
        
        public HotelsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HotelsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HotelsWcf.ServiceReference1.HotelDemo[] GetAllHotels() {
            return base.Channel.GetAllHotels();
        }
        
        public System.Threading.Tasks.Task<HotelsWcf.ServiceReference1.HotelDemo[]> GetAllHotelsAsync() {
            return base.Channel.GetAllHotelsAsync();
        }
        
        public HotelsWcf.ServiceReference1.HotelDemo GetById(string id) {
            return base.Channel.GetById(id);
        }
        
        public System.Threading.Tasks.Task<HotelsWcf.ServiceReference1.HotelDemo> GetByIdAsync(string id) {
            return base.Channel.GetByIdAsync(id);
        }
    }
}
