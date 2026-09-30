namespace Cards;

public readonly struct CardColor
{
    public CardType Type { get; }

    public CardColor(CardType type)
    {
        Type = type;
    }

    public override bool Equals(object? obj)
    {
        if (obj is CardColor other)
        {
            return Type == other.Type;
        }

        return false;
    }
    public override int GetHashCode()
    {
        return Type.GetHashCode();
    }
}