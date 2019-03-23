using System;
using System.Collections.Generic;
using System.Text;

namespace MobileClient.Services
{
    /// <summary>
    /// Value Changed EventArgs
    /// </summary>
    public class ValueChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the command.
        /// </summary>
        public string User { get; private set; }
        /// <summary>
        /// Gets the state.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValueChangedEventArgs"/> class.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <param name="state">The state.</param>
        public ValueChangedEventArgs(string user, string message)
        {
            User = user;
            Message = message;
        }
    }
}
