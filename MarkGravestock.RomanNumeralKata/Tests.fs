module MarkGravestock.RomanNumeralKata.Tests

open Xunit

let rec ArabicToRomanPart arabic roman =
    match arabic with
    | arabic when arabic = 0 -> roman
    | arabic when arabic < 4 -> ArabicToRomanPart (arabic - 1) (roman + "I")
    | arabic when arabic = 4 -> roman + "IV"
    | arabic when arabic < 9 -> ArabicToRomanPart (arabic - 5) (roman + "V")
    | arabic when arabic = 9 -> roman + "IX"
    | arabic when arabic < 50 -> ArabicToRomanPart (arabic - 10) (roman + "X")
    | _ -> ArabicToRomanPart (arabic - 50) (roman + "L")

let ArabicToRoman arabic = ArabicToRomanPart arabic ""

[<Theory>]
[<InlineData(1, "I")>]
[<InlineData(2, "II")>]
[<InlineData(3, "III")>]
[<InlineData(4, "IV")>]
[<InlineData(5, "V")>]
[<InlineData(6, "VI")>]
[<InlineData(7, "VII")>]
[<InlineData(8, "VIII")>]
[<InlineData(9, "IX")>]
[<InlineData(10, "X")>]
[<InlineData(12, "XII")>]
[<InlineData(14, "XIV")>]
[<InlineData(20, "XX")>]
[<InlineData(51, "LI")>]

let ``The number is converted into  a numeral`` (number, numeral) =
    Assert.Equal(ArabicToRoman(number), numeral)
