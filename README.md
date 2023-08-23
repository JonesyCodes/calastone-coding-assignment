# Calastone Coding Assignment

A C# Console Application that reads the contents of a text file, applies a set of filters, and writes the result to the console.

Applied filters:

* Filter out words containing a vowel in their centre.
* Filter out words less than three characters long.
* Filter out words containing the letter 't'.

## Assumptions

* Punctuation and whitespace are not counted as words and should be preserved.
* The letter 't' filter is case insensitive.

## Further improvements

* Configure dependency injection, TextFilterService.cs is written to allow this.
* Add exception handling and logging.
* Add unit tests for FilePath.cs.