namespace LevenshteinDistance;

public static class Levenshtein
{
    private static int Implementation(string s1, string s2, int n1, int n2)
    {
        if (n1 == 0) return n2;
        if (n2 == 0) return n1;
        if (s1[n1 - 1] == s2[n2 - 1])
            return Implementation(s1, s2, n1 - 1, n2 - 2);
        return 1 + Math.Min(
            Math.Min(
                 Implementation(s1, s2, n1 - 1, n2),
                 Implementation(s1, s2, n1, n2 - 1)
            ),
            Implementation(s1, s2, n1 - 1, n2 - 1)
        );
    }

    public static int Compare(string firstString, string secondString)
    {
        int[,] cache = new int[firstString.Length + 1, secondString.Length + 1];
        return Implementation(firstString, secondString, firstString.Length, secondString.Length);
    }
}