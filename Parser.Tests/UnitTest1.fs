module StockChartBot.Parser.Tests


open System
open NUnit.Framework
open StockChartBot.Parser

type ``give some valid text``() = 
    [<Test>]
    member this.``simple test``() = 
        let expected = true
        let actual = true
        Assert.AreEqual(expected, actual)

    [<Test>]    
    member this.``the parser parsers the text into sender ticker from to``() = 
        let text = "@StockChartBot LNKD 1/1/2000 12/31/2015"
        let actual = Parse text
        let expected = 
            { 
                Sender = "@StockChartBot"
                Ticker = "LNKD"
                From = DateTime(2000,1,1)
                Until = DateTime(2015, 12, 31)

            }

        Assert.AreEqual(expected, actual)
