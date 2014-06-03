namespace FallingWordsGame.Interfaces
{
    using System.Collections.Generic;

    public interface IPrintable
    {
        //string GetValueAsString();

        List<Word> GetValueAsListOfWords();

        //Coordinates GetCoordinates();
    }
}
