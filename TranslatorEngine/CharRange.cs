using System;

namespace TranslatorEngine
{
    public class CharRange
    {
        public int StartIndex { get; set; }
        public int Length { get; set; }

        public CharRange(int startIndex, int length)
        {
            StartIndex = startIndex;
            Length = length;
        }

        public bool IsInRange(int index) => StartIndex <= index && index <= StartIndex + Length - 1;

        public int GetEndIndex() => StartIndex + Length - 1;
    }
}
