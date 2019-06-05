# blockchain-csharp

### Table of Contents
**[Available For](#available-for)**<br>
**[Nuget](#nuget)**<br>
**[Supported Features](#supported-features)**<br>
**[Usage](#usage)**<br>
**[Contributing](#contributing)**<br>


## Available For
- .NET Standard 2.0
- .NET 4.6.1
- .NET 4.5


## Nuget

 ```
    PM> Install-Package Blockchain_csharp
```
[![](https://img.shields.io/nuget/v/Blockchain_csharp.svg)](https://www.nuget.org/packages/Blockchain_csharp/)\
[![](https://img.shields.io/nuget/dt/Blockchain_csharp.svg)](https://www.nuget.org/packages/Blockchain_csharp/)

## Supported Features
|Resource|Feature|Supported|
|------|--------------|-------------|
|Wallet|||
||GetBalance|**Yes**|
||TODO|**Yes**|
||TODO|**Yes**|
||TODO|**Yes**|
||TODO|**Yes**|
||TODO|**Yes**|
||TODO|**Yes**|
||TODO|**Yes**|
||TODO|**Yes**|
||TODO|**Yes**|
|TODO|||
||TODO|**Yes**|



## Usage
TODO

### Wallet Balance
TODO
```
using Blockchain.Services;
using System;

namespace ConsoleApp1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var walletAddress = "385cR5DM96n1HvBDMzLHPYcw89fZAXULJP";
            var walletRepository = new WalletRepository("API_KEY", walletAddress);
            var wallet = walletRepository.GetBalance();
            Console.WriteLine(wallet.FinalBalance);
            Console.ReadLine();
        }
    }
}
```




## Contributing

Pull requests are welcome. 

For large changes, please open an issue first to discuss what you would like to add.
