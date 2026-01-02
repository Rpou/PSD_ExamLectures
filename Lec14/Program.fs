module Program
open X86
    


let private assertEqual name expected actual =
    if expected <> actual then
        failwithf "Test '%s' FAILED.\nExpected:\n%A\nActual:\n%A" name expected actual
    else
        printfn "Test '%s' passed." name

let test_operand () =
    assertEqual "operand Cst" "42" (operand (Cst 42))
    assertEqual "operand Reg" "eax" (operand (Reg Eax))
    assertEqual "operand Ind" "[ebx]" (operand (Ind Ebx))
    assertEqual "operand EbpOff" "[ebp - 32]" (operand (EbpOff 32))
    assertEqual "operand Glovars" "[glovars]" (operand Glovars)

[<EntryPoint>]
let main _ =
    test_operand()
    0