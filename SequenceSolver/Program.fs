// A recursive function to solve the problem:

// Calculate a sequence of integers that is monotonically increasing, and never decreases.
// The first value in the sequence is 1, so when n = 1, f(n) = 1.
// The term for (n + 1) is expressed by f(n + 1) = 1 + f(n + 1 - f(f(n))).
// The maximum input value for n is 9999 
// Example:
// Input: n = 5
/// Output: 3
 
 let rec seq(n:int): int =
    match n with
    | 1 -> 1
    | _ -> 1 + seq(n - seq(seq(n - 1)))

let run = seq(5) |> printfn "%i"
