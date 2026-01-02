module Program

open Expr
open Absyn

let private assertEqual name expected actual =
    if expected <> actual then
        failwithf "Test '%s' FAILED.\nExpected: %A\nActual:   %A" name expected actual
    else
        printfn "Test '%s' passed." name

let test_eval () =
    assertEqual "run e1" 34 (run e1)     // let z=17 in z+z end
    assertEqual "run e2" 2217 (run e2)   // (100*22)+17
    assertEqual "run e3" 100 (run e3)    // (5-4)*100

let runAll () =
    test_eval()
    printfn "All Expr tests passed."

[<EntryPoint>]
let main _ =
    runAll()
    0
