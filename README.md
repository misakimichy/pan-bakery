# Pan Bakery

#### _C#, .NET: Pan Bakery 9/27/2019_

## Description
Create a C# console application for a bakery.

## Application should have:
- There should be two classes: one for `Bread` and one for `Pastry`.

- When the user runs the application, they should receive a prompt with a welcome message along with the cost for both `Bread` and `Pastry`.

- A user should be able to specify how many loaves of `Bread` and how many `Pastry`s they'd like.

- The application will return the total cost of the order.

- The bakery offers the following deals:

    - Bread: Buy 2, get 1 free. A single loaf costs $5.
    - Pastry: Buy 1 for $2 or 3 for $5.


## Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| **$5 for 1 bread and $2 for 1 pastry** | 1 bread and 1 pastries | $10 total ($5 + $2) |
| **$10 for 3 breads and $5 for 3 pastries** | 3 breads, 3 pastries | $15 total ($10 + $5) |
| **Enter besides number**| "Hello" | "Please enter number to purchase." |
| **Not purchasing breads nor pastries** | "N" | "Thank you for visiting us. See you next time!" |

## Setup/Installation Requirements

1. Clone this repo:
```
$ git clone https://github.com/misakimichy/pan-bakery.git
```

2. Go into the repo and run this application:
```
$ dotnet run
```

## Known Bugs
* No known bugs at this time.

## Support and contact details
Please contact misaki.koonce@gmail.com with questions and feedbacks.

## Technologies Used
_Git, GitHub, C# and .NET Core


## License
Copyright © 2019 under the MIT License