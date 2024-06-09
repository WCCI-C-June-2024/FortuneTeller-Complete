![WE CAN Code IT](WECANCodeIT.png)

# FortuneTeller
Fortune Telling Console Application

## Overview

Develop a console application that will tell the user’s fortune based on data received from the user.

`Full fill all of the TDD unitTest`

**Skills Required**

1. Variables and Basic Types
2. Operators and Expressions
3. Conditionals
4. Strings
5. Tasks
6. Exceptions (Try, Catch, Finally)
7. Inheritance

## Part 1

### TDD Unit Test

**Note:** *TDD test should handle execptions gracefully*

- Ask the user for the user’s first name.
	- first name can not be Null or Empty
	- first name can not be greater then 50
	
- Ask the user for the user’s last name.
 	- last name can not be Null or Empty
	- last name can not be greater then 50
	
- Ask the user for the user’s age.
	- age can not be less then 0
	- age can not be greater then 130
	
- Ask the user for the user’s birth month (as an 'int').
	- birth month must be between 1 and 12
	
- Ask the user for the user's number of siblings.
	- siblings can not be greater then 13
	
- Ask the user for the user’s favorite ROYGBIV color.
	- The ROYGBIV colors are red, orange, yellow, green, blue, indigo, violet.
	
- If the user does not know what ROYGBIV is, ask the user to enter “Help” to get a list of the ROYGBIV colors.

### Create the code that completes the TDD test
User class
Validation for user

## Part 2
### TDD Unit Test

**Retirement Years**
The user's number of years until retirement will be based on whether the user's age is odd or even.

- odd	- 14 years
- even	- 12 years

**Vacation Home Location**
The location of the user's vacation home will be based on how many siblings the user has. If the user enters a number less than zero, give the user a bad location!

- 0 - Boca Raton, FL
- 1 - Nassau, Bahamas
- 2 - Ponta Negra,Brazil
- 3 - Portland, Oregon
- Greater than three - Baton Rouge, LA
- Less than zero - Chernobyl, Ukraine

**Mode of Transportation**
The user's mode of transportation will be determined by the user's favorite color.

- red - Maserati
- orange - stallion
- yellow - chariot
- green - taxi
- blue - rickshaw
- indigo - motor scooter
- violet - flying saucer

**Bank Balance**
The user's bank balance at retirement will be based on the user's birth month. If the user enters something other than 1-12 for birth month, the user's balance will be $0.00.

- 1 to 4 - $256,000.76
- 5 to 8 - $3,687,105.42
- 9 - 12 - $86.23
- anything else - $0.00

### Create the code that completes the TDD test
User Fortune

## Part 3
Display the user's fortune in this format:

[First Name] [Last Name] will retire in [# of years] with [bank balance] in the bank, a vacation home in [location], and travel by [mode of transportation].

Your program should be able to process input whether a user enters capital or lowercase letters.

## Stretch Tasks (Optional)
1. Give the user the ability to quit the program by typing "Quit" (should not be case sensitive) at any point where the program is looking for user input. 
		The program should print “Nobody likes a quitter...” before ending. 



