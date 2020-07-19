module MarkGravestock.RomanNumeralKata.Tests

open System
open Xunit

let ArabicToRoman(arabic) = match arabic with
                            | arabic when arabic < 9 -> new String('I', arabic)
                            | _ -> "IX"

[<Fact>]
let ``When the number 1 is entered then it returns the numeral I`` () =
    Assert.Equal(ArabicToRoman(1), "I")

[<Fact>]
let ``When the number 3 is entered then it returns the numeral III`` () =
    Assert.Equal(ArabicToRoman(3), "III")

[<Fact>]
let ``When the number 9 is entered then it returns the numeral IX`` () =
    Assert.Equal(ArabicToRoman(9), "IX")
    
[<Theory>]
[<InlineData(2, "II")>]
let ``The number is converted into  a numeral`` (number, numeral) =
    Assert.Equal(ArabicToRoman(number), numeral)
