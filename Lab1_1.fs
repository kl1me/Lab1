open System
let rec CharInput () = 
    printf "Введите символ: "
    let x = Console.ReadLine()
    if ((String.length x)>1) then
        printfn "Ошибка: Введено больше одного символа!"
        CharInput ()
    else
        x

let ListInput =
    let x = CharInput ()
    let y = CharInput ()
    [x;y]

let rec NaturalInput () =
    printf "Введите натуральное число: "
    match System.Int32.TryParse(Console.ReadLine()) with
    | (true, convertInt) when convertInt > 0 -> convertInt
    | _ ->
        printfn "Ошибка: Ненатуральное число"
        NaturalInput ()

let rec ListRepeat SummList OriginalList N =
    if (N=0) then
        SummList
    else 
        ListRepeat (SummList @ OriginalList) OriginalList (N-1)


[<EntryPoint>]
let main args =
    printfn "Список: %A" (ListRepeat [] ListInput (NaturalInput ()))

    0

