module Program

open ParseAndComp

[<EntryPoint>]
let main _ =
    let p = fromFile "ListC/ex30.lc"
    printfn "AST: %A" p
    0