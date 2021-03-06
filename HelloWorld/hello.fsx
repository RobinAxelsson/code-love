// printf ("F#: Says Hello!")

// for arg in fsi.CommandLineArgs do
//     printf $" {arg}"

// printfn ("")
open System

[<EntryPoint>]
let main(args) =    
    printfn "args: %A" args
    printfn "env.cmdline: %A" <| Environment.GetCommandLineArgs()
    0

//implicit
let showCommandLineArgs() =
for arg in Environment.GetCommandLineArgs() do
    printfn $"arg = {arg}"