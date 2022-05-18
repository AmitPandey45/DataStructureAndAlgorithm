namespace CommonAlgorithms.Interface
{
    public interface IInputReader
    {
        string CommaSeparatedString();

        string SpaceSeparatedString();

        string InputString();

        string InputString(string message);

        string[] ArrayStringReader();

        int[] ArrayIntegerReader();
    }
}
