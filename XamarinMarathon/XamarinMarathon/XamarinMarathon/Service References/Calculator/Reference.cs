﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XamarinMarathon.Calculator {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.parasoft.com/wsdl/calculator/", ConfigurationName="Calculator.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="add", ReplyAction="*")]
        System.IAsyncResult Beginadd(float x, float y, System.AsyncCallback callback, object asyncState);
        
        [return: System.ServiceModel.MessageParameterAttribute(Name="Result")]
        float Endadd(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="divide", ReplyAction="*")]
        System.IAsyncResult Begindivide(float numerator, float denominator, System.AsyncCallback callback, object asyncState);
        
        [return: System.ServiceModel.MessageParameterAttribute(Name="Result")]
        float Enddivide(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="multiply", ReplyAction="*")]
        System.IAsyncResult Beginmultiply(float x, float y, System.AsyncCallback callback, object asyncState);
        
        [return: System.ServiceModel.MessageParameterAttribute(Name="Result")]
        float Endmultiply(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="subtract", ReplyAction="*")]
        System.IAsyncResult Beginsubtract(float x, float y, System.AsyncCallback callback, object asyncState);
        
        [return: System.ServiceModel.MessageParameterAttribute(Name="Result")]
        float Endsubtract(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : XamarinMarathon.Calculator.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class addCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public addCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public float Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((float)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class divideCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public divideCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public float Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((float)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class multiplyCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public multiplyCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public float Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((float)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class subtractCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public subtractCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public float Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((float)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<XamarinMarathon.Calculator.ICalculator>, XamarinMarathon.Calculator.ICalculator {
        
        private BeginOperationDelegate onBeginaddDelegate;
        
        private EndOperationDelegate onEndaddDelegate;
        
        private System.Threading.SendOrPostCallback onaddCompletedDelegate;
        
        private BeginOperationDelegate onBegindivideDelegate;
        
        private EndOperationDelegate onEnddivideDelegate;
        
        private System.Threading.SendOrPostCallback ondivideCompletedDelegate;
        
        private BeginOperationDelegate onBeginmultiplyDelegate;
        
        private EndOperationDelegate onEndmultiplyDelegate;
        
        private System.Threading.SendOrPostCallback onmultiplyCompletedDelegate;
        
        private BeginOperationDelegate onBeginsubtractDelegate;
        
        private EndOperationDelegate onEndsubtractDelegate;
        
        private System.Threading.SendOrPostCallback onsubtractCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public CalculatorClient() : 
                base(CalculatorClient.GetDefaultBinding(), CalculatorClient.GetDefaultEndpointAddress()) {
        }
        
        public CalculatorClient(EndpointConfiguration endpointConfiguration) : 
                base(CalculatorClient.GetBindingForEndpoint(endpointConfiguration), CalculatorClient.GetEndpointAddress(endpointConfiguration)) {
        }
        
        public CalculatorClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CalculatorClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
        }
        
        public CalculatorClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CalculatorClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<addCompletedEventArgs> addCompleted;
        
        public event System.EventHandler<divideCompletedEventArgs> divideCompleted;
        
        public event System.EventHandler<multiplyCompletedEventArgs> multiplyCompleted;
        
        public event System.EventHandler<subtractCompletedEventArgs> subtractCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult XamarinMarathon.Calculator.ICalculator.Beginadd(float x, float y, System.AsyncCallback callback, object asyncState) {
            return base.Channel.Beginadd(x, y, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        float XamarinMarathon.Calculator.ICalculator.Endadd(System.IAsyncResult result) {
            return base.Channel.Endadd(result);
        }
        
        private System.IAsyncResult OnBeginadd(object[] inValues, System.AsyncCallback callback, object asyncState) {
            float x = ((float)(inValues[0]));
            float y = ((float)(inValues[1]));
            return ((XamarinMarathon.Calculator.ICalculator)(this)).Beginadd(x, y, callback, asyncState);
        }
        
        private object[] OnEndadd(System.IAsyncResult result) {
            float retVal = ((XamarinMarathon.Calculator.ICalculator)(this)).Endadd(result);
            return new object[] {
                    retVal};
        }
        
        private void OnaddCompleted(object state) {
            if ((this.addCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.addCompleted(this, new addCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void addAsync(float x, float y) {
            this.addAsync(x, y, null);
        }
        
        public void addAsync(float x, float y, object userState) {
            if ((this.onBeginaddDelegate == null)) {
                this.onBeginaddDelegate = new BeginOperationDelegate(this.OnBeginadd);
            }
            if ((this.onEndaddDelegate == null)) {
                this.onEndaddDelegate = new EndOperationDelegate(this.OnEndadd);
            }
            if ((this.onaddCompletedDelegate == null)) {
                this.onaddCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnaddCompleted);
            }
            base.InvokeAsync(this.onBeginaddDelegate, new object[] {
                        x,
                        y}, this.onEndaddDelegate, this.onaddCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult XamarinMarathon.Calculator.ICalculator.Begindivide(float numerator, float denominator, System.AsyncCallback callback, object asyncState) {
            return base.Channel.Begindivide(numerator, denominator, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        float XamarinMarathon.Calculator.ICalculator.Enddivide(System.IAsyncResult result) {
            return base.Channel.Enddivide(result);
        }
        
        private System.IAsyncResult OnBegindivide(object[] inValues, System.AsyncCallback callback, object asyncState) {
            float numerator = ((float)(inValues[0]));
            float denominator = ((float)(inValues[1]));
            return ((XamarinMarathon.Calculator.ICalculator)(this)).Begindivide(numerator, denominator, callback, asyncState);
        }
        
        private object[] OnEnddivide(System.IAsyncResult result) {
            float retVal = ((XamarinMarathon.Calculator.ICalculator)(this)).Enddivide(result);
            return new object[] {
                    retVal};
        }
        
        private void OndivideCompleted(object state) {
            if ((this.divideCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.divideCompleted(this, new divideCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void divideAsync(float numerator, float denominator) {
            this.divideAsync(numerator, denominator, null);
        }
        
        public void divideAsync(float numerator, float denominator, object userState) {
            if ((this.onBegindivideDelegate == null)) {
                this.onBegindivideDelegate = new BeginOperationDelegate(this.OnBegindivide);
            }
            if ((this.onEnddivideDelegate == null)) {
                this.onEnddivideDelegate = new EndOperationDelegate(this.OnEnddivide);
            }
            if ((this.ondivideCompletedDelegate == null)) {
                this.ondivideCompletedDelegate = new System.Threading.SendOrPostCallback(this.OndivideCompleted);
            }
            base.InvokeAsync(this.onBegindivideDelegate, new object[] {
                        numerator,
                        denominator}, this.onEnddivideDelegate, this.ondivideCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult XamarinMarathon.Calculator.ICalculator.Beginmultiply(float x, float y, System.AsyncCallback callback, object asyncState) {
            return base.Channel.Beginmultiply(x, y, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        float XamarinMarathon.Calculator.ICalculator.Endmultiply(System.IAsyncResult result) {
            return base.Channel.Endmultiply(result);
        }
        
        private System.IAsyncResult OnBeginmultiply(object[] inValues, System.AsyncCallback callback, object asyncState) {
            float x = ((float)(inValues[0]));
            float y = ((float)(inValues[1]));
            return ((XamarinMarathon.Calculator.ICalculator)(this)).Beginmultiply(x, y, callback, asyncState);
        }
        
        private object[] OnEndmultiply(System.IAsyncResult result) {
            float retVal = ((XamarinMarathon.Calculator.ICalculator)(this)).Endmultiply(result);
            return new object[] {
                    retVal};
        }
        
        private void OnmultiplyCompleted(object state) {
            if ((this.multiplyCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.multiplyCompleted(this, new multiplyCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void multiplyAsync(float x, float y) {
            this.multiplyAsync(x, y, null);
        }
        
        public void multiplyAsync(float x, float y, object userState) {
            if ((this.onBeginmultiplyDelegate == null)) {
                this.onBeginmultiplyDelegate = new BeginOperationDelegate(this.OnBeginmultiply);
            }
            if ((this.onEndmultiplyDelegate == null)) {
                this.onEndmultiplyDelegate = new EndOperationDelegate(this.OnEndmultiply);
            }
            if ((this.onmultiplyCompletedDelegate == null)) {
                this.onmultiplyCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnmultiplyCompleted);
            }
            base.InvokeAsync(this.onBeginmultiplyDelegate, new object[] {
                        x,
                        y}, this.onEndmultiplyDelegate, this.onmultiplyCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult XamarinMarathon.Calculator.ICalculator.Beginsubtract(float x, float y, System.AsyncCallback callback, object asyncState) {
            return base.Channel.Beginsubtract(x, y, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        float XamarinMarathon.Calculator.ICalculator.Endsubtract(System.IAsyncResult result) {
            return base.Channel.Endsubtract(result);
        }
        
        private System.IAsyncResult OnBeginsubtract(object[] inValues, System.AsyncCallback callback, object asyncState) {
            float x = ((float)(inValues[0]));
            float y = ((float)(inValues[1]));
            return ((XamarinMarathon.Calculator.ICalculator)(this)).Beginsubtract(x, y, callback, asyncState);
        }
        
        private object[] OnEndsubtract(System.IAsyncResult result) {
            float retVal = ((XamarinMarathon.Calculator.ICalculator)(this)).Endsubtract(result);
            return new object[] {
                    retVal};
        }
        
        private void OnsubtractCompleted(object state) {
            if ((this.subtractCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.subtractCompleted(this, new subtractCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void subtractAsync(float x, float y) {
            this.subtractAsync(x, y, null);
        }
        
        public void subtractAsync(float x, float y, object userState) {
            if ((this.onBeginsubtractDelegate == null)) {
                this.onBeginsubtractDelegate = new BeginOperationDelegate(this.OnBeginsubtract);
            }
            if ((this.onEndsubtractDelegate == null)) {
                this.onEndsubtractDelegate = new EndOperationDelegate(this.OnEndsubtract);
            }
            if ((this.onsubtractCompletedDelegate == null)) {
                this.onsubtractCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnsubtractCompleted);
            }
            base.InvokeAsync(this.onBeginsubtractDelegate, new object[] {
                        x,
                        y}, this.onEndsubtractDelegate, this.onsubtractCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override XamarinMarathon.Calculator.ICalculator CreateChannel() {
            return new CalculatorClientChannel(this);
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.ICalculator)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.MaxReceivedMessageSize = int.MaxValue;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.ICalculator)) {
                return new System.ServiceModel.EndpointAddress("http://ws1.parasoft.com/glue/calculator");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return CalculatorClient.GetBindingForEndpoint(EndpointConfiguration.ICalculator);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return CalculatorClient.GetEndpointAddress(EndpointConfiguration.ICalculator);
        }
        
        private class CalculatorClientChannel : ChannelBase<XamarinMarathon.Calculator.ICalculator>, XamarinMarathon.Calculator.ICalculator {
            
            public CalculatorClientChannel(System.ServiceModel.ClientBase<XamarinMarathon.Calculator.ICalculator> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult Beginadd(float x, float y, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = x;
                _args[1] = y;
                System.IAsyncResult _result = base.BeginInvoke("add", _args, callback, asyncState);
                return _result;
            }
            
            public float Endadd(System.IAsyncResult result) {
                object[] _args = new object[0];
                float _result = ((float)(base.EndInvoke("add", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult Begindivide(float numerator, float denominator, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = numerator;
                _args[1] = denominator;
                System.IAsyncResult _result = base.BeginInvoke("divide", _args, callback, asyncState);
                return _result;
            }
            
            public float Enddivide(System.IAsyncResult result) {
                object[] _args = new object[0];
                float _result = ((float)(base.EndInvoke("divide", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult Beginmultiply(float x, float y, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = x;
                _args[1] = y;
                System.IAsyncResult _result = base.BeginInvoke("multiply", _args, callback, asyncState);
                return _result;
            }
            
            public float Endmultiply(System.IAsyncResult result) {
                object[] _args = new object[0];
                float _result = ((float)(base.EndInvoke("multiply", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult Beginsubtract(float x, float y, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = x;
                _args[1] = y;
                System.IAsyncResult _result = base.BeginInvoke("subtract", _args, callback, asyncState);
                return _result;
            }
            
            public float Endsubtract(System.IAsyncResult result) {
                object[] _args = new object[0];
                float _result = ((float)(base.EndInvoke("subtract", _args, result)));
                return _result;
            }
        }
        
        public enum EndpointConfiguration {
            
            ICalculator,
        }
    }
}
