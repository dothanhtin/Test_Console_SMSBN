﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestConsole.NewSophos_Ws {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NewSophos_Ws.SendMT2Soap")]
    public interface SendMT2Soap {
        
        // CODEGEN: Generating message contract since element name account_name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMS", ReplyAction="*")]
        TestConsole.NewSophos_Ws.SendSMSResponse SendSMS(TestConsole.NewSophos_Ws.SendSMSRequest request);
        
        // CODEGEN: Generating message contract since element name account_name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMSAdvert", ReplyAction="*")]
        TestConsole.NewSophos_Ws.SendSMSAdvertResponse SendSMSAdvert(TestConsole.NewSophos_Ws.SendSMSAdvertRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSMSRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSMS", Namespace="http://tempuri.org/", Order=0)]
        public TestConsole.NewSophos_Ws.SendSMSRequestBody Body;
        
        public SendSMSRequest() {
        }
        
        public SendSMSRequest(TestConsole.NewSophos_Ws.SendSMSRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSMSRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string account_name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string account_password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string User_ID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Content;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Service_ID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string Command_Code;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string Request_ID;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Message_Type;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string Total_Message;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string Message_Index;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string IsMore;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=11)]
        public string Content_Type;
        
        public SendSMSRequestBody() {
        }
        
        public SendSMSRequestBody(string account_name, string account_password, string User_ID, string Content, string Service_ID, string Command_Code, string Request_ID, string Message_Type, string Total_Message, string Message_Index, string IsMore, string Content_Type) {
            this.account_name = account_name;
            this.account_password = account_password;
            this.User_ID = User_ID;
            this.Content = Content;
            this.Service_ID = Service_ID;
            this.Command_Code = Command_Code;
            this.Request_ID = Request_ID;
            this.Message_Type = Message_Type;
            this.Total_Message = Total_Message;
            this.Message_Index = Message_Index;
            this.IsMore = IsMore;
            this.Content_Type = Content_Type;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSMSResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSMSResponse", Namespace="http://tempuri.org/", Order=0)]
        public TestConsole.NewSophos_Ws.SendSMSResponseBody Body;
        
        public SendSMSResponse() {
        }
        
        public SendSMSResponse(TestConsole.NewSophos_Ws.SendSMSResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSMSResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public long SendSMSResult;
        
        public SendSMSResponseBody() {
        }
        
        public SendSMSResponseBody(long SendSMSResult) {
            this.SendSMSResult = SendSMSResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSMSAdvertRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSMSAdvert", Namespace="http://tempuri.org/", Order=0)]
        public TestConsole.NewSophos_Ws.SendSMSAdvertRequestBody Body;
        
        public SendSMSAdvertRequest() {
        }
        
        public SendSMSAdvertRequest(TestConsole.NewSophos_Ws.SendSMSAdvertRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSMSAdvertRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string account_name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string account_password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Phonenumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Message;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string SendFrom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string CommandCode;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string RequestID;
        
        public SendSMSAdvertRequestBody() {
        }
        
        public SendSMSAdvertRequestBody(string account_name, string account_password, string Phonenumber, string Message, string SendFrom, string CommandCode, string RequestID) {
            this.account_name = account_name;
            this.account_password = account_password;
            this.Phonenumber = Phonenumber;
            this.Message = Message;
            this.SendFrom = SendFrom;
            this.CommandCode = CommandCode;
            this.RequestID = RequestID;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSMSAdvertResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSMSAdvertResponse", Namespace="http://tempuri.org/", Order=0)]
        public TestConsole.NewSophos_Ws.SendSMSAdvertResponseBody Body;
        
        public SendSMSAdvertResponse() {
        }
        
        public SendSMSAdvertResponse(TestConsole.NewSophos_Ws.SendSMSAdvertResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSMSAdvertResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int SendSMSAdvertResult;
        
        public SendSMSAdvertResponseBody() {
        }
        
        public SendSMSAdvertResponseBody(int SendSMSAdvertResult) {
            this.SendSMSAdvertResult = SendSMSAdvertResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SendMT2SoapChannel : TestConsole.NewSophos_Ws.SendMT2Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SendMT2SoapClient : System.ServiceModel.ClientBase<TestConsole.NewSophos_Ws.SendMT2Soap>, TestConsole.NewSophos_Ws.SendMT2Soap {
        
        public SendMT2SoapClient() {
        }
        
        public SendMT2SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SendMT2SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SendMT2SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SendMT2SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestConsole.NewSophos_Ws.SendSMSResponse TestConsole.NewSophos_Ws.SendMT2Soap.SendSMS(TestConsole.NewSophos_Ws.SendSMSRequest request) {
            return base.Channel.SendSMS(request);
        }
        
        public long SendSMS(string account_name, string account_password, string User_ID, string Content, string Service_ID, string Command_Code, string Request_ID, string Message_Type, string Total_Message, string Message_Index, string IsMore, string Content_Type) {
            TestConsole.NewSophos_Ws.SendSMSRequest inValue = new TestConsole.NewSophos_Ws.SendSMSRequest();
            inValue.Body = new TestConsole.NewSophos_Ws.SendSMSRequestBody();
            inValue.Body.account_name = account_name;
            inValue.Body.account_password = account_password;
            inValue.Body.User_ID = User_ID;
            inValue.Body.Content = Content;
            inValue.Body.Service_ID = Service_ID;
            inValue.Body.Command_Code = Command_Code;
            inValue.Body.Request_ID = Request_ID;
            inValue.Body.Message_Type = Message_Type;
            inValue.Body.Total_Message = Total_Message;
            inValue.Body.Message_Index = Message_Index;
            inValue.Body.IsMore = IsMore;
            inValue.Body.Content_Type = Content_Type;
            TestConsole.NewSophos_Ws.SendSMSResponse retVal = ((TestConsole.NewSophos_Ws.SendMT2Soap)(this)).SendSMS(inValue);
            return retVal.Body.SendSMSResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        TestConsole.NewSophos_Ws.SendSMSAdvertResponse TestConsole.NewSophos_Ws.SendMT2Soap.SendSMSAdvert(TestConsole.NewSophos_Ws.SendSMSAdvertRequest request) {
            return base.Channel.SendSMSAdvert(request);
        }
        
        public int SendSMSAdvert(string account_name, string account_password, string Phonenumber, string Message, string SendFrom, string CommandCode, string RequestID) {
            TestConsole.NewSophos_Ws.SendSMSAdvertRequest inValue = new TestConsole.NewSophos_Ws.SendSMSAdvertRequest();
            inValue.Body = new TestConsole.NewSophos_Ws.SendSMSAdvertRequestBody();
            inValue.Body.account_name = account_name;
            inValue.Body.account_password = account_password;
            inValue.Body.Phonenumber = Phonenumber;
            inValue.Body.Message = Message;
            inValue.Body.SendFrom = SendFrom;
            inValue.Body.CommandCode = CommandCode;
            inValue.Body.RequestID = RequestID;
            TestConsole.NewSophos_Ws.SendSMSAdvertResponse retVal = ((TestConsole.NewSophos_Ws.SendMT2Soap)(this)).SendSMSAdvert(inValue);
            return retVal.Body.SendSMSAdvertResult;
        }
    }
}
