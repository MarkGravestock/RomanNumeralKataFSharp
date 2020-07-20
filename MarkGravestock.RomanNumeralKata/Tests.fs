module MarkGravestock.RomanNumeralKata.Tests

open System
open Xunit

let ArabicToRoman(arabic) = match arabic with
                            | arabic when arabic < 4 -> String('I', arabic)
                            | arabic when arabic = 4 -> "IV"
                            | arabic when arabic < 9 -> "V" + String('I', arabic - 5) // Duplication between 1st match && this 
                            | arabic when arabic = 9 -> "IX"
                            | _ -> "X"  + String('I', arabic - 10) // Duplication between 1st match && this                            

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
let ``The number is converted into  a numeral`` (number, numeral) =
    Assert.Equal(ArabicToRoman(number), numeral)
