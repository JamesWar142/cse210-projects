class Word
{
    // attributes
    private string _word;
    private bool _hide;
    // behaviors
    public Word(string word)
    {
        _word = word;
        _hide = false;
    }
    public void Hide()
    {
        _hide = true;
    }
    public string Display()
    {
        return _hide ? "_____" : _word;
    }
    public bool IsHidden()
    {
        return _hide;
    }
}