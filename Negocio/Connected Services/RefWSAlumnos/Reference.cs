﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Negocio.RefWSAlumnos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AportacionesIMSS", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class AportacionesIMSS : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private decimal enfermedadMaternidadField;
        
        private decimal invalidezVidaField;
        
        private decimal retiroField;
        
        private decimal cesantiaField;
        
        private decimal infonavitField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal enfermedadMaternidad {
            get {
                return this.enfermedadMaternidadField;
            }
            set {
                if ((this.enfermedadMaternidadField.Equals(value) != true)) {
                    this.enfermedadMaternidadField = value;
                    this.RaisePropertyChanged("enfermedadMaternidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal invalidezVida {
            get {
                return this.invalidezVidaField;
            }
            set {
                if ((this.invalidezVidaField.Equals(value) != true)) {
                    this.invalidezVidaField = value;
                    this.RaisePropertyChanged("invalidezVida");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal retiro {
            get {
                return this.retiroField;
            }
            set {
                if ((this.retiroField.Equals(value) != true)) {
                    this.retiroField = value;
                    this.RaisePropertyChanged("retiro");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public decimal cesantia {
            get {
                return this.cesantiaField;
            }
            set {
                if ((this.cesantiaField.Equals(value) != true)) {
                    this.cesantiaField = value;
                    this.RaisePropertyChanged("cesantia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public decimal infonavit {
            get {
                return this.infonavitField;
            }
            set {
                if ((this.infonavitField.Equals(value) != true)) {
                    this.infonavitField = value;
                    this.RaisePropertyChanged("infonavit");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ItemTablaISR", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ItemTablaISR : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private decimal limiteInferiorField;
        
        private decimal limiteSuperiorField;
        
        private decimal cuotaFijaField;
        
        private decimal excedenteField;
        
        private decimal subsidioField;
        
        private System.Nullable<decimal> ISRField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal limiteInferior {
            get {
                return this.limiteInferiorField;
            }
            set {
                if ((this.limiteInferiorField.Equals(value) != true)) {
                    this.limiteInferiorField = value;
                    this.RaisePropertyChanged("limiteInferior");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal limiteSuperior {
            get {
                return this.limiteSuperiorField;
            }
            set {
                if ((this.limiteSuperiorField.Equals(value) != true)) {
                    this.limiteSuperiorField = value;
                    this.RaisePropertyChanged("limiteSuperior");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public decimal cuotaFija {
            get {
                return this.cuotaFijaField;
            }
            set {
                if ((this.cuotaFijaField.Equals(value) != true)) {
                    this.cuotaFijaField = value;
                    this.RaisePropertyChanged("cuotaFija");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public decimal excedente {
            get {
                return this.excedenteField;
            }
            set {
                if ((this.excedenteField.Equals(value) != true)) {
                    this.excedenteField = value;
                    this.RaisePropertyChanged("excedente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public decimal subsidio {
            get {
                return this.subsidioField;
            }
            set {
                if ((this.subsidioField.Equals(value) != true)) {
                    this.subsidioField = value;
                    this.RaisePropertyChanged("subsidio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<decimal> ISR {
            get {
                return this.ISRField;
            }
            set {
                if ((this.ISRField.Equals(value) != true)) {
                    this.ISRField = value;
                    this.RaisePropertyChanged("ISR");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RefWSAlumnos.WSAlumnosSoap")]
    public interface WSAlumnosSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento CalcularIMSSResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcularIMSS", ReplyAction="*")]
        Negocio.RefWSAlumnos.CalcularIMSSResponse CalcularIMSS(Negocio.RefWSAlumnos.CalcularIMSSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcularIMSS", ReplyAction="*")]
        System.Threading.Tasks.Task<Negocio.RefWSAlumnos.CalcularIMSSResponse> CalcularIMSSAsync(Negocio.RefWSAlumnos.CalcularIMSSRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento CalcularISRResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcularISR", ReplyAction="*")]
        Negocio.RefWSAlumnos.CalcularISRResponse CalcularISR(Negocio.RefWSAlumnos.CalcularISRRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalcularISR", ReplyAction="*")]
        System.Threading.Tasks.Task<Negocio.RefWSAlumnos.CalcularISRResponse> CalcularISRAsync(Negocio.RefWSAlumnos.CalcularISRRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalcularIMSSRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalcularIMSS", Namespace="http://tempuri.org/", Order=0)]
        public Negocio.RefWSAlumnos.CalcularIMSSRequestBody Body;
        
        public CalcularIMSSRequest() {
        }
        
        public CalcularIMSSRequest(Negocio.RefWSAlumnos.CalcularIMSSRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalcularIMSSRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public CalcularIMSSRequestBody() {
        }
        
        public CalcularIMSSRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalcularIMSSResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalcularIMSSResponse", Namespace="http://tempuri.org/", Order=0)]
        public Negocio.RefWSAlumnos.CalcularIMSSResponseBody Body;
        
        public CalcularIMSSResponse() {
        }
        
        public CalcularIMSSResponse(Negocio.RefWSAlumnos.CalcularIMSSResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalcularIMSSResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Negocio.RefWSAlumnos.AportacionesIMSS CalcularIMSSResult;
        
        public CalcularIMSSResponseBody() {
        }
        
        public CalcularIMSSResponseBody(Negocio.RefWSAlumnos.AportacionesIMSS CalcularIMSSResult) {
            this.CalcularIMSSResult = CalcularIMSSResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalcularISRRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalcularISR", Namespace="http://tempuri.org/", Order=0)]
        public Negocio.RefWSAlumnos.CalcularISRRequestBody Body;
        
        public CalcularISRRequest() {
        }
        
        public CalcularISRRequest(Negocio.RefWSAlumnos.CalcularISRRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalcularISRRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public CalcularISRRequestBody() {
        }
        
        public CalcularISRRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalcularISRResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalcularISRResponse", Namespace="http://tempuri.org/", Order=0)]
        public Negocio.RefWSAlumnos.CalcularISRResponseBody Body;
        
        public CalcularISRResponse() {
        }
        
        public CalcularISRResponse(Negocio.RefWSAlumnos.CalcularISRResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalcularISRResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Negocio.RefWSAlumnos.ItemTablaISR CalcularISRResult;
        
        public CalcularISRResponseBody() {
        }
        
        public CalcularISRResponseBody(Negocio.RefWSAlumnos.ItemTablaISR CalcularISRResult) {
            this.CalcularISRResult = CalcularISRResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WSAlumnosSoapChannel : Negocio.RefWSAlumnos.WSAlumnosSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WSAlumnosSoapClient : System.ServiceModel.ClientBase<Negocio.RefWSAlumnos.WSAlumnosSoap>, Negocio.RefWSAlumnos.WSAlumnosSoap {
        
        public WSAlumnosSoapClient() {
        }
        
        public WSAlumnosSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WSAlumnosSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSAlumnosSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WSAlumnosSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Negocio.RefWSAlumnos.CalcularIMSSResponse Negocio.RefWSAlumnos.WSAlumnosSoap.CalcularIMSS(Negocio.RefWSAlumnos.CalcularIMSSRequest request) {
            return base.Channel.CalcularIMSS(request);
        }
        
        public Negocio.RefWSAlumnos.AportacionesIMSS CalcularIMSS(int id) {
            Negocio.RefWSAlumnos.CalcularIMSSRequest inValue = new Negocio.RefWSAlumnos.CalcularIMSSRequest();
            inValue.Body = new Negocio.RefWSAlumnos.CalcularIMSSRequestBody();
            inValue.Body.id = id;
            Negocio.RefWSAlumnos.CalcularIMSSResponse retVal = ((Negocio.RefWSAlumnos.WSAlumnosSoap)(this)).CalcularIMSS(inValue);
            return retVal.Body.CalcularIMSSResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Negocio.RefWSAlumnos.CalcularIMSSResponse> Negocio.RefWSAlumnos.WSAlumnosSoap.CalcularIMSSAsync(Negocio.RefWSAlumnos.CalcularIMSSRequest request) {
            return base.Channel.CalcularIMSSAsync(request);
        }
        
        public System.Threading.Tasks.Task<Negocio.RefWSAlumnos.CalcularIMSSResponse> CalcularIMSSAsync(int id) {
            Negocio.RefWSAlumnos.CalcularIMSSRequest inValue = new Negocio.RefWSAlumnos.CalcularIMSSRequest();
            inValue.Body = new Negocio.RefWSAlumnos.CalcularIMSSRequestBody();
            inValue.Body.id = id;
            return ((Negocio.RefWSAlumnos.WSAlumnosSoap)(this)).CalcularIMSSAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Negocio.RefWSAlumnos.CalcularISRResponse Negocio.RefWSAlumnos.WSAlumnosSoap.CalcularISR(Negocio.RefWSAlumnos.CalcularISRRequest request) {
            return base.Channel.CalcularISR(request);
        }
        
        public Negocio.RefWSAlumnos.ItemTablaISR CalcularISR(int id) {
            Negocio.RefWSAlumnos.CalcularISRRequest inValue = new Negocio.RefWSAlumnos.CalcularISRRequest();
            inValue.Body = new Negocio.RefWSAlumnos.CalcularISRRequestBody();
            inValue.Body.id = id;
            Negocio.RefWSAlumnos.CalcularISRResponse retVal = ((Negocio.RefWSAlumnos.WSAlumnosSoap)(this)).CalcularISR(inValue);
            return retVal.Body.CalcularISRResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Negocio.RefWSAlumnos.CalcularISRResponse> Negocio.RefWSAlumnos.WSAlumnosSoap.CalcularISRAsync(Negocio.RefWSAlumnos.CalcularISRRequest request) {
            return base.Channel.CalcularISRAsync(request);
        }
        
        public System.Threading.Tasks.Task<Negocio.RefWSAlumnos.CalcularISRResponse> CalcularISRAsync(int id) {
            Negocio.RefWSAlumnos.CalcularISRRequest inValue = new Negocio.RefWSAlumnos.CalcularISRRequest();
            inValue.Body = new Negocio.RefWSAlumnos.CalcularISRRequestBody();
            inValue.Body.id = id;
            return ((Negocio.RefWSAlumnos.WSAlumnosSoap)(this)).CalcularISRAsync(inValue);
        }
    }
}
