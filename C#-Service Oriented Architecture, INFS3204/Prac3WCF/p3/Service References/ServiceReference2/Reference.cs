﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace p3.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Job", Namespace="http://schemas.datacontract.org/2004/07/p3")]
    [System.SerializableAttribute()]
    public partial class Job : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string companyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string positionDescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int positionNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string positionTitleField;
        
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
        public string companyName {
            get {
                return this.companyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.companyNameField, value) != true)) {
                    this.companyNameField = value;
                    this.RaisePropertyChanged("companyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string positionDescription {
            get {
                return this.positionDescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.positionDescriptionField, value) != true)) {
                    this.positionDescriptionField = value;
                    this.RaisePropertyChanged("positionDescription");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int positionNumber {
            get {
                return this.positionNumberField;
            }
            set {
                if ((this.positionNumberField.Equals(value) != true)) {
                    this.positionNumberField = value;
                    this.RaisePropertyChanged("positionNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string positionTitle {
            get {
                return this.positionTitleField;
            }
            set {
                if ((object.ReferenceEquals(this.positionTitleField, value) != true)) {
                    this.positionTitleField = value;
                    this.RaisePropertyChanged("positionTitle");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IService2")]
    public interface IService2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/SaveInfo", ReplyAction="http://tempuri.org/IService2/SaveInfoResponse")]
        bool SaveInfo(string firstName, string lastName, System.DateTime dateOfBirth, string email, string streetAddress, string suburb, string state, int postcode, p3.ServiceReference2.Job job);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/GetJobInfo", ReplyAction="http://tempuri.org/IService2/GetJobInfoResponse")]
        void GetJobInfo(string firstName, string lastName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService2/GetColleagues", ReplyAction="http://tempuri.org/IService2/GetColleaguesResponse")]
        void GetColleagues(string firstName, string lastName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService2Channel : p3.ServiceReference2.IService2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service2Client : System.ServiceModel.ClientBase<p3.ServiceReference2.IService2>, p3.ServiceReference2.IService2 {
        
        public Service2Client() {
        }
        
        public Service2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool SaveInfo(string firstName, string lastName, System.DateTime dateOfBirth, string email, string streetAddress, string suburb, string state, int postcode, p3.ServiceReference2.Job job) {
            return base.Channel.SaveInfo(firstName, lastName, dateOfBirth, email, streetAddress, suburb, state, postcode, job);
        }
        
        public void GetJobInfo(string firstName, string lastName) {
            base.Channel.GetJobInfo(firstName, lastName);
        }
        
        public void GetColleagues(string firstName, string lastName) {
            base.Channel.GetColleagues(firstName, lastName);
        }
    }
}
