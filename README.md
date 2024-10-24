# Base Conversion Tool
# Description
The Base Conversion Tool is a Windows Forms application that allows users to convert numbers from one base to another. It supports base conversions from bases 2 (binary) to 36, handling both whole and fractional numbers.
![image](https://github.com/user-attachments/assets/aca51d2c-00f5-47d7-ad02-61c4c54b6d7d)

# Features
- Input for number in any base (from 2 to 36).
- Input for source and target bases.
- Validates inputs for number and bases.
- Displays the converted number in the target base.
- 
# Requirements
- .NET Framework 4.5 or higher
- Visual Studio (for development)
- Windows OS

# Installation
1. Clone the repository or download the ZIP file.
2. Open the solution file in Visual Studio.
3. Build the solution to restore any required packages.
4. Run the application from Visual Studio or compile it for distribution.

# Usage
1. Launch the application.
2. Enter the number you want to convert in the "Number" text box.
3. Enter the source base in the "Source Base" text box.
4. Enter the target base in the "Target Base" text box.
5. Click the "Convert" button to see the result in the "Result" text box.
6. 
# Input Validation
- The application checks for valid input characters (digits or letters A-Z).
- The source base must be greater than the highest digit in the input number and less than or equal to 36.
- The target base must be a natural number between 2 and 36.

# Example
- To convert the number 1A from base 16 to base 10:

1. Enter 1A in the "Number" text box.
2. Enter 16 in the "Source Base" text box.
3. Enter 10 in the "Target Base" text box.
4. Click "Convert" to see the result.

# Development
This project is developed using C# with Windows Forms. The main logic for base conversion is encapsulated in the ConvertBase method, which handles both whole and fractional parts of the number.

# Key Methods
- ConvertBase(string number, int sourceBase, int targetBase): Converts the number from the source base to the target base.
- ConvertToDecimal(char digit): Converts a character digit to its decimal equivalent.
- ConvertToTargetBase(int value): Converts a decimal value to its target base representation.

# License
This project is open-source and available under the MIT License. Feel free to use, modify, and distribute.
