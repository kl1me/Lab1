open System

let rec NaturalInput () =
    printf "Введите натуральное число: "
    match System.Int32.TryParse(Console.ReadLine()) with
    | (true, convertInt) when convertInt > 0 -> convertInt
    | _ ->
        printfn "Ошибка: Ненатуральное число"
        NaturalInput ()

let rec NumberSum N =
    if (N=0) then
        N
    else
        N%10 + NumberSum (N/10)

[<EntryPoint>]
let main args =
    printfn "Сумма цифр: %i" (NumberSum (NaturalInput ()))
    0