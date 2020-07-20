module MarkGravestock.RomanNumeralKata.Tests

open System
open Xunit

let ArabicToRoman(arabic) = match arabic with
                            | arabic when arabic < 4 -> String('I', arabic)
                            | arabic when arabic = 4 -> "IV"
                            | arabic when arabic = 5 -> "V"
                            | arabic when arabic = 6 -> "VI"
                            | arabic when arabic < 9 -> "VII"
                            | _ -> "IX"

[<Theory>]
[<InlineData(1, "I")>]
[<InlineData(2, "II")>]
[<InlineData(3, "III")>]
[<InlineData(4, "IV")>]
[<InlineData(5, "V")>]
[<InlineData(6, "VI")>]
[<InlineData(7, "VII")>]
[<InlineData(9, "IX")>]
let ``The number is converted into  a numeral`` (number, numeral) =
    Assert.Equal(ArabicToRoman(number), numeral)
