using System;
using System.ComponentModel;
using System.Windows.Input;


namespace Tg2_Dev_2
{
    /// <summary>
    /// Internal view model for the app, that maintains the state 
    /// with the forms player hub.
    /// </summary>
    internal class AppViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, args) => { };

        
        string xaml;
        string json;
        string status;
       

        public AppViewModel()
        {
            
        }

        

        public string Xaml { get { return xaml; } set { SetProperty(ref xaml, value, "Xaml"); } }

        public string Json { get { return json; } set { SetProperty(ref json, value, "Json"); } }

        public string Status { get { return status; } set { SetProperty(ref status, value, "Status"); } }


        public void Start()
        {
            // We don't do anything special on start (yet?)
        }

        public void Sleep()
        {
            // Disconnect automatically.
            
        }

        public void Resume()
        {
            // Reconnect automatically if it was previously connected.
            
        }

        void Connect()
        {
            //IsConnected = false;
            //connection = new HubConnection(ThisAssembly.HubUrl);
            //var proxy = connection.CreateHubProxy("FormsPlayer");

            //proxy.On<string>("Xaml", xaml => Xaml = xaml);
            //proxy.On<string>("Json", json => Json = json);

            //try
            //{
            //    connection.Start().Wait(3000);
            //    proxy.Invoke("Join", SessionId);
            //    IsConnected = true;
            //    Status = "Successfully connected to FormsPlayer";
            //}
            //catch (Exception e)
            //{
            //    var message = e.Message;
            //    if (e is AggregateException)
            //        message = ((AggregateException)e).InnerException.Message;

            //    Status = "Error connecting to FormsPlayer: " + message;
            //    connection.Dispose();
            //}
        }

        void Disconnect()
        {
            //connection.Stop();
            //connection.Dispose();
            //connection = null;
            //IsConnected = false;
        }

        void SetProperty<T>(ref T field, T value, string name)
        {
            if (!Object.Equals(field, value))
            {
                field = value;
                PropertyChanged(this, new PropertyChangedEventArgs(name));
                //if (name == "SessionId")
                //    CrossSettings.Current.AddOrUpdateValue(name, value);
            }
        }
    }
}
