module MarkGravestock.RomanNumeralKata.PropertyTests

open System
open FsCheck
open Xunit
open MarkGravestock.RomanNumeralKata.Tests

let assertMaxRepetition str count (input: String) =
    let moreThanMaximumRepitition = String(str, count + 1)
    let containsMoreThanMaxRepitition: bool = input.Contains(moreThanMaximumRepitition)
    printf "assertMaxRepetition %s %i %s" (str.ToString()) count input
    Assert.False(containsMoreThanMaxRepitition)

let hasMaxRepetition str count (input: String) =
    let moreThanMaximumRepitition = String(str, count + 1)
    input.Contains(moreThanMaximumRepitition)

[<Fact>]
let ``For all valid inputs, there must be a max of four "I"s in a row`` () =
    for i in [ 1 .. 4000 ] do
        let roman = ArabicToRoman i
        roman |> assertMaxRepetition 'I' 4

[<Fact>]
let ``For all valid inputs, there must be a max of one "V"`` () =
    for i in [ 1 .. 4000 ] do
        let roman = ArabicToRoman i
        roman |> assertMaxRepetition 'V' 1

[<Fact>]
let ``For all valid inputs, there must be a max of one "V" using FsCheck``() =

  let inputRange = Gen.choose(0,4000) |> Arb.fromGen
  
  Prop.forAll inputRange (fun arabic -> 
                let roman = ArabicToRoman arabic
                roman |> assertMaxRepetition 'V' 1 
                )
