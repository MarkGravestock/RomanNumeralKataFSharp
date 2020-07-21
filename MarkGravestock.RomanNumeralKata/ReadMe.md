### Roman Numeral Kata - F#

This is my attempt at the [Roman Numeral Kata](https://agilekatas.co.uk/katas/romannumerals-kata). I've done this before in C# (using Fixie as the test framework!).

I was looking at F# Katas as this is an to complete something in F#. I noticed that [Scott Wlachsin](https://swlaschin.gitbooks.io/fsharpforfunandprofit/content/posts/roman-numeral-kata.html) has a commentary
and some other material on it, so decided to give it a go before reading his notes/examples.

### Notes

- Try to use more [functional approach](https://fsharpforfunandprofit.com/learning-fsharp/#dos-and-donts). Use pattern matching rather than for/if-else (idiomatic?)
- Ended up with a single recursive function, but there is duplication in the explicit pattern matches. Not sure if there is an elegant way to switch this out, with out switching to a recursive
function without a pattern match although maybe this would conflict with trying to us a functional approach which is main reason for using F#
- I watched [Corey Haines attempt at the kata](http://programmingtour.blogspot.com.au/2012/12/roman-numerals-kata-with-commentary.html) which was a ruby implementation of the Kata. The
guidance about introducing additional code to reveal duplication of algorithms matched my experience. I though the transformations applied for 'II' was quite large, and the selection of test
cases to match the algorithm (and mechanically going thru them) seemed redundant and to be driven by the implementation rather than vice-versa. I don't think this invalidated the approach
totally, but the fact that you have already solved the algorithmic part of the kata is maybe one of the aspects of a kata that means each one should have a different specific focus. I 
did the kata long enough ago, I couldn't remember the algorithm I used, but it had similar characteristics to the F#
- I did find myself adding test cases as the one in the kata I used were not useful for driving, not sure if they were supposed to be comprehensive (again maybe some more planning). Also another
version of the [kata on codingdojo](http://codingdojo.org/cgi-bin/wiki.pl?KataRomanNumerals) 
- I thought [Scott Wlachsin's commentary](https://swlaschin.gitbooks.io/fsharpforfunandprofit/content/posts/roman-numeral-kata.html) was very thought provoking, and was a reminder
that understanding the domain should be considered as a valid part of the Kata as well (what are you trying to get out of it?), not just a purely technical implementation exercise.
    - The solutions that he came up with based on the domain I think do have good comprehensibility, I think especially the one based on abacus/bi-quinary coded decimal as this is model that was clearly used by people. 
    - EDUF (Enough Design Up Front)? I think there is a balance of planning and doing. I think Scott makes the case for more planning, however understanding the point of diminishing returns
    and 'analysis paralysis' are important, and starting to code even with imperfect knowledge is good. Switching between higher level activities (requirements, analysis, design) and lower-level activites
    (coding, testing) is an important skill.  
    - Also property based testing was mentioned, which would be a good exercise for a kata
    - TDD - Classic/Chicago/Algorithmic/Inside-Out vs. GOOS/London/Interaction/Outside-In 

### Things to consider

- Triangulation and [TPP](https://en.wikipedia.org/wiki/Transformation_Priority_Premise) as ways to move in small steps from the Specific to Generic 
