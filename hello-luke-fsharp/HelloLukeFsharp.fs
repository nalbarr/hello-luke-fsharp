module HelloLukeFsharp

let iterateScalar1DWithIndexes =
  printfn "*** iterateScalars1DWithIndexes"

let iterateScalars1DWithCollections() =
  printfn "*** iterateScalars1DWithCollections"
let iterateObjects1DWithIndexes() =
  printfn "*** iterateObjects1DWithIndexes"        

let iterateInterfaces1DWithCollections() =
  printfn "*** iterateInterfaces1DWithCollections"

let iterateInterface1DWithSpecificTypeCasts() =
  printfn "*** iterateInterface1DWithSpecificTypeCasts"

let collectionsComplexity() =
  printfn "*** collectionsComplexity()"

// implicit
let foo x = x + 1
let bar y = y * 2

// explicit
let foo2(x: int): int = x + 1
let bar2(y: int): int = y * 2

[<EntryPoint>]
let main argv =
  //let someBar = bar 5
  //let someFoo = foo someBar

  // 1D as array, list or linear algebra vector of scalars
  //iterateScalars1DWithIndexes

  // 1D as array, list or linear algebra vector of scalars
  //iterateScalars1DWithCollections

  // 1D as array, list or linear algebra vector of <Object>
  //iterateObjects1DWithIndexes

  // 1D as collection of interfaces
  //iterateInterfaces1DWithCollections

  // 1D as collection of interfaces with type casting
  //iterateInterface1DWithSpecificTypeCasts

  // 1D as different collection types for different operations (e.g., get)
  //collectionsComplexity

  let foo_5 = foo 5
  let bar_5 = bar 5
  let foo2_5 = foo2 5
  let bar2_5 = bar2 5

  assert(foo_5 = 6)

  printfn "foo_5: %i" (foo_5) 
  printfn "bar_2: %i" (bar_5)
  printfn "foo2_5: %i" (foo2_5) 
  printfn "bar2_5: %i" (bar2_5)
  
  0 // return an integer exit code