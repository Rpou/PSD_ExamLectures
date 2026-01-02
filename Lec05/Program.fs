open Fun
open TypedFun

let test = eval (If(CstI 1, CstI 1111, CstI 2222)) [] ;
printfn "%A" test;