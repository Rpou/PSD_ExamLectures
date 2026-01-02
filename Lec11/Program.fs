open Contfun
open Contimp
open Icon

let test = run (Prim("+", CstI 1, CstI 2))

printfn "Result: %A" test