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

type rectype() =
    member __.nada = ()

and andtype() =
    member __.nada = ()

and andtype2() =
    member __.nada = ()


[ 
    "item"
    "item"
    "item"  
] 
    |> ignore

[|  "item"
    "item"

    "item"  |] 
    |> ignore

let list_and_array =
 
    [   "item"
        "item"
        "item"  ] |> ignore

    [|  "item"
        "item"

        "item"  |] |> ignore


[<  CompilationRepresentationAttribute  
    (CompilationRepresentationFlags.ModuleSuffix)
>]
module ``Who Cares?`` =
    ()


seq{        

    10  ..   1000


    } |> ignore

if true
    && true || true
    && true
    then
        ()
        (
        )
        ()

        seq{        

            10  ..   1000


        } |> ignore

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

type thenConstructor() =
    
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

   


let matchfunction =
    
    function 
    | 0 -> ()
    | 1 -> ()
    | 2 -> ()
    | 3 -> ()
    | 4 -> ()
    | 5 -> ()
    | _ -> ()
   
let matchwith num =

    match num with
    | 0 -> 
            ()
            ()
            ()
    | 1 -> ()
    | 2 -> () 
    | 3 ->  ()
            ()
            ()
            ()
    | 4 -> ()
    | 5 -> ()
    | _ -> ()

fun x -> 
    ()
    ()
    ()   


( fun x -> 
    ()
    ()
    ()  ) |> List.iter <| []

    

[ for x in 0 .. 100 -> 
    ()
    ()
    x  ]

[   "item"
    "item"
    "item"  ] |> ignore

for x in 0 .. 100 do
    ()
    ()

for x = 100 downto 10 do
    ()
    ()
    () |> ignore

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
        () |> ignore

    


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


[<AbstractClass>]
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

let itest =

    { new IDisposable with
        member __.Dispose() = ()
            
    
    
    }                        



()