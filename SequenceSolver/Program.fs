let rec seq(n:int): int =
    match n with
    | 0 | 1 -> n
    | n -> 1 + seq(n - seq(seq(n - 1)))

let run = seq(5) |> printfn "%i"