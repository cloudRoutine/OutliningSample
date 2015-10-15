#r "System.Runtime"
#r "System"
#I @"..\."
#load "Library1.fs"

#load  "File1.fs"
       "File2.fs"       
       "File3.fs"

open System
open System.Collections
open System.Collections.Generic

module Toplevel =
    [<  
        CompilationRepresentationAttribute  
    
        (CompilationRepresentationFlags.
            ModuleSuffix)


    >]

    module ``Who Cares?`` =
        [<  
            CompilationRepresentationAttribute  
    
            (CompilationRepresentationFlags.
                None
                )


        >]

        let z = 1
        ()


    seq{ 

        10  ..   1000


        } |> ignore

module ``Functions and Lambdas`` =

    let rec recfunc a = 
        () 
        ()

    and andfunc a =
        ()
        ()

    let outerfunc a =
        let rec inner_recfunc a = 
            ()
            ()

        and inner_andfunc a =
            ()
            ()
        () 
    let z =
        fun x ->
            ()
            ()
            ()   

module TypeDefns =

    type rectype() =
        member __.nada = ()

    and andtype() =
        member __.nada = ()

    and andtype2() =
        member __.nada = ()


    type thenConstructor() =
        let blank = "
                not blank
    
    
                "
        do
            ()
            ()
            ()

        member __.Useless = 
            ()

        new(str:string) =
            thenConstructor()

            then   // should be an outline starting here
                ()
                ()
                ()

        new(x:int) =
            thenConstructor(
        
            // constructors need outlining too you know :P
        
        
                )                          

    { new IEnumerable with

        member __.GetEnumerator(): IEnumerator = 
            ()        
            ()
            Unchecked.defaultof<_>

    }         

    let objexrp =
        { new IEnumerable with

        member __.GetEnumerator(): IEnumerator = 
            ()        
            ()
            Unchecked.defaultof<_>

        }   

    type System.String with 

        member __.more_nothing1 =
            ()
            "nada" |> ignore 

        static member DOES_NOTHING = 
            ()
            ()
            "seriously nothing" |> ignore

        member __.more_nothing2_____ =
            ()
            "nada" |> ignore

    [<              
        AbstractClass
    
    >]
    type abclass() =

        abstract abmember : unit-> unit
                -> unit
                -> unit
                -> unit

        default __.abmember ()()()() =
            ()
            ()

        override __.ToString()  =
            ()
            ()
            ""

    let itest =

        { new IDisposable with
            member __.Dispose() = ()
            
    
    
        }   

module Cexpr =
    let ss num =
            seq{ 

                yield! 
                    seq{
                            10  ..   1000
                        }

                yield 
                    2000 + 
                    100  +
                    999
                    + match num with
                      | 0 -> 100
                      | 200 -> 1000
                      | _ -> 0
                
                
             }

    type cexprBuilder ()=
        member inline __.Zero x = x
        member inline __.Bind x f = f x
        member inline __.Return x = x
        member inline __.ReturnFrom x = x
        member inline __.Yield x = x
        member inline __.YieldFrom x = x

    let cexpr = cexprBuilder()

    let testreturn =
        cexpr{
            return 
                2000 +
                20000
        }

    let returnFromExpr num =
        cexpr{
            return! 
                20000
                + 2000
                + 3000
                + match num with
                  | 0 -> 100
                  | 200 -> 1000
                  | _ -> 0
        }


    let cexprcexpr =
        cexpr{
            yield
                cexpr{
                           yield 10
                        }
        }


    let cexprcexprbang =
        cexpr{
            yield!
                cexpr{
                           yield 10
                        }
        }

    let docexpr =
        cexpr {
            do 
                printfn "allo"
                printfn "allo"
        }

    let dobangcexpr() =
        cexpr {

            do! 
                printfn "allo"
                printfn "allo"
        }

    let notnest =
        seq{
                10  ..   1000

            }

module Branching =
    if true
        && true || true
        && true
        then
            ()
            (
            )
            ()
         
            let x =
                () 
                ()
                ()
            ()
    elif 
        true 
     && true 
     || true
        then
            ()   
            ()
            ()

    else 
    
         ()



    do
        let q =
            <@
                    ()
                    ()
    
                        @> 
        in ignore q

module Matches = 
    let matchfunction = 
        function
        | 0 ->  
                ()
                ()
                ()
                ()
        | 1 ->  ()
        | 2 ->  () 
        | 3 ->  ()
        | 4 ->  ()
                ()
                ()
                ()
        | 5 ->  ()
        | _ ->  ()
   
    let matchwith num =
        match num with
        | 0 ->
                ()
                ()
                ()
        | 1 -> ()
        | 2 -> () 
        | 3 ->
                ()
                ()
                ()
                ()
        | 4 -> ()
        | 5 ->
              num |>
                ( function
                 | 5 -> 
                        () 
                        ()
                 | _ -> ())
        | _ -> ()

module ``Loops and Iterations`` =

    
    let lscompsl =
       [ for x in 0 .. 100 ->    ()
                                 ()
                                 x ] 

    let lscomp =
       [ for x in 0 .. 100 ->    
            ()
            ()
            x ] 

    [ for x in 0 .. 100 -> 
            ()
            ()
            x] 
    
       
        |> ignore 

    do
        [ 
          for x in 0 .. 100 -> 
                ()
                ()
                x     ] 
        |> ignore
    
    for x in 0 .. 100 do
        ()
        ()

    for x = 100 downto 10 do
        ()
        ()


    for x = 100 downto 10 do
        () 

    [|  "item"
        "item"

        "item"  |] |> ignore
   
    let func _ =
        for 
            x in 0 .. 100 do
            ()
            ()

        for 
            x=100 
                downto 10 
                    do
            ()
            ()

    
        for x = 100 downto 10 do

            () |> ignore
 
module MiscExpressions =     

    let list_and_array =
 
        [   "item"
            "item"
            "item"  ] |> ignore

        [|  "item"
            "item"

            "item"  |] |> ignore
        let ls = 
            [   "item"
                "item"
                "item"  ] 

        let arr =
            [|  "item"
                "item"

                "item"  |]  
        ()


    let somef x =
        ()
        ()
        ()
        () in let somef2 y =
                    ()
                    ()
                    () in let somef3 z =
                            ()
                            ()
                            ()
                            () 

    let func x = 
        (   )
        ()
        ()

    let parend = 
        (fun x -> 
            ()
            )

    let pd =
            ()
            ()  
            
    [   "item"
        "item"
        "item"  ] |> ignore 

    let tuple =
        ( 20340,
            322,
            123123,
            212324,
            12313,
            13234,
            13424 
        )

    let squote =
        <@
            ()
            ()
                @> 

    let dqoute =
        <@@
            ()
            ()
                @@> 

    let parenlet =
        ( 
          fun x -> 
            ()
            ()
            ()  
            ) 


    do
        [ 
            "item"
            "item"
            "item"  
        ] 
            |> ignore

    do
        [|  "item"
            "item"

            "item"  |] 

            |> ignore

                     

    ()

// comblock
// comblock
// comblock

/// docblock
/// docblock 
/// docblock
/// docblock

(*
    Ocaml comments
    the best comments
*)


()

