open System

let myArray = [|1;2;3;4|]
myArray
|> Array.rev
|> Array.iter(printf "%A")