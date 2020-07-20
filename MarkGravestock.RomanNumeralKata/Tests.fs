module MarkGravestock.RomanNumeralKata.Tests

open System
open Xunit

let ArabicToRoman(arabic) = match arabic with
                            | arabic when arabic < 4 -> String('I', arabic)
                            | arabic when arabic = 4 -> "IV"
                            | arabic when arabic < 9 -> "V"
                            | _ -> "IX"

[<Theory>]
[<InlineData(1, "I")>]
[<InlineData(2, "II")>]
[<InlineData(3, "III")>]
[<InlineData(4, "IV")>]
[<InlineData(5, "V")>]
[<InlineData(9, "IX")>]
let ``The number is converted into  a numeral`` (number, numeral) =
    Assert.Equal(ArabicToRoman(number), numeral)
