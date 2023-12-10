using System;

public static class Prompt {
    public static string[] _prompts;
    static Prompt() {
        _prompts = new string[] {
            "Did anything exciting happen today?",
            "What was your favorite thing that happened?",
            "Was there something you feel you could've done differently today? What would you have done instead?",
            "Did you do anything to serve others today? How did it make you feel?",
            "How are you feeling, really?"
            };
    }

    public static string obtainPrompt(){
        return _prompts[new Random().Next(5)];
    }
}