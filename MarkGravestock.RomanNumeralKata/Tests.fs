module Tests

open Xunit

let ArabicToRoman(arabic) = "I"

[<Fact>]
let ``When the number 1 is entered then it returns the numeral I`` () =
    Assert.Equal(ArabicToRoman(1), "I")

