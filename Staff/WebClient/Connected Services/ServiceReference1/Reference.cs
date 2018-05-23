﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetShortInfo", Namespace="http://schemas.datacontract.org/2004/07/HostService")]
    [System.SerializableAttribute()]
    public partial struct GetShortInfo : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime BirthdayField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string First_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Last_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Patronic_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Birthday {
            get {
                return this.BirthdayField;
            }
            set {
                if ((this.BirthdayField.Equals(value) != true)) {
                    this.BirthdayField = value;
                    this.RaisePropertyChanged("Birthday");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Department {
            get {
                return this.DepartmentField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentField, value) != true)) {
                    this.DepartmentField = value;
                    this.RaisePropertyChanged("Department");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string First_name {
            get {
                return this.First_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.First_nameField, value) != true)) {
                    this.First_nameField = value;
                    this.RaisePropertyChanged("First_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Last_name {
            get {
                return this.Last_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.Last_nameField, value) != true)) {
                    this.Last_nameField = value;
                    this.RaisePropertyChanged("Last_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Patronic_name {
            get {
                return this.Patronic_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.Patronic_nameField, value) != true)) {
                    this.Patronic_nameField = value;
                    this.RaisePropertyChanged("Patronic_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Post {
            get {
                return this.PostField;
            }
            set {
                if ((object.ReferenceEquals(this.PostField, value) != true)) {
                    this.PostField = value;
                    this.RaisePropertyChanged("Post");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IHostService1")]
    public interface IHostService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHostService1/Summator", ReplyAction="http://tempuri.org/IHostService1/SummatorResponse")]
        int Summator(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHostService1/Summator", ReplyAction="http://tempuri.org/IHostService1/SummatorResponse")]
        System.Threading.Tasks.Task<int> SummatorAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHostService1/GetRowById", ReplyAction="http://tempuri.org/IHostService1/GetRowByIdResponse")]
        WebClient.ServiceReference1.GetShortInfo GetRowById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHostService1/GetRowById", ReplyAction="http://tempuri.org/IHostService1/GetRowByIdResponse")]
        System.Threading.Tasks.Task<WebClient.ServiceReference1.GetShortInfo> GetRowByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHostService1Channel : WebClient.ServiceReference1.IHostService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HostService1Client : System.ServiceModel.ClientBase<WebClient.ServiceReference1.IHostService1>, WebClient.ServiceReference1.IHostService1 {
        
        public HostService1Client() {
        }
        
        public HostService1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HostService1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HostService1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HostService1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Summator(int a, int b) {
            return base.Channel.Summator(a, b);
        }
        
        public System.Threading.Tasks.Task<int> SummatorAsync(int a, int b) {
            return base.Channel.SummatorAsync(a, b);
        }
        
        public WebClient.ServiceReference1.GetShortInfo GetRowById(int id) {
            return base.Channel.GetRowById(id);
        }
        
        public System.Threading.Tasks.Task<WebClient.ServiceReference1.GetShortInfo> GetRowByIdAsync(int id) {
            return base.Channel.GetRowByIdAsync(id);
        }
    }
}
