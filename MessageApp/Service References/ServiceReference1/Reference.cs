﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MessageApp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveMessage", ReplyAction="http://tempuri.org/IService1/SaveMessageResponse")]
        void SaveMessage(string textInput, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SaveMessage", ReplyAction="http://tempuri.org/IService1/SaveMessageResponse")]
        System.Threading.Tasks.Task SaveMessageAsync(string textInput, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMessages", ReplyAction="http://tempuri.org/IService1/GetMessagesResponse")]
        MessageWCF.MessageModel[] GetMessages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetMessages", ReplyAction="http://tempuri.org/IService1/GetMessagesResponse")]
        System.Threading.Tasks.Task<MessageWCF.MessageModel[]> GetMessagesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : global::MessageApp.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<global::MessageApp.ServiceReference1.IService1>, global::MessageApp.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SaveMessage(string textInput, System.DateTime date) {
            base.Channel.SaveMessage(textInput, date);
        }
        
        public System.Threading.Tasks.Task SaveMessageAsync(string textInput, System.DateTime date) {
            return base.Channel.SaveMessageAsync(textInput, date);
        }
        
        public MessageWCF.MessageModel[] GetMessages() {
            return base.Channel.GetMessages();
        }
        
        public System.Threading.Tasks.Task<MessageWCF.MessageModel[]> GetMessagesAsync() {
            return base.Channel.GetMessagesAsync();
        }
    }
}
