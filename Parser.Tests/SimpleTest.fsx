let print x = printfn "%A \n" x
let id x = 
    fun x -> x

let mixedTuple id = 
    let n1 = id 3
    let n2 = id 3.0
    print n1
    print n2

mixedTuple id