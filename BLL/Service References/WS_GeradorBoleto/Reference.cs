﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLL.WS_GeradorBoleto {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WS_GeradorBoleto.BoletoServiceSoap")]
    public interface BoletoServiceSoap {
        
        // CODEGEN: Generating message contract since element name appInfo from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GerarBoleto", ReplyAction="*")]
        BLL.WS_GeradorBoleto.GerarBoletoResponse GerarBoleto(BLL.WS_GeradorBoleto.GerarBoletoRequest request);
        
        // CODEGEN: Generating message contract since element name appInfo from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GerarBoletoPontualidade", ReplyAction="*")]
        BLL.WS_GeradorBoleto.GerarBoletoPontualidadeResponse GerarBoletoPontualidade(BLL.WS_GeradorBoleto.GerarBoletoPontualidadeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GerarBoletoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GerarBoleto", Namespace="http://tempuri.org/", Order=0)]
        public BLL.WS_GeradorBoleto.GerarBoletoRequestBody Body;
        
        public GerarBoletoRequest() {
        }
        
        public GerarBoletoRequest(BLL.WS_GeradorBoleto.GerarBoletoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GerarBoletoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public BLL.WS_GeradorBoleto.ArrayOfString appInfo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public BLL.WS_GeradorBoleto.ArrayOfString sacadoInfo;
        
        public GerarBoletoRequestBody() {
        }
        
        public GerarBoletoRequestBody(BLL.WS_GeradorBoleto.ArrayOfString appInfo, BLL.WS_GeradorBoleto.ArrayOfString sacadoInfo) {
            this.appInfo = appInfo;
            this.sacadoInfo = sacadoInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GerarBoletoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GerarBoletoResponse", Namespace="http://tempuri.org/", Order=0)]
        public BLL.WS_GeradorBoleto.GerarBoletoResponseBody Body;
        
        public GerarBoletoResponse() {
        }
        
        public GerarBoletoResponse(BLL.WS_GeradorBoleto.GerarBoletoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GerarBoletoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GerarBoletoResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public bool jaImprimiu;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public bool foraDaData;
        
        public GerarBoletoResponseBody() {
        }
        
        public GerarBoletoResponseBody(string GerarBoletoResult, bool jaImprimiu, bool foraDaData) {
            this.GerarBoletoResult = GerarBoletoResult;
            this.jaImprimiu = jaImprimiu;
            this.foraDaData = foraDaData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GerarBoletoPontualidadeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GerarBoletoPontualidade", Namespace="http://tempuri.org/", Order=0)]
        public BLL.WS_GeradorBoleto.GerarBoletoPontualidadeRequestBody Body;
        
        public GerarBoletoPontualidadeRequest() {
        }
        
        public GerarBoletoPontualidadeRequest(BLL.WS_GeradorBoleto.GerarBoletoPontualidadeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GerarBoletoPontualidadeRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public BLL.WS_GeradorBoleto.ArrayOfString appInfo;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public BLL.WS_GeradorBoleto.ArrayOfString sacadoInfo;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int diasAntecipacao;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public decimal valorDescontoPontualidade;
        
        public GerarBoletoPontualidadeRequestBody() {
        }
        
        public GerarBoletoPontualidadeRequestBody(BLL.WS_GeradorBoleto.ArrayOfString appInfo, BLL.WS_GeradorBoleto.ArrayOfString sacadoInfo, int diasAntecipacao, decimal valorDescontoPontualidade) {
            this.appInfo = appInfo;
            this.sacadoInfo = sacadoInfo;
            this.diasAntecipacao = diasAntecipacao;
            this.valorDescontoPontualidade = valorDescontoPontualidade;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GerarBoletoPontualidadeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GerarBoletoPontualidadeResponse", Namespace="http://tempuri.org/", Order=0)]
        public BLL.WS_GeradorBoleto.GerarBoletoPontualidadeResponseBody Body;
        
        public GerarBoletoPontualidadeResponse() {
        }
        
        public GerarBoletoPontualidadeResponse(BLL.WS_GeradorBoleto.GerarBoletoPontualidadeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GerarBoletoPontualidadeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GerarBoletoPontualidadeResult;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public bool jaImprimiu;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public bool foraDaData;
        
        public GerarBoletoPontualidadeResponseBody() {
        }
        
        public GerarBoletoPontualidadeResponseBody(string GerarBoletoPontualidadeResult, bool jaImprimiu, bool foraDaData) {
            this.GerarBoletoPontualidadeResult = GerarBoletoPontualidadeResult;
            this.jaImprimiu = jaImprimiu;
            this.foraDaData = foraDaData;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BoletoServiceSoapChannel : BLL.WS_GeradorBoleto.BoletoServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BoletoServiceSoapClient : System.ServiceModel.ClientBase<BLL.WS_GeradorBoleto.BoletoServiceSoap>, BLL.WS_GeradorBoleto.BoletoServiceSoap {
        
        public BoletoServiceSoapClient() {
        }
        
        public BoletoServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BoletoServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BoletoServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BoletoServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BLL.WS_GeradorBoleto.GerarBoletoResponse BLL.WS_GeradorBoleto.BoletoServiceSoap.GerarBoleto(BLL.WS_GeradorBoleto.GerarBoletoRequest request) {
            return base.Channel.GerarBoleto(request);
        }
        
        public string GerarBoleto(BLL.WS_GeradorBoleto.ArrayOfString appInfo, BLL.WS_GeradorBoleto.ArrayOfString sacadoInfo, out bool jaImprimiu, out bool foraDaData) {
            BLL.WS_GeradorBoleto.GerarBoletoRequest inValue = new BLL.WS_GeradorBoleto.GerarBoletoRequest();
            inValue.Body = new BLL.WS_GeradorBoleto.GerarBoletoRequestBody();
            inValue.Body.appInfo = appInfo;
            inValue.Body.sacadoInfo = sacadoInfo;
            BLL.WS_GeradorBoleto.GerarBoletoResponse retVal = ((BLL.WS_GeradorBoleto.BoletoServiceSoap)(this)).GerarBoleto(inValue);
            jaImprimiu = retVal.Body.jaImprimiu;
            foraDaData = retVal.Body.foraDaData;
            return retVal.Body.GerarBoletoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BLL.WS_GeradorBoleto.GerarBoletoPontualidadeResponse BLL.WS_GeradorBoleto.BoletoServiceSoap.GerarBoletoPontualidade(BLL.WS_GeradorBoleto.GerarBoletoPontualidadeRequest request) {
            return base.Channel.GerarBoletoPontualidade(request);
        }
        
        public string GerarBoletoPontualidade(BLL.WS_GeradorBoleto.ArrayOfString appInfo, BLL.WS_GeradorBoleto.ArrayOfString sacadoInfo, int diasAntecipacao, decimal valorDescontoPontualidade, out bool jaImprimiu, out bool foraDaData) {
            BLL.WS_GeradorBoleto.GerarBoletoPontualidadeRequest inValue = new BLL.WS_GeradorBoleto.GerarBoletoPontualidadeRequest();
            inValue.Body = new BLL.WS_GeradorBoleto.GerarBoletoPontualidadeRequestBody();
            inValue.Body.appInfo = appInfo;
            inValue.Body.sacadoInfo = sacadoInfo;
            inValue.Body.diasAntecipacao = diasAntecipacao;
            inValue.Body.valorDescontoPontualidade = valorDescontoPontualidade;
            BLL.WS_GeradorBoleto.GerarBoletoPontualidadeResponse retVal = ((BLL.WS_GeradorBoleto.BoletoServiceSoap)(this)).GerarBoletoPontualidade(inValue);
            jaImprimiu = retVal.Body.jaImprimiu;
            foraDaData = retVal.Body.foraDaData;
            return retVal.Body.GerarBoletoPontualidadeResult;
        }
    }
}
