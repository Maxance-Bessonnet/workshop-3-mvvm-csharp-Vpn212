using System.Windows.Input;

namespace CraftLR.Exercice7;

public class HelloButtonViewModel : HelloButtonViewModelBase
{
    private string _buttonCaption = "Hello!";
    private int _numberOfClicks;
    private bool _isButtonEnabled = true;

    public string ButtonCaption
    {
        get => _buttonCaption;
        set
        {
            if (_buttonCaption == value) return;
            _buttonCaption = value;
            OnPropertyChanged();
        }
    }

    public bool IsButtonEnabled
    {
        get => _isButtonEnabled;
        set
        {
            if (_isButtonEnabled == value) return;
            _isButtonEnabled = value;
            OnPropertyChanged();
        }
    }

    public void CountClick()
    {
        _numberOfClicks++;
        ButtonCaption = $"{_numberOfClicks} Clicks";
        if (_numberOfClicks >= 5)
        {
            IsButtonEnabled = false;
        }
    }
}