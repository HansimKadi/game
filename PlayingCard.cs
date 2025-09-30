namespace game;

public class PlayingCard
{
    private string _Suit = null!;
    private string _Value = null!;
    private int _temp_int;
    public enum Suits
    {
        clubs,
        diamonds,
        hearts,
        spades
    }

    public enum Values
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public string Suit
    {
        get
        {
            return _Suit;
        }
        set
        {
            _temp_int = int.Parse(value);
            if (_temp_int < 0 || _temp_int > 3)
            {
                Console.WriteLine($"Invalid input into suit setter: value atempted was {_temp_int}");
            }
            else
            {
                Suits _Suit = (Suits)_temp_int;
            }
        }
    }
    public string Value
    {
        get
        {
            return _Value;
        }
        set
        {
            _temp_int = int.Parse(value);
            if (_temp_int < 0 || _temp_int > 13)
            {
                Console.WriteLine($"Invalid input into value setter: atempted value was {_temp_int}");
            }
            else
            {
                Values _Value = (Values)_temp_int;
            }
        }
    }
    public PlayingCard(string suit, string value)
    {
        _Suit = suit;
        _Value = value;
    }
}
