using System;
using TestRecords;

var rec = new Record {Age = 75};
var rec2 = new RecordChild {Age = 69, Name = "Brigitte"};
var rec3 = rec2 with {Name = "Gertrude"};
var rec4 = rec2 with {Age = 69};
var rec5 = new RecordChild {Age = 69, Name = "Brigitte"};
var rec6 = new Record {Age = 69, Name = "Brigitte"};
var recpos = new RecordPositional("Brigitte", 69);
var recposchild = new RecordPositionalChild("Gertrude", 24);
//
ChangeName(ref rec);
//
Console.WriteLine(rec == rec2);
Console.WriteLine(rec == rec3);
Console.WriteLine(rec3 == rec2);
//
Console.WriteLine(rec2 == rec4);
Console.WriteLine(rec2.Equals(rec4));
Console.WriteLine(rec2 == rec5);
Console.WriteLine(rec2.Equals(rec5));
Console.WriteLine(rec2 == rec6); // Different Type
Console.WriteLine(rec2.Equals(rec6)); // Different Type
//
Console.WriteLine(rec);
Console.WriteLine(rec2);
Console.WriteLine(recpos);
Console.WriteLine(recposchild);
//
static void ChangeName(ref Record rRecord) { rRecord.Name = "ass"; }