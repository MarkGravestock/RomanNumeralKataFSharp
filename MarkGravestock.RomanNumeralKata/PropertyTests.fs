module MarkGravestock.RomanNumeralKata.PropertyTests

open System
open Xunit
open MarkGravestock.RomanNumeralKata.Tests

let assertMaxRepetition str count (input:String) = 
    let moreThanMaximumRepitition = String(str, count + 1)
    let containsMoreThanMaxRepitition:bool = input.Contains(moreThanMaximumRepitition)
    Assert.False(containsMoreThanMaxRepitition)
        

[<Fact>]
    let ``For all valid inputs, there must be a max of four "I"s in a row``() = 
        for i in [1..4000] do
           let roman = ArabicToRoman i
           roman |> assertMaxRepetition 'I' 4
