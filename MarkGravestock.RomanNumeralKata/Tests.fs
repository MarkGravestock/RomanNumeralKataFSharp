module MarkGravestock.RomanNumeralKata.Tests

open Xunit

let ArabicToRoman(arabic) = match arabic with
                            | 1 -> "I"
                            | _ -> "III"

[<Fact>]
let ``When the number 1 is entered then it returns the numeral I`` () =
    Assert.Equal(ArabicToRoman(1), "I")

[<Fact>]
let ``When the number 3 is entered then it returns the numeral III`` () =
    Assert.Equal(ArabicToRoman(3), "III")
