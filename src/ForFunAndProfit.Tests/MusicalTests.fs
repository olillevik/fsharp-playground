module MusicalTests

open Xunit
open FsUnit

[<Fact>]
let ``My test`` () =
    True |> should equal True
