module StockChartBot.Parser

open System
open System.Globalization

type Query = 
    {
        Sender : string
        Ticker : string
        From : DateTime
        Until : DateTime
    }

let parseData (s: string) = 
    DateTime.ParseExact(s, "M/d/yyyy", 
    CultureInfo.InvariantCulture,
    DateTimeStyles.AssumeLocal)





let Parse (text: string) = 
    let elements = text.Split([|' '|])
    {
        Sender = elements.[0]
        Ticker = elements.[1]
        From = elements.[2] |> parseData
        Until = elements.[3] |> parseData
    }


 