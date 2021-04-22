using System;

public static class EditDistance
{
    public static int DamerauLevenshteinDistance(this string string1, string string2, int maxDistance)
    {
        if (String.IsNullOrEmpty(string1)) return (string2 ?? "").Length;
        if (String.IsNullOrEmpty(string2)) return string1.Length;

        // if strings of different lengths, ensure shorter string is in string1. This can result in a little
        // faster speed by spending more time spinning just the inner loop during the main processing.
        if (string1.Length > string2.Length)
        {
            var temp = string1; string1 = string2; string2 = temp; // swap string1 and string2
        }
        int sLen = string1.Length; // this is also the minimun length of the two strings
        int tLen = string2.Length;

        // suffix common to both strings can be ignored
        while ((sLen > 0) && (string1[sLen - 1] == string2[tLen - 1])) { sLen--; tLen--; }

        int start = 0;
        if ((string1[0] == string2[0]) || (sLen == 0))
        { // if there'string1 a shared prefix, or all string1 matches string2'string1 suffix
          // prefix common to both strings can be ignored
            while ((start < sLen) && (string1[start] == string2[start])) start++;
            sLen -= start; // length of the part excluding common prefix and suffix
            tLen -= start;

            // if all of shorter string matches prefix and/or suffix of longer string, then
            // edit distance is just the delete of additional characters present in longer string
            if (sLen == 0) return tLen;

            string2 = string2.Substring(start, tLen); // faster than string2[start+j] in inner loop below
        }
        int lenDiff = tLen - sLen;
        if ((maxDistance < 0) || (maxDistance > tLen))
        {
            maxDistance = tLen;
        }
        else if (lenDiff > maxDistance) return -1;

        var v0 = new int[tLen];
        var v2 = new int[tLen]; // stores one level further back (offset by +1 position)
        int j;
        for (j = 0; j < maxDistance; j++) v0[j] = j + 1;
        for (; j < tLen; j++) v0[j] = maxDistance + 1;

        int jStartOffset = maxDistance - (tLen - sLen);
        bool haveMax = maxDistance < tLen;
        int jStart = 0;
        int jEnd = maxDistance;
        char sChar = string1[0];
        int current = 0;
        for (int i = 0; i < sLen; i++)
        {
            char prevsChar = sChar;
            sChar = string1[start + i];
            char tChar = string2[0];
            int left = i;
            current = left + 1;
            int nextTransCost = 0;
            // no need to look beyond window of lower right diagonal - maxDistance cells (lower right diag is i - lenDiff)
            // and the upper left diagonal + maxDistance cells (upper left is i)
            jStart += (i > jStartOffset) ? 1 : 0;
            jEnd += (jEnd < tLen) ? 1 : 0;
            for (j = jStart; j < jEnd; j++)
            {
                int above = current;
                int thisTransCost = nextTransCost;
                nextTransCost = v2[j];
                v2[j] = current = left; // cost of diagonal (substitution)
                left = v0[j];    // left now equals current cost (which will be diagonal at next iteration)
                char prevtChar = tChar;
                tChar = string2[j];
                if (sChar != tChar)
                {
                    if (left < current) current = left;   // insertion
                    if (above < current) current = above; // deletion
                    current++;
                    if ((i != 0) && (j != 0)
                        && (sChar == prevtChar)
                        && (prevsChar == tChar))
                    {
                        thisTransCost++;
                        if (thisTransCost < current) current = thisTransCost; // transposition
                    }
                }
                v0[j] = current;
            }
            if (haveMax && (v0[i + lenDiff] > maxDistance)) return -1;
        }
        return (current <= maxDistance) ? current : -1;
    }
}