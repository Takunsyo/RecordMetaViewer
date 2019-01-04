using System.ComponentModel;

namespace RecordMetaViewer.ViewModel
{
    /// <summary>
    /// Base view model class.
    /// <para> * This program is using PropertyChanged.Fody.</para>
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Event to notify a property's content has been modified.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender,e) => { };

        public void NotifyPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
    }
}