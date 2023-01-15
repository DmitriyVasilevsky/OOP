namespace OOP
{
    class Card
    {
        public string SuitOfCard;
        public string KeyCard;

        public Card(string suitOfCard, string keyCard)
        {
            SuitOfCard = suitOfCard;
            KeyCard = keyCard;
        }

        public string GetInfo()
        {
            return SuitOfCard + KeyCard;
        }
    }
}
