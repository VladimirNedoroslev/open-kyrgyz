﻿// See https://aka.ms/new-console-template for more information

using System.Text;
using OpenKyrgyz.Core.Tenses.PresentAndFutureSimple;

Console.OutputEncoding = Encoding.UTF8;
var verb = "кам көр";
// var result = ImperativeTenseGenerator.GenerateAllImperativeTensesForVerb(verb);
var result = PresentAndFutureSimpleTenseConjugator.GenerateForAllPronouns(verb);
foreach (var kvPair in result)
{
    Console.WriteLine($"{kvPair.Key}: {kvPair.Value}");
}