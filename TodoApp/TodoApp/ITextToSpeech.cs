using System;

namespace TodoApp
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
