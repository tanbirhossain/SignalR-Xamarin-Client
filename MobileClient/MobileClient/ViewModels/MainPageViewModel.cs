using MobileClient.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace MobileClient.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private int slideValue;
        private readonly SignalRClient _signalR;

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?
                .Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="MainPageViewModel"/> class.
        /// </summary>
        public MainPageViewModel()
        {
            slideValue = 0;
            _signalR = new SignalRClient();

            Task.Run(async () =>
                           await _signalR.SendMessage("xaminUser", "Hi bro Chill from main"));
            _signalR.ValueChanged += SignalR_ValueChanged;
        }

        /// <summary>
        /// Handles the ValueChanged event of the SignalR control.
        /// </summary>
        private void SignalR_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //slideValue = (int)e.State;
            var reciveMessage = e.Message; // recive message from hub

            OnPropertyChanged(nameof(SlideValue));
        }

        /// <summary>
        /// Gets or sets the slide value.
        /// </summary>
        public int SlideValue
        {
            get { return slideValue; }
            set
            {
                if (slideValue != value)
                {
                    slideValue = value;
                    Task.Run(async () =>
                             await _signalR.SendMessage("xaminUser", "Hi bro Chill"));
                }
            }
        }
    }
}
