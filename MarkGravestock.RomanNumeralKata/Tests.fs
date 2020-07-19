module MarkGravestock.RomanNumeralKata.Tests

open System
open Xunit

let ArabicToRoman(arabic) = match arabic with
                            | arabic when arabic < 9 -> String('I', arabic)
                            | _ -> "IX"

[<Theory>]
[<InlineData(1, "I")>]
[<InlineData(2, "II")>]
[<InlineData(3, "III")>]
[<InlineData(9, "IX")>]
let ``The number is converted into  a numeral`` (number, numeral) =
    Assert.Equal(ArabicToRoman(number), numeral)
