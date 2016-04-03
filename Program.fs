open System
open System.IO

let stringReverse (s: string) =
    String(Array.rev (s.ToCharArray()))

let reverseComplimentDNA =
    String.map(function
        | 'T' -> 'A'
        | 'A' -> 'T'
        | 'C' -> 'G'
        | 'G' -> 'C'
        | x -> x)

[<EntryPoint>]
let main argv = 
    let path = @"/home/jacque/Downloads/rosalind_revc.txt"

    let file = File.ReadAllText(path)
    //let file = "AAAACCCGGT"
    file
    |> stringReverse
    |> reverseComplimentDNA
    |> printfn "%s" 

    0 // return an integer exit code

