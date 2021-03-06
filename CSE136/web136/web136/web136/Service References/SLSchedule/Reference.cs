﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18047
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace web136.SLSchedule {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Schedule", Namespace="http://schemas.datacontract.org/2004/07/POCO")]
    [System.SerializableAttribute()]
    public partial class Schedule : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private web136.SLSchedule.Course courseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string quarterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string sessionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string yearField;
        
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
        public web136.SLSchedule.Course course {
            get {
                return this.courseField;
            }
            set {
                if ((object.ReferenceEquals(this.courseField, value) != true)) {
                    this.courseField = value;
                    this.RaisePropertyChanged("course");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string quarter {
            get {
                return this.quarterField;
            }
            set {
                if ((object.ReferenceEquals(this.quarterField, value) != true)) {
                    this.quarterField = value;
                    this.RaisePropertyChanged("quarter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string session {
            get {
                return this.sessionField;
            }
            set {
                if ((object.ReferenceEquals(this.sessionField, value) != true)) {
                    this.sessionField = value;
                    this.RaisePropertyChanged("session");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string year {
            get {
                return this.yearField;
            }
            set {
                if ((object.ReferenceEquals(this.yearField, value) != true)) {
                    this.yearField = value;
                    this.RaisePropertyChanged("year");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Course", Namespace="http://schemas.datacontract.org/2004/07/POCO")]
    [System.SerializableAttribute()]
    public partial class Course : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string titleField;
        
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
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                if ((object.ReferenceEquals(this.idField, value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string title {
            get {
                return this.titleField;
            }
            set {
                if ((object.ReferenceEquals(this.titleField, value) != true)) {
                    this.titleField = value;
                    this.RaisePropertyChanged("title");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SLSchedule.ISLSchedule")]
    public interface ISLSchedule {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISLSchedule/GetScheduleList", ReplyAction="http://tempuri.org/ISLSchedule/GetScheduleListResponse")]
        web136.SLSchedule.GetScheduleListResponse GetScheduleList(web136.SLSchedule.GetScheduleListRequest request);
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISLSchedule/GetScheduleList", ReplyAction="http://tempuri.org/ISLSchedule/GetScheduleListResponse")]
        System.Threading.Tasks.Task<web136.SLSchedule.GetScheduleListResponse> GetScheduleListAsync(web136.SLSchedule.GetScheduleListRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetScheduleList", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetScheduleListRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string year;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string quarter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string[] errors;
        
        public GetScheduleListRequest() {
        }
        
        public GetScheduleListRequest(string year, string quarter, string[] errors) {
            this.year = year;
            this.quarter = quarter;
            this.errors = errors;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetScheduleListResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GetScheduleListResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public web136.SLSchedule.Schedule[] GetScheduleListResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string[] errors;
        
        public GetScheduleListResponse() {
        }
        
        public GetScheduleListResponse(web136.SLSchedule.Schedule[] GetScheduleListResult, string[] errors) {
            this.GetScheduleListResult = GetScheduleListResult;
            this.errors = errors;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISLScheduleChannel : web136.SLSchedule.ISLSchedule, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SLScheduleClient : System.ServiceModel.ClientBase<web136.SLSchedule.ISLSchedule>, web136.SLSchedule.ISLSchedule {
        
        public SLScheduleClient() {
        }
        
        public SLScheduleClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SLScheduleClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SLScheduleClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SLScheduleClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        web136.SLSchedule.GetScheduleListResponse web136.SLSchedule.ISLSchedule.GetScheduleList(web136.SLSchedule.GetScheduleListRequest request) {
            return base.Channel.GetScheduleList(request);
        }
        
        public web136.SLSchedule.Schedule[] GetScheduleList(string year, string quarter, ref string[] errors) {
            web136.SLSchedule.GetScheduleListRequest inValue = new web136.SLSchedule.GetScheduleListRequest();
            inValue.year = year;
            inValue.quarter = quarter;
            inValue.errors = errors;
            web136.SLSchedule.GetScheduleListResponse retVal = ((web136.SLSchedule.ISLSchedule)(this)).GetScheduleList(inValue);
            errors = retVal.errors;
            return retVal.GetScheduleListResult;
        }
        
        public System.Threading.Tasks.Task<web136.SLSchedule.GetScheduleListResponse> GetScheduleListAsync(web136.SLSchedule.GetScheduleListRequest request) {
            return base.Channel.GetScheduleListAsync(request);
        }
    }
}
