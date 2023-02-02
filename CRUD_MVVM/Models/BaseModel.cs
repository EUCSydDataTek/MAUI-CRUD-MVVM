using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CRUD_MVVM.Models;
public class BaseModel : INotifyPropertyChanged
{
    public int Id { get; set; }
    protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = "", Action onChanged = null)
    {
        if (EqualityComparer<T>.Default.Equals(backingStore, value))
            return false;

        backingStore = value;
        onChanged?.Invoke();
        OnPropertyChanged(propertyName);
        return true;
    }

    #region INotifyPropertyChanged
    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        var changed = PropertyChanged;

        if (changed == null)
            return;
        var invocationlist = changed.GetInvocationList();   // Shows the total numbers of bindings
        changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    #endregion
}
