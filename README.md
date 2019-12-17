# Triangle Tracker

#### _C#, .NET: Triangle Tracker, 12/16/2019_

## Description
Create a Triangle Tracker console application which allows the user to input the lengths of the sides of a triangle, and returns whether these sides form an equilateral, isosceles, or scalene triangle or if the sides cannot make a triangle at all.

## Application should have:
- Separate frontend and backend logic

- Make a console app with a `Triangle` class.

- Use `Console.ReadLine()` to gather three numbers from the user.

- Create a method in the `Triangle` class that takes these 3 numbers and returns what type of triangle (if any) they form:

    - Equilateral: All sides are equal;
    - Isosceles: Exactly 2 sides are equal;
    - Scalene: No sides are equal.
- Not all combinations make valid triangles. If any side is longer than the other two sides combined, the lengths cannot form a triangle. For example, 2, 2, and 8 does not make a triangle. Make sure to account for this.


## Unit Testing
| User input | Expected output |
| :------------- | :------------- |
| 3, 3, 6 | This is not a triangle. |
| 5, 5, 5 | This is not a equilateral. |
| 3, 4, 5 | This is not a scalene. |
| 8, 8, 5 | This is not a isosceles. |


## Setup/Installation Requirements

1. Clone this repo:
```
$ git clone https://github.com/misakimichy/Triangle-tracker-csharp.Solution.git
```

2. Go into the repo and run this application:
```
$ dotnet run
```

## Known Bugs
* No known bugs at this time.

## Support and contact details
 misaki.koonce@gmail.com

## Technologies Used
_Git, GitHub, C# and .NET Core


## License
Copyright © 2019 under the MIT License
