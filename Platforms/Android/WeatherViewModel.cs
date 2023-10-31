using System.ComponentModel;

public class WeatherViewModel : INotifyPropertyChanged
{
    private WeatherModel _weather;

    public WeatherModel Weather
    {
        get { return _weather; }
        set
        {
            _weather = value;
            OnPropertyChanged(nameof(Weather));
        }
    }

    public WeatherViewModel()
    {
        Weather = new WeatherModel { City = "New York", Temperature = "25°C" };
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}