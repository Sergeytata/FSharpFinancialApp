module StockChartBot.Parser.Tests


open System
open NUnit.Framework
open StockChartBot.Parser

/// Test explorer does not support FSCheck there is a different test EXplorer, which supports xUnit
/// Maybe there is a way of testing FSCheck,Nunit with this test explorer
open FsCheck
open FsCheck.NUnit
open Expecto

[<TestFixture("@StockChartBot LNKD 1/1/2000 12/31/2015", "@StockChartBot", "LNKD")>]
[<TestFixture("@AnotherBot LNKD 1/1/2000 12/31/2015", "@AnotherBot", "LNKD")>]
[<TestFixture("@AnotherBot MSFT 1/1/2000 12/31/2015", "@AnotherBot", "MSFT")>]
type ``give some valid text``(text, sender, ticker) = 
    [<Test>]    
    member this.``the parser parsers the text into sender ticker from to``() = 
        let actual = Parse text
        let expected = 
            { 
                Sender = sender
                Ticker = ticker
                From = DateTime(2000,1,1)
                Until = DateTime(2015, 12, 31)

            }

        Assert.AreEqual(expected, actual)


[<Tests>]
let SimpleTest =
    testCase "A simple test" <| fun () ->
    let expected = 4
    Expect.equal (2+2) expected "2+2 = 4"
