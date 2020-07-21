module MarkGravestock.RomanNumeralKata.Tests

open Xunit

// Name of function??
let rec ArabicToRomanPart arabic roman =
    match arabic with
    | arabic when arabic = 0 -> roman
    | arabic when arabic < 4 -> ArabicToRomanPart (arabic - 1) (roman + "I")
    | arabic when arabic < 5 -> ArabicToRomanPart (arabic - 4) (roman + "IV")
    | arabic when arabic < 9 -> ArabicToRomanPart (arabic - 5) (roman + "V")
    | arabic when arabic < 10 -> ArabicToRomanPart (arabic - 9) (roman + "IX")
    | arabic when arabic < 40 -> ArabicToRomanPart (arabic - 10) (roman + "X")
    | arabic when arabic < 50 -> ArabicToRomanPart (arabic - 40) (roman + "XL")
    | arabic when arabic < 90 -> ArabicToRomanPart (arabic - 50) (roman + "L")
    | arabic when arabic < 100 -> ArabicToRomanPart (arabic - 90) (roman + "XC")
    | arabic when arabic < 400 -> ArabicToRomanPart (arabic - 100) (roman + "C")
    | arabic when arabic < 500 -> ArabicToRomanPart (arabic - 400) (roman + "CD")
    | arabic when arabic < 900 -> ArabicToRomanPart (arabic - 500) (roman + "D")
    | arabic when arabic < 1000 -> ArabicToRomanPart (arabic - 900) (roman + "CM")
    | _ -> ArabicToRomanPart (arabic - 1000) (roman + "M")

let ArabicToRoman arabic = ArabicToRomanPart arabic ""

[<Theory>]
[<InlineData(0, "")>]
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
[<InlineData(40, "XL")>]
[<InlineData(44, "XLIV")>]
[<InlineData(51, "LI")>]
[<InlineData(90, "XC")>]
[<InlineData(375, "CCCLXXV")>]
[<InlineData(400, "CD")>]
[<InlineData(825, "DCCCXXV")>]
[<InlineData(1066, "MLXVI")>]
[<InlineData(1989, "MCMLXXXIX")>]

let ``The number is converted into  a numeral`` (number, numeral) =
    Assert.Equal(numeral, ArabicToRoman(number))
