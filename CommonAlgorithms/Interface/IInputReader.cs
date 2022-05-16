namespace CommonAlgorithms.Interface
{
    public interface IInputReader
    {
        string CommaSeparatedString();

        string SpaceSeparatedString();

        string InputString();

        string[] ArrayStringReader();

        int[] ArrayIntegerReader();
    }
}
