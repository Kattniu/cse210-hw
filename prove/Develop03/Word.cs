public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Inicialmente, la palabra es visible
    }

    // Ocultar la palabra
    public void Hide()
    {
        _isHidden = true;
    }

    // Mostrar la palabra
    public void Show()
    {
        _isHidden = false;
    }

    // Verificar si la palabra esta oculta
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Obtener el texto a mostrar (oculto o visible)
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            // Si la palabra esta oculta, devolver una serie de guiones bajos del mismo tamaño que la palabra
            return new string('_', _text.Length);
        }
        else
        {
            // Si no esta oculta, devolver la palabra original
            return _text;
        }
    }
}
