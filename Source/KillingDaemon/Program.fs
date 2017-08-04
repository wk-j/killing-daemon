// Learn more about F# at http://fsharp.org

open System
open System.Diagnostics
open System.Runtime.Loader

AssemblyLoadContext.Default.add_Unloading(fun c -> Console.WriteLine("Unload"))

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    while Console.ReadLine() <> "q" do
        printfn ">> "
    0 // return an integer exit code
