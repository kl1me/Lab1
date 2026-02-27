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
    printf "Введите количество повторений: "
    let x = int(Console.ReadLine())
    if (x<1) then
        printfn "Ошибка: Ненатуральное число"
        NaturalInput ()
    else
        x

let rec ListRepeat SummList OriginalList N =
    if (N=0) then
        SummList
    else 
        ListRepeat (SummList @ OriginalList) OriginalList (N-1)


[<EntryPoint>]
let main args =
    printfn "Список: %A" (ListRepeat [] ListInput (NaturalInput ()))
    0