using System;
using SmallTests;

TestSetter();
Console.WriteLine(TestPatternStuff(new()));
Console.WriteLine(TestPatternStuff(new Boy()));
Console.WriteLine(LifeStageAtAge(16));

static void TestSetter()
{
    var initSetter1 = new InitSetter();
    var initSetter2 = new InitSetter {Ass = "JoeMama"};
    // var initSetter3 = new InitSetter("JoeMama");         <-- Doesn't Work
    // initSetter1.Ass = "dasds";                           <-- Doesn't Work

    var noSetter1 = new NoSetter();
    // var noSetter2 = new NoSetter(){Ass = "JoeMama"};     <-- Doesn't Work
    var noSetter3 = new NoSetter("JoeMama");
    // noSetter1.Ass = "dasds";                             <-- Doesn't Work
}

static string TestPatternStuff(Human human) => human switch
                                               {
                                                   Boy => "It's a Boy",
                                                   Girl => "It's a Girl",
                                                   _ => "It's no-one"
                                               };

static string LifeStageAtAge(int age) => age switch
                                         {
                                             < 0 => "Infant",
                                             < 17 and >= 0 => "Teen",
                                             _ => "Oldie"
                                         };